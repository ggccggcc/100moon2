using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex004
    {
        public void Run()
        {
            const int zero = 0;

            if (zero == 0)
            {
                Console.WriteLine("첫번째 if문");
                Console.WriteLine("zero는 0이기에 출력");
            }
            if(zero != 0)
            {
                Console.WriteLine("첫번째 else문");
                Console.WriteLine("조건절에 해당하기에 출력에서 제외");
            }

            if (zero == 1)
            {
                Console.WriteLine("두번째 if문");
                Console.WriteLine("zero는 1이 아니기에 출력에서 제외");
            }
            if (zero != 1)
            {
                Console.WriteLine("두번째 else");
                Console.WriteLine("조건절에 해당하지 않기에 출력");
            }

        }
    }
}
