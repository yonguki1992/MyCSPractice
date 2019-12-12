using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class DatatypeEx01
    {
        static void Main(string[] args)
        {
            // 코멘트 : 한 라인 코멘트는 두개의 슬래시 사용함
            // cs 은 *.h 같은 별도의 헤더 파일이 없다.
            int a1 = 1;

            int a2 = 1;  // 코멘트 : 하나의 문장 뒤에 코멘트를 달 수 있음

            /*
             * 복수 라인에 대한 코멘트
             * int a1;
             * int a2;
             */

            //bool
            bool b = true;

            //numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;
            float f = 123.45F;
            double d1 = 123.45;
            double d2 = 123.45D;
            decimal d = 123.45M;

            // Char / String
            char c = 'A';
            string s = "hello";

            // DateTime 2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 13, 35, 0);

            Console.WriteLine("bool "+b);
            Console.WriteLine("short "+sh);
            Console.WriteLine("int " + i);
            Console.WriteLine("long " + l);
            Console.WriteLine("float " + f);
            Console.WriteLine("double1 " + d1);
            Console.WriteLine("double2 " + d2);
            Console.WriteLine("decimal " + d);

            Console.WriteLine("char " + c);
            Console.WriteLine("string " + s);

            Console.WriteLine("date " + dt);

            Console.WriteLine("int.max " + int.MaxValue);
            Console.WriteLine("float.max " + float.MaxValue);

            // Nullable 타입
            int? nullable_i = null;
            nullable_i = 101;

            bool? nullable_b = null;

            //한가지 예를 들면, 데이타베이스에 NULL이 허용된 INT 컬럼이 있을 때 C#에서 int? 로 매핑할 수 있습니다.
            //int? 를 int로 할당
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
        }


    }
}
