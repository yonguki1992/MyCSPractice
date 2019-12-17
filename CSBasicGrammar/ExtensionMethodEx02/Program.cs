using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            // LINQ Where 확장 메서드 정수 리스트에 사용
            var v = nums.Where(p => p % 2 == 0);

            // IEnumerable<int> 결과에 ToList 확장 메서드를 사용, 정수리스트로 변환
            List<int> filteredNums = v.ToList<int>();
            
            filteredNums.ForEach(val => Console.WriteLine(val));
        }
    }
}
