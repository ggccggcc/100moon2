using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex002
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
            {
                Console.WriteLine("첫번째 if문");

                if (zero == 0)
                {
                    Console.WriteLine("두번째 if문");
                    Console.WriteLine("zero는 0이라서 출력");
                }

                if (zero == 1)
                {
                    Console.WriteLine("세번째 if문");
                    Console.WriteLine("zero는 1이 아니라서 출력");
                }
            }
        }
    }
}
