using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex007
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("{0}은 양수", number);

                if(number %2 == 0)
                {
                    Console.WriteLine("{0}은 짝수", number);
                }
                else
                {
                    Console.WriteLine("{0}은 홀수", number);
                }
            }
            else if(number < 0) 
            {
                Console.WriteLine("{0}은 음수", number);

                if (number % 2 == 0)
                {
                    Console.WriteLine("{0}은 짝수", number);
                }
                else
                {
                    Console.WriteLine("{0}은 홀수", number);
                }
            }
            else
            {
                Console.WriteLine("{0}은 제로 입니다.", number);
                Console.WriteLine("{0}은 짝수입니다.", number);

            }
        }
    }
}
