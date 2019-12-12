using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerEx
{
    class Program
    {
        //작동되는 코드는 아님
        static void Main(string[] args)
        {
            new Program().Run();
        }
        public void Run()
        {
            MyButton btn = new MyButton();
            // Click 이벤트에 대한 이벤트 해들러로
            // btn_Click 이라는 메서드를 지정함.
            btn.Click += new EventHandler(btn_Click);
            btn.Text = "Run";
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 클릭");
        }

        class MyButton
        {
            public string Text;

            public event EventHandler Click;

            public void MouseButtonDown()
            {
                if (this.Click != null)
                {
                    // 이벤트 핸들러들을 호출
                    Click(this, EventArgs.Empty);
                }
            }
        }
    }

}
