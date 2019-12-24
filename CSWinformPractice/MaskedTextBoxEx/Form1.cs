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

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace MaskedTextBoxEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initailized");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 loaded");

            // 0은 반드시 숫자 입력이 필요
            // 9는 숫자나 공란
            maskedHPTextBox.Mask = "(999)000-0000";
        }

        private void maskedHPTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //(999) 인 경우
            if(e.Position < 5)
            {
                toolTip1.Show("숫자나 공백만 입력가능", this);
            }
            // 000-0000
            else
            {
                toolTip1.Show("숫자만 입력가능", this);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string val = maskedHPTextBox.Text;
            MessageBox.Show(val);
        }

    }
}
