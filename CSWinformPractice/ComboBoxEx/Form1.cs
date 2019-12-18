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

[assembly:log4net.Config.XmlConfigurator(Watch = true)]
namespace ComboBoxEx
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectedItem1.Text = "";
            selectedItem2.Text = "";
            selectedItem3.Text = "";
            log.Debug("Form1 loaded!!");
            List<string> data = new List<string>();
            foreach(var fruit in Enum.GetNames(typeof(EFruit)))
            {
                data.Add(fruit.ToString());
            }
            // 콤보박스에 데이터 초기화
            comboBoxSimple.Items.AddRange(data.ToArray());

            data.Clear();
            foreach(var country in Enum.GetNames(typeof(ECountry)))
            {
                data.Add(country.ToString());
            }
            // 콤보박스에 데이터 초기화
            comboBoxDropDown.Items.AddRange(data.ToArray());

            data.Clear();
            foreach(var person in Enum.GetNames(typeof(EPerson)))
            {
                data.Add(person.ToString());
            }
            // 콤보박스에 데이터 초기화
            comboBoxDropDownList.Items.AddRange(data.ToArray());

            // 처음 선택값
            comboBoxSimple.SelectedIndex = 0;
            comboBoxDropDown.SelectedIndex = 0;
            comboBoxDropDownList.SelectedIndex = 0;



        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //log.Debug("GetType : " + sender.GetType());    //타입
            //log.Debug("ToString : " + sender.ToString());   //타입과 아이템 갯수

            // sender.Equals 로 어떤것이 눌렸나 확인 가능
            //log.Debug("Is Simple? " + (sender == comboBoxSimple));   // false
            //log.Debug("Is Drop Down? " + (sender == comboBoxDropDown)); // true
            //log.Debug("Is Drop Down List? " + (sender == comboBoxDropDownList)); //false

            string item = ((ComboBox)sender).SelectedItem as string;
            int itemIdx = ((ComboBox)sender).SelectedIndex;

            // simple 리스트를 선택
            if (sender == comboBoxSimple)
            {
                selectedItem1.Text = item;
                log.Debug(string.Format("SelectedIndexChanged)Fruit[{0}] : {1}", itemIdx, item));
            }
            // 드롭다운 선택
            else if (sender == comboBoxDropDown)
            {
                selectedItem2.Text = item;
                log.Debug(string.Format("SelectedIndexChanged)Country[{0}] : {1}", itemIdx, item));
            }
            // 드롭다운 리스트 선택
            else if (sender == comboBoxDropDownList)
            {
                selectedItem3.Text = item;
                log.Debug(string.Format("SelectedIndexChanged)Person[{0}] : {1}", itemIdx, item));
            }
        }

        //콤보박스 입력폼에 텍스트를 입력할 때만 동작, 직접 선택은 안 먹힘
        private void comboBox_TextUpdate(object sender, EventArgs e)
        {
            string text = ((ComboBox)sender).Text as string;

            // simple 리스트를 선택
            if (sender == comboBoxSimple)
            {
                selectedItem1.Text = text;
                log.Debug(string.Format("TextUpdate)text : {0}", text));
            }
            // 드롭다운 선택
            else if (sender == comboBoxDropDown)
            {
                selectedItem2.Text = text;
                log.Debug(string.Format("TextUpdate)text : {0}", text));
            }
            // 드롭다운 리스트는 텍스트를 못바꿈
            //else if (sender == comboBoxDropDownList)
            //{
            //    selectedItem3.Text = text;
            //    log.Debug(string.Format("TextUpdate)text : {0}", text));
            //}

            
        }

        //입력폼에 텍스트를 넣건 다른것을 고르던간 어쨋든 바뀌면 동작
        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            string text = ((ComboBox)sender).Text as string;
            
            //텍스트 바꾸는 것으론 인덱스 못 얻음
            int itemIdx = ((ComboBox)sender).SelectedIndex;
            log.Debug(string.Format("TextChanged)text : {0}, index : {1}", text, itemIdx));

        }
    }
 }
