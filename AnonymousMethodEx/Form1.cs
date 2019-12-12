using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethodEx
{
    public partial class Form1 : Form
    {
        private Thread MyThread;

        public Form1()
        {
            InitializeComponent();
            // 메서드명을 지정
            this.btn1.Click += new EventHandler(this.button1_Click);

            // 무명메서드를 지정
            this.btn2.Click += delegate (object obj, EventArgs args)
            {
                MessageBox.Show("버튼2 클릭 "+args.GetType().Name);
            };

            /*
             * C#의 delegate 키워드는 델리게이트 타입을 정의할 때도 사용되고, 
             * 무명메서드를 정의할 때도 사용된다. 
             * 
             * 무명메서드는 이름이 없는 메서드 자체만을 가리키는 것으로
             * 그 자체로 Delegate 타입이 되는 것은 아니다.
             * delegate() => '익명메서드'() 라는 의미
             * */

            //무명 메서드1 : 이벤트 핸들러 객체를 생성해서 파라미터로 무명 메서드를 전달
            this.button1.Click += new EventHandler(delegate (object obj, EventArgs args)
            {
                MessageBox.Show("OK");
            });

            //무명 메서드2 : 이벤트 핸들러 캐스팅을 함
            this.button1.Click += (EventHandler)delegate (object obj, EventArgs args)
            {
                MessageBox.Show("OK?");
            };

            //무명 메서드3 : 이벤트 핸들러 캐스팅을 생략할 수 있다.
            this.button1.Click += delegate (object obj, EventArgs args)
            {
                MessageBox.Show("OK!!");
            };

            //무명 메서드4 : 파라미터를 사용하지 않을 경우
            //DelegateEx04.MyArea의 생성자 확인해볼것
            this.button1.Click += delegate
            {
                MessageBox.Show("!!OK??");
            };

            /* 
            MethodInvoker는 입력 파라미터가 없고, 리턴 타입이 void인 델리게이트이다.
            MethodInvoker는 System.Windows.Forms 에 다음과 같이 정의되어 있다.

            public delegate void MethodInvoker();

            Invoke는 스레드 안에서 돌아간다.
            */
            //Invoke 예제1 : delegate 타입이 아니다 무명 메서드일 뿐
            //this.Invoke(delegate
            //{
            //    //무명 메서드는 대리자(delegate)형식이 아닙니다.(에러)
            //    button2.Text = "나 버튼";
            //});

            //Invoke 예제2
            //MethodInvoker mi = new MethodInvoker(delegate ()
            //{
            //    button2.Text = "나는 버튼임!!";
            //});
            //this.Invoke(mi);

            //Invoke 예제3 : 예제1의 맞는 표현
            //this.Invoke((MethodInvoker)delegate
            //{
            //    button2.Text = "나 버튼";
            //});
            this.button2.Click += delegate
            {
                //스레드 재시작
                if(!MyThread.IsAlive)
                {
                    button2.Text = "";
                    MyThread = new Thread(ChangeText);
                    MyThread.Start();
                }
            };
        }

        private void button1_Click(object sender, EventArgs args)
        {

            MessageBox.Show("버튼1 클릭 "+ args.GetType().Name);
        }

        /*
         * 델리게이트 타입을 정의하는 아래 첫번째 예의 경우, 
         * SumDelegate는 Delegate 클래스 타입명을 가리키게 되고, 
         * 클래스 객체를 생성할 때와 같이 new를 사용하여 Delegate 객체를 생성하고 
         * 이 객체에 특정 메서드를 연관시켜 할당하게 된다.
         * */
        //Delegate 타입
        public delegate int SumDelegate(int a, int b);

        //Delegate 사용
        private SumDelegate sumDel = new SumDelegate(sum);

        private static int sum(int a, int b)
        {
            return a + b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //스레드 등록
            MyThread = new Thread(ChangeText);

            MyThread.Start();
        }

        public void ChangeText()
        {
            string str = "나는 버튼임!!";
            for(int i =0; i<str.Length ;++i)
            {
                //1초마다 한 글자씩 추가됨.
                Thread.Sleep(1000);
                MethodInvoker mi = new MethodInvoker(delegate ()
                {
                    if(i < str.Length)
                    {
                        button2.Text += str[i];
                    }
                });
                this.Invoke(mi);

            }
        }
    }
}
