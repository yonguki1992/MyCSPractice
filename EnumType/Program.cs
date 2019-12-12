using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumType
{
    enum City
    {
        Seoul, //0
        Daejun, //1
        Busan = 5,
        Jeju = 10
    }

    // Flags : 비트 필드를 갖는다는 것을 표시
    // Flags 열거형은 각 비트별로 겹치는 부분이 있으면 안 됨.
    [Flags]
    enum Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }

    class Program
    {

        static void Main(string[] args)
        {
            new EnumEx().Method1();
            new EnumEx().Method2();

            TestVO vo = new TestVO(1,"",2,false);
            //vo.No = 1;
            vo.Name = "김용욱";
            vo.Age = 28;
            vo.Gender = true;

            Console.WriteLine(vo.ToString());
        }


        class EnumEx
        {
            public void Method1()
            {
                City myCity;

                // enum 에 값을 대입
                myCity = City.Seoul;

                //enum을 int로 변환
                int cityVal = (int)myCity;

                if(myCity == City.Seoul)
                {
                    Console.WriteLine("서울에 오신것을 환영합니다.");
                }
            }

            public void Method2()
            {
                Console.WriteLine((int)Border.None + ", " + (int)Border.Top + ", " + (int)Border.Right + ", " + (int)Border.Bottom + ", " + (int)Border.Left);

                // OR 연산자로 다중 플래그 할당
                Border b = Border.Top | Border.Bottom;

                if(b.HasFlag(Border.Bottom))
                {
                    //[Flags] 가 없으면 5가 출력
                    //[Flags] 가 있으면 top, bottom 출력
                    Console.WriteLine(b.ToString());
                }
                
            }
        }
    }
}
