using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx03
{
    class Program
    {
        static MyArea area;
        static void Main(string[] args)
        {
            area = new MyArea();
            // 딜리게이트
            area.MyClick = Area_Click;
            area.ShowDialog();
        }

        private static void Area_Click(object sender)
        {
            area.Text = "번번히 눌렀죠?";
        }
    }
}
