using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MyClass : IComparable
    {
        private int key;
        private int value;

        // IComparable 의 CompareTo 메서드 구현
        // 상속과 다르게 public overide int CompareTo() 가 아니다
        public int CompareTo(object obj)
        {
            MyClass target = obj as MyClass;
            return this.key.CompareTo(target.key);
        }
    }

}
