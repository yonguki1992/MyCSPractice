using System;
using System.Windows.Forms;

namespace DelegateEx03
{
    internal class MyArea : Form
    {
        public MyArea()
        {
            this.MouseClick += delegate { MyAreaClicked(); };
        }

        public delegate void ClickDelegate(object sender);

        public ClickDelegate MyClick { get; set; }

        public void MyAreaClicked()
        {
            if(MyClick != null)
            {
                MyClick(this);
            }
        }

    }
}