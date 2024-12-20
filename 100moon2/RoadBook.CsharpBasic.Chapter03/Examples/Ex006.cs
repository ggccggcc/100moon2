using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex006
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("{0}은 양수", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("{0}은 음수", number);
            }
            else
            {
                Console.WriteLine("{0}은 zero", number);
            }

            if(number % 2 == 0)
            {
                Console.WriteLine("{0}은 짝수", number);
            }
            else
            {
                Console.WriteLine("{0}은 홀수", number);
            }
        }
    }
}
