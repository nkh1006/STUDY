using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // 인스턴스 생성
            var dateTime = new DateTime(2021, 1, 1);

            Console.WriteLine(dateTime);

            // 오늘
            var now = DateTime.Now;

            Console.WriteLine($"Hour : {now.Hour}");
            Console.WriteLine($"Minute : {now.Minute}");

            // 내일
            var tomrrow = now.AddDays(1);

            // 어제
            var yesterday = now.AddDays(-1);

            // 여러가지 포맷으로도 가져올수있다.
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            // 날짜와 시간의 형태로 지정가능
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.WriteLine(now.ToString("HH:mm"));
        }
    }
}
