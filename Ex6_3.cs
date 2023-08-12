using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_EX
{
    class Ex6_3
    {
        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        //메소드 오버로딩
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }

        public static void Main()
        {
            int a = 3;
            int b = 4;

            Plus(a, b, out int resultA);

            Console.WriteLine("{0}+{1}={2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;

            Plus(x, y, out double resultB);
            //매개 변수의 형식이 다르면or매개변수의 개수가 다르면 같은 이름의 메소드를 사용할 수 있음.

            Console.WriteLine("{0}+{1}={2}", x, y, resultB);
        }
    }
}
