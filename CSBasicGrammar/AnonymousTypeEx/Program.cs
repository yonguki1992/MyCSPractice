using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().RunTest();

        }
        private void RunTest()
        {
            var v = new[]
            {
                //익명타입
                new {Name="한사람",Age=27,Phone="010-0101-0101"},
                new {Name="두사람",Age=28,Phone="010-1234-4321"},
                new {Name="세사람",Age=29,Phone="010-1234-5678"},
                new {Name="네사람",Age=30,Phone="010-0101-0000"}
            };

            //LINQ Select 를 이용해 Name 과 Age 만 갖는 새 익명타입 객체들을 리턴
            var list = v.Select(p => new { Name = p.Name, Age = p.Age })
                        .Where(p => p.Age >= 28);

            foreach(var people in list)
            {
                Console.WriteLine("{0}({1}세, 백수)",people.Name,people.Age);
            }
        }
    }
}
