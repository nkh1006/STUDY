// findIndex 매서드는 말그대로 해당 value의 index값을 찾아주는 매서드이다.

const numbers = [1, 2, 3, 4, 5];

const res = numbers.findIndex(findThree);

function findThree(value) {
   // index 2
   return value === 3;
   // index 3
   return value === 4;
}