using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contructor2
{
    /*
     * :base라는 키워드는 상위 클래스의 데이터에 접근하는데 사용한다.
     */

    public class Vehicle
    {
        private readonly string value;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }

        public Vehicle(string _value)
        {
            value = _value;
            Console.WriteLine("Vehicle is being initialized. {0}", _value);
        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized");
        }

        public Car(string _value) : base(_value)
        {
            Console.WriteLine("Car is being initialized . {0}", _value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("test");
        }
    }
}
