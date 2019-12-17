using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx04
{
    class Program
    {
        private static MyArea area;

        static void Main(string[] args)
        {
            area = new MyArea();
            //이벤트 가입 
            //추가한 순서에 따라 시작하는것 같음
            area.MyClick += Area_Click;
            area.MyClick += After_Click;

            //이벤트 탈퇴
            //area.MyClick -= Area_Click;

            // Error : 이벤트 직접호출 불가
            //area.MyClick(this)
            area.ShowDialog();
        }

        private static void After_Click(object sender)
        {
            area.Text += " After 클릭! ";
        }

        private static void Area_Click(object sender)
        {
            area.Text += " MyArea 클릭! ";
        }
    }
}
