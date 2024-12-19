using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex001
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
            {
                Console.WriteLine("첫번째 if문입니다.");

                if (zero == 0)
                {
                    Console.WriteLine("두번째 if문입니다.");
                    Console.WriteLine("zero가 0이기에 출력합니다.");
                }

                if (zero == 1)
                    Console.WriteLine("세번째 if문입니다.");
                    Console.WriteLine("zero는 1이 아니라 출력에서 제외합니다.");
            }

        }
    }
}
