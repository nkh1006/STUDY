using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic02
{
    /*
     * Generic Type은 특정 클래스나 함수에서 여러가지 데이터타입을 인자값으로 받거나 리턴해줄때 사용한다.
     */

    public class GenericSample<T>
    {

    }

    public static class Sample
    {
        public static void Print(int _Value)
        {
            Console.WriteLine(_Value);
        }

        public static void Print(string _Value)
        {
            Console.WriteLine(_Value);
        }

        public static void Print(float _Value)
        {
            Console.WriteLine(_Value);
        }
    }

    public static class GenericSample
    {
        public static void Print<T>(T _Value)
        {
            Console.WriteLine(_Value);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // int는 사용가능
            Sample.Print(1);

            // double 형태시에 오류가 발생한다.
            // double형을 사용하기 위해서는 Sample class에 overloading 해주어야한다.
            Sample.Print(1.123);


            // 하지만 Generic 타입으로 선언한 함수의 경우 데이터타입을 자유롭게 넣어줄수있다.
            GenericSample.Print(1);
            GenericSample.Print(1.123);
            GenericSample.Print("test");
            GenericSample.Print(1.2345f);
        }
    }
}
