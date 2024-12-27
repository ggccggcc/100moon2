using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex009
    {
        public void Run()
        {
            Console.WriteLine("최근 본 영화 제목을 입력하세요");
            string movieTitle = Console.ReadLine();
            Console.WriteLine("{0}의 관람 평점을 입력하세요(1~5점 사이)", movieTitle);
            int rating = Convert.ToInt32(Console.ReadLine());

            if (rating == 1)
            {
                Console.WriteLine("{0} 영화는 환불하고 싶을 정도로 최악이군요", movieTitle);
            }

            else if (rating == 2)
            {
                Console.WriteLine("{0} 영화는 지루하군요", movieTitle);
            }

            else if (rating == 3)
            {
                Console.WriteLine("{0} 영화는 시간 때우기 좋은 그 이상도 이하도 아니군요", movieTitle);
            }

            else if (rating == 4)
            {
                Console.WriteLine("{0} 영화는 흥미롭네요", movieTitle);
            }

            else if (rating == 5)
            {
                Console.WriteLine("{0} 영화는 최고네요", movieTitle);
            }

            else
            {
                Console.WriteLine("평점 계산에 실패했습니다");
            }
        }

    }
}
