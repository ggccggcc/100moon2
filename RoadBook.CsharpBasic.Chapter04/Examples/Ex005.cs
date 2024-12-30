using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex005
    {
        public void Run()
        {
            int fact_result = 1;

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("{0} * {1} = ", fact_result, i);

                fact_result = fact_result * i;

                Console.WriteLine("{0}", fact_result);

            }

            Console.WriteLine("5!는 {0}입니다", fact_result);
        }
    }
}
