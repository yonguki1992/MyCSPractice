using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerEx
{
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        // 내부의 정수 배열 데이타
        private int[] data = new int[MAX];

        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if(!(index < 0 || index >= MAX))
                {
                    // value 는 예약어임;
                    data[index] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass[0] = 1024;
            int i = myClass[0];

            Console.WriteLine(i);
        }
    }
}
