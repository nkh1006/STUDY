/*

factories와 마찬기지로 constructor를 이용해서도 객체생성을 편하게 할수있다.
아래와 같이 함수를 선언해주는데 factories와는 다르게 첫번째 글자를 대문자로 표현하여 주었다.
타언어의 클래스와 동일하게 또한 constructor은 생성자이기 때문에 this 키워드를 사용해서 해당 object를 지시해준다.
그리고 가장 중요한 것이 new 키워드를 사용하여 생성해주어야 한다.
그렇지 않으면 해당 함수내에 this키워드는 해당 함수를 가르키는것이 아닌 window객체를 가르키게 된다.

*/

function Circle(_radius) {
   console.log(this);
   this.radius = _radius;
   this.draw = function() {
      console.log("draw !");
   }
}

const circle1 = new Circle(1);
const circle2 = new Circle(2);
const circle3 = new Circle(3);