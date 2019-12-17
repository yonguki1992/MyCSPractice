using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceEx
{
    public class MyDerived : MyBase
    {
        public MyDerived()
        {
            Name = "김용욱";
            Age = 28;
        }

        public void Run()
        {
            Console.WriteLine("이름 :{0,5} , 나이 :{1,4:000}", this.Name, this.Age);
        }
    }
}
