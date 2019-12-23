using log4net;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config",Watch = true)]
namespace DataGridViewEx02
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        private static readonly string INSERT_COMMAND =
            "INSERT INTO [Scores] ([Class], [Score]) VALUES (@Class, @Score)";

        public Form1()
        {
            InitializeComponent();
            //log.Debug("Form1 initialized");
            //쿼리 명령문 일부 변경함
            this.scoresTableAdapter.Adapter.InsertCommand.CommandText = INSERT_COMMAND;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'kYUDBDataSet.Scores' 테이블에 로드합니다.
            // 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //log.Debug("Form1 loaded!!");
            this.scoresTableAdapter.Fill(this.kYUDBDataSet.Scores);

            // lastUpdate 컬럼을 읽기 전용(편집 불가)으로
            this.dataGridView1.Columns[3].ReadOnly = true;

            //for (int i = 0; i < this.dataGridView1.RowCount; ++i)
            //{
            //    this.dataGridView1.Rows[i].Cells[3].ReadOnly = true;
            //}

            //this.dataGridView1.Rows[23].Cells[0].Value = "123";
        }

        // 갱신 데이터 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            log.Debug("btnSave Clicked!!");
            //DataSource 로부터 DataSet 객체를 추출
            //KYUDBDataSet 은 자동 생성된 DataSet 파생 클래스
            BindingSource bs = dataGridView1.DataSource as BindingSource;
            KYUDBDataSet dataSet = bs.DataSource as KYUDBDataSet;
            //자동 갱신 된 TableAdapter 클래스의 Update() 호출,
            //갱신 데이타 소스인 DataTable을 파라미터로 넘김
            this.scoresTableAdapter.Update(dataSet.Scores);

            // 다시 부름
            this.scoresTableAdapter.Fill(this.kYUDBDataSet.Scores);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            log.Debug("Cell("+e.ColumnIndex+","+e.RowIndex+") is Clicked!!");
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                //log.Debug("not a cell");
                return;
            }

            DataGridView grid = sender as DataGridView;

            DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            // 셀의 데이터 변경하기
            //cell.Value = "Z반";

            //log.Debug(cell.Value.ToString());
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //log.Debug("dataGridView1 Cell MouseDown!!");
            
            // Row 헤더, Column 헤더인 경우 그냥 리턴
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                //log.Debug("not a cell");
                return;
            }
            // 오른쪽 마우스 버튼인 경우
            if(e.Button == MouseButtons.Right)
            {
                DataGridView grid = sender as DataGridView;

                // 마우스 우클릭해도 현재 cell을 포커스로
                grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            //log.Debug("셀 바뀜");
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Debug("수정");
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log.Debug("삭제");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            log.Info("cell("+e.ColumnIndex +", "+e.RowIndex+")에서 에러발생" );
            log.Error(e.Exception);
            SystemSounds.Beep.Play();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            log.Info("cell(" + e.ColumnIndex + ", " + e.RowIndex + ") 편집 종료");

            DataGridView grid = sender as DataGridView;
            DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            log.Info("Cell(" + e.ColumnIndex + ", " + e.RowIndex + ") = " + cell.Value);
            log.Info("값은 int 입니다" + (cell.Value is int));
            log.Info("값은 str 입니다" + (cell.Value is string));
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char C = e.KeyChar;
            
            if (Char.IsLetter(C) == true)
            {
                log.Info(C+" 키 누름");
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            log.Info("그리드 편집 중");

            if (e.Control is TextBox)
            {
                DataGridView grid = sender as DataGridView;
                DataGridViewCell cell = grid.CurrentCell;

                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);

                if (e.Control is TextBox && cell.ColumnIndex == 2)
                {
                log.Info("정수 텍스트 박스 편집 중");
                    tb.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                }
            }
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            log.Info("데이터 유효성 검사 시작");
            log.Debug("cell(" + dataGridView1.CurrentCell.ColumnIndex +
                        "," + dataGridView1.CurrentCell.RowIndex + ")의 유효성 검사 시작");

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            DataGridViewCell[] cell = new DataGridViewCell[dataGridView1.ColumnCount];

            for (int i = 1; i < cell.Length-1; ++i)
            {
                cell[i] = row.Cells[i];
                log.Debug(cell[i].Value);

            }
            e.Cancel = !(isClassGood(cell[1]) && isScroresGood(cell[2]));
        }

        private bool isClassGood(DataGridViewCell cell)
        {

            if (cell.Value.ToString().Length == 0)
            {
                cell.ErrorText = "클래스 이름을 입력하세요";
                dataGridView1.Rows[cell.RowIndex].ErrorText =
                    "클래스 이름을 입력하세요";
                dataGridView1.CurrentCell = cell;
                return false;
            }
            return true;
        }

        private bool isScroresGood(DataGridViewCell cell)
        {

            int cellValueAsInt;
            if (cell.Value.ToString().Length == 0)
            {
                cell.ErrorText = "숫자를 한 자리 이상 입력하세요";
                dataGridView1.Rows[cell.RowIndex].ErrorText =
                    "숫자를 한 자리 이상 입력하세요";
                dataGridView1.CurrentCell = cell;
                return false;
            }
            else if (!int.TryParse(cell.Value.ToString(), out cellValueAsInt))
            {
                cell.ErrorText = "Scores 는 숫자만 입력할 수 있습니다.";
                dataGridView1.Rows[cell.RowIndex].ErrorText =
                    "Scores 는 숫자만 입력할 수 있습니다.";
                dataGridView1.CurrentCell = cell;
                return false;
            }
            return true;

        }
    }
}
