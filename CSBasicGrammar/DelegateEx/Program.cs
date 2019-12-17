using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    class Program
    {
        static void Main(string[] args)
        {

            new Program().Test();
        }

        //델리게이트 정의
        delegate int MyCustomDelegate(string str);

        private void Test()
        {
            MyCustomDelegate mcd = new MyCustomDelegate(StringToInt);

            // 델리게이트 객체를 메서드로 전달
            Run(mcd);
        }

        // 델리게이트의 대상
        private int StringToInt(string str)
        {
            return int.Parse(str);
        }

        // 델리게이트를 전달 받는 메서드
        private void Run(MyCustomDelegate mcd)
        {
            //델리게이트로부터 메서드 실행
            int number = mcd("369");

            Console.WriteLine("나는{0,5:0000}",number);
        }
    }

}
