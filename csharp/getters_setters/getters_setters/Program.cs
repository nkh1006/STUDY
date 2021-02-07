using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    /*
     * getter와 setter는 여러 프로그램 언어에서 사용하는 개념인데
     * 왜 사용하냐면 class의 확장성이 증가된다.
     * 물론 모든 필드에 public 키워드를 사용하되면 어디서든 사용할수 있기야 하겠지만
     * 그렇게되면 불필요하거나 예상하지 못한 값들이 생성되거나 출력될수 있다.
     * 그렇기에 get, set의 가장 큰 의미는 클래스 내부 필드들의 캡슐화 및 은닉성을 위해서 사용합니다.
     */

    public class Sample
    {
        public string name;
        private int age;
        // public string gender;
        private string gender;

        // constructor
        public Sample(string _name, int _age, string _gender)
        {
            this.name = _name;
            this.setAge(_age);
            this.setGender(_gender);
        }

        // get
        public int getAge()
        {
            return this.age;
        }

        // set
        public void setAge(int _age)
        {
            if (_age >= 1 && age <= 120)
            {
                this.age = _age;
            }
            else
            {
                this.age = 0;
            }
        }

        // get gender
        public string getGender()
        {
            return this.gender;
        }

        // set gender
        public void setGender(string _gender)
        {
            if (_gender == "male" || _gender == "female")
            {
                this.gender = _gender;
            }
            else
            {
                this.gender = "invalid value";
            }
        }
    }

    // c# 에서는 이런 getter와 setter를 아주 간단하게 생성할수있다.
    // 단축키는 prop + tab tab
    class Sample2
    {
        public int MyProperty { get; set; }
        public string MyProperty2 { get; set; }
        public bool MyProperty3 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // public으로 필드를 만들어두면 person 객체를 생성할때 gender에 예상하지 못한값이 들어갈수있다.
            // Sample person = new Sample("Kim", 15, "Dog");
            // Console.WriteLine(person.gender); // gender는 male 또는 female만 들어게 해야한다.

            // set를 통해서 정상적인 값이 아닌경우는 예외처리를 해줄수있을 뿐만아니라
            // 무분별하게 값을 가져오거나 생성하는것을 막아준다.
            Sample person2 = new Sample("Kim", 15, "Cat");
            Console.WriteLine(person2.getGender());
        }
    }
}
