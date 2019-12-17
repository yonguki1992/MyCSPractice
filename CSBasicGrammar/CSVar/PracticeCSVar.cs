using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVar
{
    class CSVar
    {
        //필드 (클래스 내에서 공통으로 사용되는 전역 변수)
        int globalVar;
        //상수 : 컴파일 시 값이 결정 되며 불변
        const int MAX_VALUE = 1024;
        // readonly 필드 :: (개념적으로 상수와 비슷) 필드 선언부나 클래스 생성자에서 값을 지정할 수 있음
        readonly int Max;

        public CSVar()
        {
            Max = 10;
        }

        public void Method1()
        {
            int localVar;

            localVar = 100;

            Console.WriteLine("globalVar : "+ globalVar);
            Console.WriteLine("localVar : "+localVar);
            Console.WriteLine("MAX_VALUE : "+MAX_VALUE);
            Console.WriteLine("Max : "+Max);

            //읽기 전용 필드에는 할당할 수 없습니다. 단 생성자 또는 변수 이니셜라이저에서는 예외입니다.
            //Max = 1; 

            //Console.WriteLine("Max : " + Max);
        }
    }

    class PracticeCSVar
    {
        static void Main(string[] args)
        {
            //테스트
            CSVar cSVar = new CSVar();
            cSVar.Method1();
        }
    }
}
