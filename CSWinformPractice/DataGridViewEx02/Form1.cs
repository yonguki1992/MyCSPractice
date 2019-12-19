using log4net;
using System;
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
        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initialized");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'kYUDBDataSet.Scores' 테이블에 로드합니다.
            // 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            log.Debug("Form1 loaded!!");
            this.scoresTableAdapter.Fill(this.kYUDBDataSet.Scores);
        }

        // 갱신 데이터 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            log.Debug("btnSave Clicked!!");
            //DataSource 로부터 DataSet 객체를 추출
            //TestDBDataSet 은 자동 생성된 DataSet 파생 클래스
            BindingSource bs = dataGridView1.DataSource as BindingSource;
            KYUDBDataSet dataSet = bs.DataSource as KYUDBDataSet;
            //자동 갱신 된 TableAdapter 클래스의 Update() 호출,
            //갱신 데이타 소스인 DataTable을 파라미터로 넘김
            this.scoresTableAdapter.Update(dataSet.Scores);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            log.Debug("dataGridView1 Cell Clicked!!");
            if (e.RowIndex < 0)
            {
                log.Debug("not cell");
                return;
            }
            if(e.ColumnIndex < 0)
            {
                log.Debug("not cell");
                return;
            }

            DataGridViewCell cell =
                (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //MessageBox.Show(cell.Value+"");
            log.Debug(cell.Value.ToString());
        }
    }
}
