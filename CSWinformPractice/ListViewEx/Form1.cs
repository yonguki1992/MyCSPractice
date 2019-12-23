using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly : log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace ListViewEx
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
            this.Text = "ListView 컨트롤 예제";

            //현재 디렉토리 내의 파일리스트 얻기
            string currDir = Environment.CurrentDirectory;
            DirectoryInfo dirInfo = new DirectoryInfo(currDir);
            FileInfo[] files = dirInfo.GetFiles();

            //리스트뷰 아이템을 업데이트 하기 시작
            // 업데이트가 끝날 때까지 UI 갱신 중지
            listView1.BeginUpdate();

            // 뷰모드 직접 지정
            listView1.View = View.Details;

            //아이콘을 위해 이미지 지정
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            foreach(var fi in files)
            {
                //각 파일 별로 listviewitem 객체를 하나씩 만듬
                // 파일명, 사이즈, 날짜 정보를 추가
                ListViewItem listViewItem = new ListViewItem(fi.Name);
                listViewItem.SubItems.Add(fi.Length.ToString());
                listViewItem.SubItems.Add(fi.LastWriteTime.ToString());
                listViewItem.ImageIndex = 0;

                listView1.Items.Add(listViewItem);
            }

            //컬럼과 컬럼 사이즈 지정
            listView1.Columns.Add("파일명", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("사이즈", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("날짜", 150, HorizontalAlignment.Left);

            //리스트뷰를 refresh 하여 보여줌
            listView1.EndUpdate();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radioDetail.Checked && radio == radioDetail)
            {
                log.Debug("자세히");
                listView1.View = View.Details;

            }
            else if (radioList.Checked && radio == radioList)
            {
                log.Debug("목록보기");
                listView1.View = View.List;

            }
            else if (radioTitle.Checked && radio == radioTitle)
            {
                log.Debug("제목만");
                listView1.View = View.Tile;

            }
            else if (radioSmallIcon.Checked && radio == radioSmallIcon)
            {
                log.Debug("작은아이콘");
                listView1.View = View.SmallIcon;

            }
            else if (radioLargeIcon.Checked && radio == radioLargeIcon)
            {
                log.Debug("큰아이콘");
                listView1.View = View.LargeIcon;

            }

        }
    }
}
