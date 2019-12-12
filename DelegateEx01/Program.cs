using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx01
{
    class Program
    {
        //1. delegate 선언
        private delegate void RunDelegate(int i);

        private void RunThis(int val)
        {
            Console.WriteLine("이건 {0,3}", val);
        }

        private void RunThat(int value)
        {
            //{0:X} => 16진수로 변환하여 출력해라
            Console.WriteLine("저건 0x{0:X}", value);
        }

        public void Perform()
        {
            //2. delegate 인스턴스 생성
            RunDelegate run = new RunDelegate(RunThis);
            //3. delegate 실행
            run(320);

            //run = new RunDelegate(RunThat); 을 줄이면 아래와 같이 됨
            run = RunThat;
            run(1024);
        }

        static void Main(string[] args)
        {
            new Program().Perform();
        }
    }
}
