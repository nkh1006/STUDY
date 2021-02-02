using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    /// <summary>
    /// 정적 생성자(static constructor)는 기본 생성자에 static 예약어를 붙인 경우로 클래스에
    /// 단 한개만 존재할 수 있고, 주로 정적 맴버를 초기화하는 기능을 한다.
    /// </summary>
    
    class Sample
    {
        static Sample()
        {
            Console.WriteLine("static constructor 생성");
        }
    }

    class Person
    {
        public string name;

        public Person(string _name)
        {
            Console.WriteLine("constructor 생성");
            this.name = _name;
        }

        static Person()
        {
            Console.WriteLine("static constructor 생성");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("sample1");
            Console.WriteLine("--------------");
            Person person2 = new Person("sample2");
        }
    }
}
