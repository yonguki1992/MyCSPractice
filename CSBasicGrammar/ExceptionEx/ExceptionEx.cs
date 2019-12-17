using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEx
{
    class ExceptionEx
    {
        /*
         * (1) throw 문 다음에 catch에서 전달받은 Exception 객체를 쓰는 경우
         * -Stack Trace 정보를 다시 리셋하기 때문에 throw문 이전의 콜스택(Call Stack) 정보를 
         * 유실하게 된다. 따라서, 일반적으로 이러한 방식은 사용하지 않는 것이 좋다.
         * (2) throw 문 다음에 새 Exception 객체를 생성해서 전달하는 경우
         * - 
         * (3) throw 문 다음에 아무것도 없는 경우
         * -  throw; 는 에러가 다른 메서드에서 발생했을 때는 그 에러가 발생한 다른 메서드의 위치를 
         * 포함하지만, 만약 throw문과 동일한 메서드에서 에러가 발생했다면 
         * 동일 메서드의 어느 라인에서 에러가 발생했는지는 포함하지 않는다.
         */
        static void Main(string[] args)
        {
            ConsoleKeyInfo sw = Console.ReadKey();
            
            try
            {
                // 실행 문장들
                switch (sw.Key)
                {
                    case ConsoleKey.D1 :
                        Step1();
                        break;
                    case ConsoleKey.D2 :
                        Step2();
                        break;
                    case ConsoleKey.D3 :
                        Step3();
                        break;
                }
                
            }
            catch(IndexOutOfRangeException ex)
            {
                Log(ex);
                throw new Exception("Invalid index", ex);
            }
            catch (FileNotFoundException ex)
            {
                Log(ex);
                bool success = ex.StackTrace.Trim().Length > 0;
                if (!success)
                {
                    // 기존 Exception을 throw
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Log(ex);
                // 발생된 Exception을 그대로 호출자에 전달
                throw;
            }
        }

        private static void Log(Exception ex)
        {
            Console.WriteLine("\nMessage ---\n{0}", ex.Message);
            Console.WriteLine(
                "\nHelpLink ---\n{0}", ex.HelpLink);
            Console.WriteLine("\nSource ---\n{0}", ex.Source);
            Console.WriteLine(
                "\nStackTrace ---\n{0}", ex.StackTrace);
            Console.WriteLine(
                "\nTargetSite ---\n{0}", ex.TargetSite);
        }

        public static void Step1()
        {
            Console.WriteLine("나는 스텝1");
            throw new IndexOutOfRangeException();
        }

        public static void Step2()
        {
            Console.WriteLine("나는 스텝2");
            throw new FileNotFoundException();
        }
        public static void Step3()
        {
            Console.WriteLine("나는 스텝3");
            throw new Exception();
        }
    }
}
