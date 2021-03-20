using System;

namespace casting_1
{
    /*
     * upcasting이란 자식클래스의 형식에서 부모클래스의 형식으로 casting 바뀌는것을 말한다.
     * 즉 하나의 매개변수형 (상위)로 상속 받은 자식클래스의 매개변수형을 받아 오는것이다.
     */

    public class Sample
    {
    }

    public class Sample1 : Sample
    {
    }

    public class Sample2 : Sample
    {
    }

    public class Sample3 : Sample
    {
    }

    public class SamplePrint
    {
        /*
            자식클래스가 추가될때마다 매서드를 오버로딩 시켜주어야함

            public void Print(Sample1 sample)
            {
                Console.WriteLine("Print " + sample);
            }

            public void Print(Sample2 sample)
            {
                Console.WriteLine("Print " + sample);
            }

            public void Print(Sample3 sample)
            {
                Console.WriteLine("Print " + sample);
            }
        */

        // 부모클래스인 Sample로 자식클래스들을 받아줄수 있음

        public void Print(Sample sample)
        {
            Console.WriteLine("Print " + sample);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var sample1 = new Sample1();
            var sample2 = new Sample2();
            var sample3 = new Sample3();

            var sp = new SamplePrint();
            sp.Print(sample1);
            sp.Print(sample2);
            sp.Print(sample3);
        }
    }
}
