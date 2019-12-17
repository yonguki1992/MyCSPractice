using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierEx
{
    class Test
    {
        public void MyMethod()
        {
            MyClass myClass = new MyClass();
            myClass.Name = "김용욱";

            Console.WriteLine(myClass.Name);
        }
    }
}
