#define TEST_ENV
//#define PROD_ENV

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreprocessorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verbose = false;
            
            
            // 조건별로 컴파일 되지 않는 영역은 회색으로 표시됨.
#if (TEST_ENV)
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#else
            Console.WriteLine("Production");
#endif

            if (verbose)
            {
                Console.WriteLine("test 모드");
            }
        }
    }
}
