using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx02
{
    public class MySort
    {
        public delegate int CompareDelegate(int i1, int i2);

        public static void Sort(int[] array, CompareDelegate comp)
        {
            if (array.Length < 2) return;
            Console.WriteLine("함수 Prototype: {0}",comp.Method);
            //int[] array = { 5, 53, 3, 7, 1 };
            int ret = 0;
            for(int i = 0; i < array.Length - 1; ++i)
            {
                for(int j = i+1; j < array.Length; ++j)
                {
                    // 둘의 대소 관계 비교
                    ret = comp(array[i], array[j]);
                    if(ret == -1)
                    {
                        array[i] ^= array[j];
                        array[j] ^= array[i];
                        array[i] ^= array[j];
                    }
                }
            }

            // new Action 도 딜리게이트임
            Array.ForEach(array, new Action<int>(Display));
            Console.WriteLine();
            // 따라서 이것도 됨.
            //Array.ForEach(array, Display);

        }

        private static void Display(int val)
        {
            Console.Write("{0,3}", val);
        }
    }
}
