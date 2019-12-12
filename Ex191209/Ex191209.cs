using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex191209
{



    class Ex191209
    {
        static void Main(string[] args)
        {
            Console.WriteLine("H-index : "+new Solution191209().solution(new int[] { 6, 0, 1, 5, 3 } ));
        }
    }

    public class Solution191209
    {
        public int solution(int[] citations)
        {
            /*
             어떤 연구자의 h 지수는 그 사람이 쓴 모든 논문 중 n회 이상 인용된 논문이 n개 이상일 때,
             이 둘을 동시에 만족하는 n의 최대값으로 한다.
             어떤 과학자가 발표한 논문 n편 중, 
             h번 이상 인용된 논문이 h편 이상이고 나머지 논문이 h번 이하 인용되었다면
             h가 이 과학자의 H-Index입니다. 
            */
            int answer = 0;
            int len = citations.Length;   // 배열의 길이

            // 정렬함.
            Array.Sort(citations);
            //Array.ForEach(citations, new Action<int>(ShowSquares));
            //Console.WriteLine();
            //[0, 1, 3, 5, 6]
            for (int i = 0; i < citations.Length; ++i)
            {
                // len - i => citations[i] 보다 많이 인용된 논문수
                if (citations[i] >= (len - i))
                {
                    answer = len - i;
                    break;
                }
            }

            return answer;
        }
        
        private static void ShowSquares(int val)
        {
            Console.Write( val+", ");
        }
    }
}
