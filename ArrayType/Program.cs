using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayType
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] scores = { 80, 90, 60, 90, 100 };

            sum = CalculateSum(scores);
            Console.WriteLine(sum);
        }

        private static int CalculateSum( int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; ++i)
            {
                sum += scores[i];
            }

            return sum;
        }
    }
}
