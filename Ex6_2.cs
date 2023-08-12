using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_EX
{
    class Ex6_2
    {
        public static void Mean(double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        public static void Main()
        {
            Mean(1, 2, 3, 4, 5, out double mean);
            Console.WriteLine("평균:{0}", mean);
        }
    }
}

/* 풀이
참조에 의한 매개변수 전달을 사용하여 매개변수 mean이 Main 메소드에서 선언한 double형 변수 mean을 참조하도록 했다.
이렇게 하면 매개변수 mean과 은 Main 함수의 mean을 가리키며 사실상 같은 공간을 가진 셈이 된다.
따라서 Mean 메소드 내에서 매개변수 mean에 값을 할당해주면 mean이 참조 중인 Main 메소드의 mean의 값 또한 해당 값을 가지게된다.

또한 해당 코드는 메소드 내에서 생성된 값을 필요로 하므로 ref키워드가 아닌 out 키워드를 사용하였다.
 */
