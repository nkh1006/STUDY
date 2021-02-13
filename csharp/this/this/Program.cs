using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @this
{
    /*
     * this 키워드는 해당 클래스와 해당클래스로 인스턴스화된 객체를 가르키게 된다.
     * 우리가 특정한 메서드를 호출하게되면 보이지는 않지만 해당 객체까지 같이 넘겨주게 된다.
     * 하지만 this는 생략이 가능하다.
     * 또한 정적메서드 static일 경우는 this 키워드를 사용 할 수 없다.
     * static 메서드 자체가 해당 클래스내에서 공통으로 사용하는 메서드이기 때문이다.
     */

    public class Sample
    {
        string name;
        int age;
        int count;

        public Sample(string _name, int _age, int _count)
        {
            this.name = _name;
            age = _age;
            count = _count;
        }

        public void Hello()
        {
            // Console.WriteLine($"Hello My Name is {this.name}");
            Console.WriteLine($"Hello My Name is {name}");
        }

        public static void agePrint()
        {
            Console.WriteLine($"And Age is {age}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample sample1 = new Sample("test1", 1, 2);
            Sample sample2 = new Sample("test2", 2, 4);

            // 각각 실행시에 자신의 맴버객체를 던져주지만
            sample1.Hello();
            sample2.Hello();

            // agePrint 메서드의 경우 정적이기 때문에 실행할수없다 누구의 age인지 모르기 때문
        }
    }
}
