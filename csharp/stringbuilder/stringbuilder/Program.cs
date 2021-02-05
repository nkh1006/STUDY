using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * StringBuilder와 String의 가장큰 차이는 String은 값타입이고 StringBuilder는 참조 타입이다.
             * 따라서 String의 경우 추가적인 작업이 이루어 질때마다 메모리에 새로운 주소와 값이 생성되게 된다.
             * 이 말은 평균적인 작업에서는 큰 차이는 없겠지만 작업이 반복적으로 이루어지게되면 메모리의 누수가 일어나게된다.
             * StringBuilder의 경우는 class형태로 객체를 만든후에 메서드를 통해서 문자열 관리하기 때문에
             * 상황에 따라서 알맞은 형태로 사용하는것이 좋다.
             */

            // String

            string newString2 = "Sample string";
            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(newString2 + ' ' + i);
            }

            // StringBuilder

            StringBuilder newString = new StringBuilder();
           
            // Methods

            // Append text
            newString.Append('-', 6);
            newString.Append("Title !");
            newString.Append('-', 6);

            // Create new line
            newString.AppendLine();
            newString.Append("New Line !");

            // Remove
            newString.Remove(0, 6);

            // Replace
            newString.Replace("Title", "New Title");

            Console.WriteLine(newString);
        }
    }
}
