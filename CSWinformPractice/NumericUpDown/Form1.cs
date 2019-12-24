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
namespace NumericUpDown
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
            // 현재값
            numericUpDown1.Value = 21.0M;
            //최대값
            numericUpDown1.Maximum = 100;
            //최소값
            numericUpDown1.Minimum = -100;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //섭씨 -> 화씨
            decimal C = numericUpDown1.Value;
            decimal F = C * (9.0M/5.0M)+32.0M;

            //화씨 출력
            textBox1.Text = F.ToString();
        }
    }
}
