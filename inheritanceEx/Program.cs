using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doge1 = new Dog();           
            Animal doge2 = new Dog();           
            doge1.Name = doge2.Name = "멍뭉이";
            doge1.Age = doge2.Age = 4;

            Bird bird1 = new Bird();
            Animal bird2 = new Bird();
            bird1.Name = bird2.Name = "Eagle";
            bird1.Age = bird2.Age = 3;

            doge1.HowOld();
            // as 연산자 : 형변환이 보장 됨. ref 타입만 됨, value 타입은 불가 ex) i as int;(x)
            (doge2 as Dog).HowOld();
            // 강제 형변환 : 가급적 피할것
            //((Dog)doge2).HowOld();

            bird1.Fly();
            // as 연산자 : 형변환이 보장 됨.
            (bird2 as Bird).Fly();
            // 강제 형변환
            //((Bird)bird2).Fly();
            if(bird1 is Animal)
            {
                Console.WriteLine("bird1는 동물");
            }
            if (bird2 is Animal)
            {
                Console.WriteLine("bird2는 동물");
            }
            if (bird1 is Bird)
            {
                Console.WriteLine("bird1는 조류");
            }
            if (bird2 is Bird)
            {
                Console.WriteLine("bird2는 조류");
            }

            if (!(bird2 is Dog))
            {
                Console.WriteLine("bird2는 개가 아님");
            }

            DerivedA dA = new DerivedA();

            Console.WriteLine(dA.GetFirst());
            Console.WriteLine(dA.GetNext());

            MyDerived myD = new MyDerived();
            myD.Run();

        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Dog : Animal
    {
        public void HowOld()
        {
            // 베이스 클래스의 Age 속성 사용
            Console.WriteLine("나이 {0:00}", this.Age);
        }
    }

    public class Bird : Animal
    {
        public void Fly()
        {

            Console.WriteLine("C#을 시작했으면 {0}부터 봐라", this.Name);
        }
    }

}
