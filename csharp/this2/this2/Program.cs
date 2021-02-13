using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this2
{
    // this의 두번째 기능은 생성자 여러개를 동시에 호출 하는 것이다.
    // 해당 생성자 뒤에 this 키워드를 적어주고 인자값을 던져주면 된다.
    // 이 경우는 생성자 뒤에 있는 파라미터로 호출한 생성자 부터 실행된다.
    // #3 > #2 > #1
    
    public class Sample
    {
        public string name;
        public int age;

        public Sample() : this("name")
        {
            Console.WriteLine("Contructor #1");
        }

        public Sample(string _name) : this("name", 1)
        {
            Console.WriteLine("Contructor #2");
            this.name = _name;
        }

        public Sample(string _name, int _age)
        {
            Console.WriteLine("Contructor #3");
            this.name = _name;
            this.age = _age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            Console.WriteLine(sample.name);
            Console.WriteLine(sample.age);
        }
    }
}
