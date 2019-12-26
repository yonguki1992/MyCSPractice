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

[assembly : log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SqlDataReaderEx02
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        private static readonly string CONNECTION =
            "server=localhost,1433; Database=KYUDB; UID=KimYongUk; PWD=123456;";
        private static readonly string SELECT_ALL =
            "select * from scores";
        private static readonly string SELECT_COUNT =
            "select count(*) from scores";
        private static readonly string SELECT_BY_ID =
            "select * from scores where id=@id";
        private static readonly string INSERT =
            "insert into scores(class, score) values(@class, @score)";


        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initialized");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 loaded");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Debug("btn1 Clicked");
            SqlDataReader dataReader = GetDataReader();
            if (dataReader.Read())
            {
                string Class = dataReader["Class"].ToString();

                MessageBox.Show(Class);
            }

            dataReader.Close();
        }

        public SqlDataReader GetDataReader()
        {
            // 1. SqlConnection 만들고
            SqlConnection conn = new SqlConnection(CONNECTION);
            conn.Open();

            // 2. 쿼리명령어와 만들어진 SqlConnection로 SqlCommand 생성 
            //SqlCommand cmd = new SqlCommand(SELECT_ALL, conn);
            // 필요에 따라 미완성 쿼리 명령어를 작성해야하는 경우
            SqlCommand cmd = new SqlCommand(SELECT_BY_ID, conn);

            // 2-1. SqlParameter 로 미완성 쿼리의 변수 값을 설정한다.
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = 10
            };

            // 2-2. SqlCommand 객체의 Parameters 속성에 추가한다.
            cmd.Parameters.Add(idParam);

            // 2-3. 완성된 명령어로 준비(prepare)한다.
            cmd.Prepare();

            // 3. SqlCommand로 SqlDataReader을 받아와 한 줄 씩 실행한다.
            // Connection Leak 발생 Connection이 안 닫힘
            // 문제점 해결 cmd.ExecuteReader(); 대신 아래와 같이 사용한다.
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            
            return dataReader;
        }
    }
}
