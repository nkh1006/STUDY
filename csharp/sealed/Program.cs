using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @sealed
{
    public class SealedClass
    {
        public string prop1 { get; set; }
        public int prop2 { get; set; }

        public void method1()
        {
            Console.WriteLine("Method1");
        }
    }

    /* error */

    public class Class1 : SealedClass
    {

    }

    public class Class2 : SealedClass
    {
        public string prop3 { get; set; }
        public int prop4 { get; set; }

        public sealed override void method2()
        {
            Console.WriteLine("Method2");
        }
    }

    public class Class3 : Class2
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
