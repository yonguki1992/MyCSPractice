using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();
        }

        public void Run()
        {
            int[] array = { 5, 53, 3, 7, 1 };

            //올림차순으로 Sort
            MySort.CompareDelegate compareDelegate = new MySort.CompareDelegate(AscendingCompare);
            MySort.Sort(array, compareDelegate);

            //내림차순으로 Sort
            MySort.Sort(array, DescendingCompare);
        }

        //public delegate int CompareDelegate(int i1, int i2); 구현

        // 오름 차순
        private int AscendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            int result = (i1 - i2 > 0) ? -1 : 1;
            return result;
        }

        // 내림 차순
        private int DescendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            int result = (i1 - i2 > 0) ? 1 : -1;
            return result;
        }
    }
}
