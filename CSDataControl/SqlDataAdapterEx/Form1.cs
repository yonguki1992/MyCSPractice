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
namespace SqlDataAdapterEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        private int startRecordPosition = 0;
        private const int MAX_RECORDS = MySqlUtils.MAX_RECORDS;

        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initialized");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 loaded");
            //GetData 메서드 호출하여 데이터셋 가져옴
            DataSet ds = MySqlUtils.GetData();

            log.Debug("ds=" + ds.Tables);
            //dataSet을 그리드뷰에 바인딩
            dataGridView1.DataSource = ds.Tables[0];



            DataSet dsPaging = MySqlUtils.GetDataInPaging(startRecordPosition);
            log.Debug("dsPaging=" + dsPaging.Tables);
            //dataSet을 그리드뷰에 바인딩
            dataGridView2.DataSource = dsPaging.Tables[0];

            DataSet dsMulti = MySqlUtils.GetDataMulti(1,10);
            log.Debug("dsMulti="+dsMulti.Tables);

            //dataGridView3.DataBindings.Add(new Binding("DataSource", dsMulti, "scores"));
            dataGridView3.DataSource = dsMulti.Tables[0];
            dataGridView4.DataSource = dsMulti.Tables[1];
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            log.Debug("이전 버튼 클릭");
            if (startRecordPosition < MAX_RECORDS) return;

            startRecordPosition -= MAX_RECORDS;

            DataSet ds = MySqlUtils.GetDataInPaging(startRecordPosition);

            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "scores";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            int endRecord = startRecordPosition + MAX_RECORDS - 1;
            log.Debug("다음 버튼 클릭");
            if (endRecord >= MySqlUtils.SelectCount()) return;

            startRecordPosition += MAX_RECORDS;

            DataSet ds = MySqlUtils.GetDataInPaging(startRecordPosition);

            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "scores";
        }
    }
}
