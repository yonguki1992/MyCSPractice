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
namespace NotifyIconEx
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

            // Notify Icon에 컨텍스트 메뉴 추가
            ContextMenu context = new ContextMenu();
            context.MenuItems.Add(new MenuItem("열기"));
            context.MenuItems.Add(new MenuItem("실행"));
            context.MenuItems.Add("-");
            context.MenuItems.Add(new MenuItem("종료", new EventHandler((s, ex) => this.Close())));

            notifyIcon1.ContextMenu = context;

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //icon을 더블클릭하면 폼 화면을 띄워줌
            log.Debug("Noti Icon Double Click!!");
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                log.Debug("Form state => Normal");
            }
            this.Activate();
        }
    }
}
