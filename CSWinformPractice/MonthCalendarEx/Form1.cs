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
namespace MonthCalendarEx
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
            //초기 선택범위 지정
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(4);

            // 최대 선택 수 늘리기:기본은 7일임
            monthCalendar1.MaxSelectionCount = 31;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 사용자 캘린더 날짜 변경하면 텍스트 박스에 내용 변경함
            startDateTextBox.Text = monthCalendar1.SelectionStart.ToShortDateString();
            endDateTextBox.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }


    }
}
