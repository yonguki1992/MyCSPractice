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

//configFile : log4net 설정 파일 이름, Watch : true면 설정 파일이 변경되는지 검사함
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace DataGridViewEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initialized!!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 loaded!!");
            //dataset을 가져옴
            DataSet dataSet = GetData();

            // datasource 속성을 설정
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private DataSet GetData()
        {
            string strConn = "Data Source=.;Initial Catalog=KYUDB;Integrated Security=SSPI;";

            SqlConnection conn = new SqlConnection(strConn);
            log.Debug("conn = " + conn.Database);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SCORES", conn);
            log.Debug("adapter = " + adapter.ToString());

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            log.Debug("dataSet.Tables.Count = " + dataSet.Tables.Count);
            log.Debug("dataSet = " + dataSet.Tables[0].ToString());

            return dataSet;
        }
    }
}
