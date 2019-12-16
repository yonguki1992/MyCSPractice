using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. dynamic 형은 중간에 타입을 바꿀 수 있음
            dynamic v = 1;
            Console.WriteLine(v.GetType());

            v = "abc";
            Console.WriteLine(v.GetType());

            //2. dynamic은 캐스트가 불필요
            object o = 10;
            // 틀린표현
            // (에러: Operator '+' cannot be applied to operands of type 'object' and 'int')
            //o = o + 20;
            // 맞는 표현: object 타입은 casting이 필요하다
            o = (int)o + 20;

            // dynamic 타입은 casting이 필요없다.
            dynamic d = 10;
            d = d + 20;

            new Class1().Run();
        }
    }
}
