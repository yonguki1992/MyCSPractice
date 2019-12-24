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
namespace ProgressbarEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        private Timer timer;
        private int timerCount = 0;

        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initialized");

            //timer = new Timer();
            //timer.Interval = 1000;
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 한 스텝 이동
            progressBar1.PerformStep();
            progressBar2.PerformStep();

            if(++timerCount == 10)
            {
                progressBar3.Enabled = false;
                timer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 loaded");
            // 기본값 사용(max 100, min 0, step 10)
            progressBar2.Style = ProgressBarStyle.Blocks;

            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Step = 5; //간격
            progressBar2.Value = 0;

            //Marquee 스타일
            progressBar3.Style = ProgressBarStyle.Marquee;
            progressBar3.Enabled = true;

            //테스트를 위해 타이머 시작
            timer.Start();
        }
    }
}
