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
using static System.Windows.Forms.CheckedListBox;

[assembly:log4net.Config.XmlConfigurator(Watch = true)]
namespace CheckedListBoxEx
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
            log.Debug("Form1 Loaded!!");
            MakeCheckedList();
            // 원클릭으로 체크 됨
            checkedListBox1.CheckOnClick = true;
            // 0번 인덱스 선택 됨.
            checkedListBox1.SetItemChecked(0, true);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            string item = checkedListBox1.SelectedItem.ToString();

            string labelString = string.Format("{0}/{1}이 선택됨.", index, item);
            selectedItem.Text = labelString;
            log.Debug(labelString);
                     
        }


        private void MakeCheckedList()
        {
            List<string> list = new List<string>();

            // enum 의 갯수 가져오기
            int len = Enum.GetNames(typeof(Country)).Length;
            //enum for 돌리기
            for (int i = 0; i < len; ++i)
            {
                //log.Debug(Enum.GetName(typeof(Country),i));
                list.Add(Enum.GetName(typeof(Country), i));
            }

            // enum foreach 돌리기
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                //log.Debug(country);
                list.Add(country.ToString());
            }

            // UpCasting이라 런타임 에러 발생함
            //list.AddRange((IEnumerable<string>)Enum.GetValues(typeof(Country)));

            this.checkedListBox1.Items.AddRange(list.ToArray());

            if (this.checkedListBox1.Items.Count > 0)
            {
                log.Debug("CheckedListBox is NotEmpty!!");
                log.Debug(this.checkedListBox1.Items.ToString());
                log.Debug(this.checkedListBox1.Items.Count);
                foreach (var item in this.checkedListBox1.Items)
                {
                    log.Debug(item.ToString());
                }
            }
            else
            {
                log.Debug("CheckedListBox is Empty!!");
                log.Debug(this.checkedListBox1.Items.ToString());
            }

            //아래처럼 쓸 수도 있으나 클릭했을 때 체크가 안 됨.
            //CheckedListBox.ObjectCollection oc_checkedListBox1 =
            //    new CheckedListBox.ObjectCollection(this.checkedListBox1);
            //oc_checkedListBox1.AddRange(list.ToArray());

            //if (oc_checkedListBox1.Count > 0)
            //{
            //    log.Debug("Oc_checkedListBox is NotEmpty!!");
            //    log.Debug(oc_checkedListBox1.ToString());
            //    log.Debug(oc_checkedListBox1.Count);
            //    foreach (var item in oc_checkedListBox1)
            //    {
            //        log.Debug(item.ToString());
            //    }
            //}
            //else
            //{
            //    log.Debug("Oc_checkedListBox is Empty!!");
            //    log.Debug(oc_checkedListBox1.ToString());
            //}
        }

    }

    enum Country
    {
        KOREA,//한국=0
        USA,
        UK,
        JAPAN,
        CHINA,
        INDIA,
        FRANCE,
        GERMANY,
        ITALY,
        SPAIN
    }
}
