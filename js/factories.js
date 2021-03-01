/*

새로운 circle이 늘어날수록 새로운 object를 만들어주어야하는 불편함이 있다.
이때 factories를 활용하여 해당 object를 생성을 function 함수화 시킬수 있다.

const circle1 = {
   radius: 1,
   location: {
      x: 1,
      y: 1
   },
   draw: function() {
      console.log('draw !');
   }
}

const circle2 = {
   radius: 2,
   location: {
      x: 2,
      y: 2
   },
   draw: function() {
      console.log('draw !');
   }
}

const circle3 = {
   radius: 3,
   location: {
      x: 3,
      y: 3
   },
   draw: function() {
      console.log('draw !');
   }
}

*/


// 아래와 같이 circle를 만드는것을 함수화 시킨다음에 실행시켜주면 코드가 훨씬더 간결해진다.

function createCircle(_radius) {
   return {
      radius:  _radius,
      draw: function() {
         console.log('draw !');
      }
   }
}

const circle1 = createCircle(1);
const circle2 = createCircle(2);
const circle3 = createCircle(3);

