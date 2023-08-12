using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_EX
{
    class Ex6_1
    {
        static double Square(double arg)
        {
            double square = arg * arg; //매개변수를 제곱하여 square 변수에 저장
            return square; //square 변수 반환
        }
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요: ");
            string input = Console.ReadLine(); //사용자로부터 입력받은 문자를 input에 저장

            double arg = Convert.ToDouble(input); //input의 값을 double형으로 형변환

            Console.WriteLine("결과: {0}", Square(arg));
        }
    }
}
