using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 확장메서드는 이게 아니라
            //Console.WriteLine("ABC -> " + ExClass.ToChangeCase("ABC"));
            //Console.WriteLine(ExClass.Found("ABC", 'd')?"포함 됨":"포함 안 됨");

            // 이렇게 쓰는 것
            // s객체 즉 String객체가
            // 확장메서드의 첫 파리미터임
            // 실제 ToChangeCase() 메서드는
            // 파라미터를 갖지 않는다.
            string str = "ABC";
            Console.WriteLine(str+" -> " + str.ToChangeCase());
            Console.WriteLine(str.Found('d')?"포함 됨":"포함 안 됨");
        }
    }
}
