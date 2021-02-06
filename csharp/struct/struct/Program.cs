using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    /*
     * Struct는 구조체로 몇가지 특징을 가지고있다. 먼저 리터널 초기화가 되지않는다.
     * 따라서 Struct값에 값을 Set하기 위해서는 Struct내의 필드에 public 속성을 주던지
     * 아니면 Set메서드를 만들어서 값을 넣어줄수있다.
     * 구조체는 예전에 c언어와의 호환때문에 사용하는 문법이라고 한다.
     * 하지만 추가적으로 간단한 데이터타입을 모아놓은 객체를 만들때도 사용한다.
     */

    public struct Sample
    {
        // int date1 = 10;
        public int data1;

        // get
        public int getData()
        {
            return data1;
        }

        // set
        public void setDate(int value)
        {
            this.data1 = value;
        }
    }

    /*
     * 구조화된 객체 생성
     */

    public struct Sample2
    {
        // 마찬가지로 초기화를 할수없다.
        public int a;
        public int b;
        public int c;

        // 생성자는 가능
        public Sample2(int _a, int _b, int _c)
        {
            this.a = _a;
            this.b = _b;
            this.c = _c;
        }
    }

    public class Test
    {
        // 파라미터값으로 struct 객체를 받는다.
        public void print(Sample2 sample2)
        {
            Console.WriteLine($"a = {sample2.a}, b = {sample2.b}, c = {sample2.c}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // class와는 다르게 메모리에 할당하지 않아도 사용가능
            // 값 타입
            Sample sample;
            sample.data1 = 10;
            // Console.WriteLine(sample.data1);

            // 하지만 생성자로도 사용 가능
            Sample2 sample2 = new Sample2(10,20,30);
            // sample2.a = 10;
            // sample2.b = 20;
            // sample2.c = 30;

            Test test = new Test();
            test.print(sample2);
        }
    }
}
