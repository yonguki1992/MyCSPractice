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

[assembly :log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace DateTimePickerEx
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
        }

        private void picker_ValueChanged(object sender, EventArgs e)
        {
            string msg = "";
            if ((sender as DateTimePicker) == pickerLong)
            {
                log.Debug("date picker(long)'s value changed");
                DateTime dt = pickerLong.Value;
                msg = string.Format("{0}월 {1}일을 선택함!!", dt.Month, dt.Day);
            }
            else if ((sender as DateTimePicker) == pickerShort)
            {
                log.Debug("date picker(short)'s value changed");
                DateTime dt = pickerShort.Value;
                msg = string.Format("{0}월 {1}일을 선택함!!", dt.Month, dt.Day);
            }
            else if ((sender as DateTimePicker) == pickerTime)
            {
                log.Debug("date picker(time)'s value changed");
                DateTime dt = pickerTime.Value;
                msg = string.Format("{0}월 {1}일을 선택함!!", dt.Month, dt.Day);
            }
            else if ((sender as DateTimePicker) == pickerCustom)
            {
                log.Debug("date picker(custom)'s value changed");
                DateTime dt = pickerCustom.Value;
                msg = string.Format("{0}월 {1}일을 선택함!!", dt.Month, dt.Day);
            }
            MessageBox.Show(msg, "선택날짜");
        }
    }
}
