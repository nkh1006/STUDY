using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    /*
     * override는 자식클래스에서 부모클래스에서 받은 메서드를 재정의해서 사용할때 사용한다.
     * override를 해주는 부모클래스에서는 각각 virtual과 abstract 이 두가지로 나누어지는데
     * 기본적으로 부모클래스의 역할이 있고 자식에서 재정의해서 사용 할 경우는 virtual을 사용한다.
     */

    class baseClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int BirthDay { get; set; }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public virtual void Send()
        {
            Console.WriteLine("Send ...");
        }
    }

    class childClass : baseClass
    {
        public string Hobby { get; set; }
        public int Height { get; set; }

        public override void Send()
        {
            Console.WriteLine("Send 2 ...");
        }
    }

    class childClass2 : baseClass
    {
        public int Weight { get; set; }

        public override void Send()
        {
            Console.WriteLine("Send 3 ...");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new baseClass();
            var obj2 = new childClass();
            var obj3 = new childClass2();

            obj1.Send();
            obj2.Send();
            obj3.Send();
        }
    }
}
