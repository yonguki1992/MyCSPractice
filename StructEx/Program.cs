using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEx
{
    struct Point
    {
        public int X;
        public int Y;
        public int Z;

        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public override string ToString()
        {
            return $"{{{nameof(X)}={X}, {nameof(Y)}={Y}, {nameof(Z)}={Z}}}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             *C# 구조체랑 클래스 차이
            구조체 : 상속못받음, 인터페이스 구현 가능, 스택 영역에 할당
            클래스 : 다 됨, 힙 영역에 할당
            
            클래스 쓰기엔 오버헤드가 많은 경우 구조체 씀(대부분은 클래스임)
            */
            Point p1 = new Point(1,2,3);

            Console.WriteLine(p1.ToString());

            Point2 p2 = new Point2(1,2,3);

            Console.WriteLine(p2.ToString());
        }
    }


    class Point2
    {
        public int X;
        public int Y;
        public int Z;

        public Point2(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point2 operator +(Point2 p1, Point2 p2)
        {
            return new Point2(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public override string ToString()
        {
            return $"{{{nameof(X)}={X}, {nameof(Y)}={Y}, {nameof(Z)}={Z}}}";
        }
    }
}
