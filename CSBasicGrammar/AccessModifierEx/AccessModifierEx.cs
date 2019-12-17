using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierEx
{
    class AccessModifierEx
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Name = "김용욱";

            Console.WriteLine(myClass.Name);

            Test t = new Test();
            t.MyMethod();
        }
    }

    // 1. 접근제한자는 public > internal > protected > protected internal > private 
    // 2. java의       public > (default) > protected > private 와 비슷함
    // 3. internal ~~ (default) 임 
    //   아무것도 안썼을 때 클래스와 필드의 적용 범위가 상이함.(명시적으로 선언하는 습관을 들이자)
    // 4. protected internal 은 동일 어셈블리(1개 프로젝트라고 생각하면 편함) 내에선 protected 
    //    다른 어셈블리에서는 private 와 같은 수준의 접근성을 가짐

    // 4. class 앞에 접근제한자 생략하면 기본으로 internal임
    internal class MyClass
    {
        // 6. 필드 앞에 접근제한자 생략하면 기본적으로 private임
        private int _id = 0;

        public string Name { get; set; }

        public void Run(int id) { }

        protected void Execute() { }
    }
}
