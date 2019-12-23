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
namespace ListBoxEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        private MemberType memberType;

        public Form1()
        {
            InitializeComponent();
            log.Debug("Form1 initialized");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Debug("Form1 loaded");
            memberListBox.Items.AddRange(Enum.GetNames(typeof(MemberType)));

            // 정회원이 기본선택
            memberListBox.SelectedIndex = 1;
        }

        private void memberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            memberType = (MemberType)memberListBox.SelectedIndex;
            log.Debug(memberType.ToString());
            selectedItem.Text = memberType.ToString();
        }
    }
}
