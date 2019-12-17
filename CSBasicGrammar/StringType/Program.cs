using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            new StringType1().Method1(); 
            new StringType2().Method2(); 
        }
    }

    class StringType1
    {
        public void Method1()
        {

            //문자열 변수
            string s1 = "c#";
            string s2 = "Programing";

            //문자 변수
            char c1 = 'A';
            char c2 = 'B';

            // 문자열 결합
            string s3 = s1 + " " + s2;
            Console.WriteLine("String : {0}", s3);

            // 부분 문자열
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("String : {0}", s3substring);

            // 문자열을 배열 인덱스로 한문자 엑세스
            for (int i = 0; i < s3.Length; ++i)
            {
                Console.WriteLine("{0} : {1}", i, s3[i]);
            }

            //문자열을 문자배열로 변환
            string str = "Hello World";
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; ++i)
            {
                Console.WriteLine(charArray[i]);
            }

            //문자배열을 문자열로 변환
            char[] charArray2 = { 'A', 'B', 'C', 'D', 'E' };
            s3 = new string(charArray2);

            Console.WriteLine(s3);
            int num = 10;
            Console.WriteLine(string.Format("{0} {1} {2} {3:000}", str, str, str, num));
        }
    }

    class StringType2
    {
        public void Method2()
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= 26; ++i)
            {
                sb.Append(i.ToString())
                  .Append(System.Environment.NewLine);

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
