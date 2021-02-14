using access_modifier2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    /*
     * c#의 접근제한자는 크게 4가지로 구성되어있다.
     * public : 어디서든 접근 가능
     * private : 해당 클래스 내부에서만 접근 가능
     * internal : 같은 어셈블리 내에서만 접근 가능
     * protected : 파생 클래스 상속받은 클래스에서 접근 가능
     * 
     * class의 접근 제한자 기본값은 internal이며 
     * class내의 필드나 메서드의 접근 제한자 기본값은 private이다.
     */

    class Sample
    {
        int a;
        public int b;
        protected int c;

        public void Print()
        {
            Console.WriteLine("Hello");
        }

        void Print2()
        {
            Console.WriteLine("Hello2");
        }
    }

    class Sample2 : Sample
    {
        int d;

        void Print3()
        {
            Console.WriteLine("Hello3" + c);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.a = 1;
            sample.b = 2;
            sample.Print();
            sample.Print2();

            internal_test it = new internal_test();
            public_test pt = new public_test();
        }
    }
}
