// 모든 배열은 base object에 속해있는 prototype의 매서드를 상속받는다.

let x = {};
let y = {};

console.log(x);
console.log(y);

console.log(Object.getPrototypeOf(x));

// true
console.log(Object.getPrototypeOf(x) === Object.getPrototypeOf(y));