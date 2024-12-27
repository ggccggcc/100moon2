using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Examples
{
    public class Ex010
    {
        public void Run()
        {
            Console.WriteLine("최근 본 영화 제목을 입력하세요");
            string movieTitle = Console.ReadLine();
            Console.WriteLine("{0}의 관람 평점을 입력하세요(1~5점 사이)", movieTitle);
            int rating = Convert.ToInt32(Console.ReadLine());

            switch (rating)
            {
                case 1:
                    Console.WriteLine("{0} 영화는 환불을 받고 싶을 정도로 최악의 영화군요", movieTitle);
                    break;

                case 2:
                    Console.WriteLine("{0} 영화는 지루한 영화군요", movieTitle);
                    break;
        
                case 3:
                    Console.WriteLine("{0} 영화는 시간 때우기 그 이상 그 이하도 아니군요", movieTitle);
                    break;

                case 4:
                    Console.WriteLine("{0} 영화는 흥미 유발", movieTitle);
                    break;

                case 5:
                    Console.WriteLine("{0} 영화는 최고군요", movieTitle);
                    break;

                default:
                    Console.WriteLine("평점 계산에 실패했습니다");
                    break;



            }
        }
    }
}
