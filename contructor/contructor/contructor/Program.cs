using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contructor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Constructors (생성자)는 클래스가 인스턴스화 될때 실행되는 메서드를 말한다.
             * Constructors를 정의 하는방법은 해당 클래스와 동일한 이름의 메서드를 생성 해주면 된다.
             * Constructors는 다양한 인자값을 받을수 있다. (받지 않는것도 가능)
             */


            // Customer 클래스의 인스턴스화와 동시에 인자값을 넣어주어 생성자 함수를 호출한다.
            // Customer의 생성자함수는 3가지의 인자값을 Overload 되어있다.
            var customer = new Customer(1, "Sample");

            // customer.Id = 1;
            // customer.Name = "Sample";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            // Order객체 생성
            var order = new Order();
            // customer.Orders = new List<Order>();

            // Customer가 생성될때 자동적으로 Order 객체를 초기화 해주도록 하였다.
            customer.Orders.Add(order);
        }
    }
}
