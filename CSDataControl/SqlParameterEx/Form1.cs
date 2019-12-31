using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly : log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace SqlParameterEx
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
            log.Debug("Form1 loaded");

            DataSet ds = MyUtils.GetScores("E반", new DateTime(2019, 12, 23));
            log.Debug(new DateTime(2019, 12, 23));
            dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = MyUtils.QueryByClass("E");
            log.Debug(ds2);
            dataGridView2.DataSource = ds2.Tables[0];

            int[] arr = MyUtils.UsingStoredProcedure(24);
            StringBuilder sb = new StringBuilder();
            sb.Append("out = ").Append(arr[0]).Append(" / return = ").Append(arr[1]);
            label1.Text = sb.ToString();
        }
    }
}
