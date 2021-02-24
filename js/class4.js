class Person {
   constructor (_name, _age) {
      this.name = _name;
      this.age = _age;
   }

   describe () {
      console.log(`I am ${this.name} age I am ${this.age} years old`);
   }
}

class Programmer extends Person {
   constructor (_name, _age, _yearsOfExperience) {
      super(_name, _age);

      this.yearsOfExperience = _yearsOfExperience;
   }

   code() {
      console.log(`coding ...`);
   }

}

let person1 = new Person('sample1', '19');
let person2 = new Programmer('sample2', '20');

person2.describe();
person2.code();
