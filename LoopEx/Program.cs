using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;
            int sw = Convert.ToInt32(Console.ReadLine());
            switch(sw)
            {
                case 1 :
                    do
                    {
                        key = Console.ReadKey();
                        keyList.Add(key.KeyChar);
                        if(key.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                        }
                    } while (key.Key != ConsoleKey.Q);

                    Console.WriteLine();

                    foreach(char ch in keyList)
                    {
                        Console.WriteLine(ch);
                    }
                    break;
                case 2 :
                    foreach(int i in GetNumber())
                    {
                        Console.WriteLine(i);
                    }
                    break;
            }

        }
        static IEnumerable<int> GetNumber()
        {
            yield return 10;  // 첫번째 루프에서 리턴되는 값
            yield return 20;  // 두번째 루프에서 리턴되는 값
            yield return 30;  // 세번째 루프에서 리턴되는 값
        }

    }
}
