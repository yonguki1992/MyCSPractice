using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용하려는 namespace가 같은 프로젝트에 있다면 using {namespace}
using NamespaceEx.subNameSpace;
// 사용하려는 namespace가 다른 프로젝트에 있다면 사용하려는 프로젝트를 참조에 추가할 것
using EnumType;

// namespace(C#) ~~ package(java)
// java 패키지처럼 dir 구조는 아님
namespace NamespaceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 다른 프로젝트의 클래스는 public만 사용할 수 있음
            TestVO vo = new TestVO(1,"김용욱",28,true);
            Console.WriteLine(vo.ToString());

            //
            NamespaceEx2 ex2 = new NamespaceEx2();
            int result = ex2.Calculate(100, 200);
            Console.WriteLine(result);

        }
    }
}
