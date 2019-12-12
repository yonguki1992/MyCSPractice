using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IEmployee { }

    class Employee { }
    class MyBase { }

    // 일반 generic 클래스
    class MyClass1<T> { }
    
    /*
     * generic 타입 제약 조건 추가하기
     */
    // T가 structure일 것
    class MyClass2<T> where T : struct { }

    // T가 클래스일 것
    class MyClass3<T> where T : class { }

    // T가 기본생성자를 가져야 함
    class MyClass4<T> where T : new() { }

    // T가 MyBase 를 상속받았을것
    class MyClass5<T> where T : MyBase { }
    
    //T가 IComparable을 구현했을 것
    class MyClass6<T> where T : IComparable { }

    //좀더 복잡한 제약조건
    class EmployeeList<T> where T : Employee,
        IEmployee, IComparable, new()
    {
    }

    // 복수 타입 파라미터 제약
    class MyClass7<T, U>
        where T : class
        where U : struct
    {
    }


}
