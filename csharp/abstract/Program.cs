using System;

namespace @abstract
{
    /*
     *  abstract는 추상 클래스로써 자식클래스에서 override 할 때 사용되며 다음과 같은 특징이 있다.
     *  #1. abstract 매서드 선언시에는 body ({})부분이 없다.
     *  #2. abstract 매서드 선언시에는 클래스 앞에 abstract를 붙여주어서 해당 클래스가 추상 클래스임을 명시 해주어야한다.
     *  #3. abstract 매서드 선언시에는 자식클래스에 해당 abstract 매서드를 반드시 오버라이드 해주어야한다.
     *  #4. abstract 클래스는 인스턴스화 할 수 없다.
     */

    abstract class AstractClass
    {
        public string prop1 { get; set; }
        public int prop2 { get; set; }

        public void method1()
        {
            Console.WriteLine("Method !");
        }

        /* abstract method */

        public abstract void method2();
        public abstract void method3();
    }

    class Class2 : AstractClass
    {
        public string prop3 { get; set; }

        public override void method2()
        {
            Console.WriteLine("Method 2 !");
        }

        public override void method3()
        {
            Console.WriteLine("Method 3 !");
        }
    }

    class Class3 : AstractClass
    {
        public string prop4 { get; set; }

        public override void method2()
        {
            Console.WriteLine("Method 2-2 !");
        }

        public override void method3()
        {
            Console.WriteLine("Method 3-2 !");
        }
    }

    class Class4 : AstractClass
    {
        public string prop5 { get; set; }

        /* 
         * error 
         * AstractClass에 있는 method2, method3를 ovverride 해주어야한다.
         */

    }

    class Program
    {
        static void Main(string[] args)
        {
            /* abstract 클래스는 인스턴스화 할 수 없다. */
            var class1 = new Class1();
            var class2 = new Class2();

            class2.prop1 = "1";
            class2.method2();
        }
    }
}
