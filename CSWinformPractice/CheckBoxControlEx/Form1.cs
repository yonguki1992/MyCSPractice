using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace CheckBoxControlEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            log.Debug("Form1.checkBox2_CheckedChanged() started..");
            log.Debug("이벤트 체크박스 체크 여부 : "+checkBox2.Checked);
            this.checkEvent1.Checked = this.checkBox2.Checked;
            this.checkEvent2.Checked = this.checkBox2.Checked;
        }
    }
}
