using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateEx04
{
    class MyArea : Form
    {
        
        public MyArea()
        {
            this.MouseClick += delegate { MyAreaClicked(); };

        }

        public delegate void ClickEvent(object sender);

        // event 필드
        public event ClickEvent MyClick;

        public void MyAreaClicked()
        {
            if(MyClick != null)
            {
                Console.WriteLine(MyClick.Method);
                MyClick(this);
            }
        }


    }

}
