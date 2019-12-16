using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEx
{
    class Class1
    {
        public void Run()
        {

            dynamic t = new { Name = "한사람", Age = 25 };

            var c = new Class2();

            c.Run(t);
        }
    }

    class Class2
    {
        public void Run(dynamic t)
        {
            //dynamic 속성의 직접사용
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Age);
        }
    }
}
