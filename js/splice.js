/* splice 매서드는 배열을 삭제 하거나 추가할때 사용한다. */
// slice와 비슷할수있지만 차이가 있다.

const numbers1 = [1, 2, 3, 4, 5];
const deleted1 = numbers1.splice(2); // 앞에서 2개의 배열값을 삭제
console.log(deleted1);
// [3, 4, 5];


const numbers2 = [1, 2, 3, 4, 5];
const deleted2 = numbers2.splice(1, 3); // 1번째 index값에서 3개를 출력 즉 0번쨰와 4번째 이후는 삭제
console.log(deleted2);
// [2, 3, 4];

const numbers3 = [1, 2, 3, 4, 5];
const plused = numbers3.splice(0, 3, 5, 9); 
// number3에는 0번째 index부터 3번쨰 index까지 삭제시킨 이후에 5, 9라는 값을 넣어줌
// 하지만 plused에는 기존과 마찬가지로 0번째 index부터 3번째 index까지 삭제시킴
console.log(numbers3); // [5, 9, 4 ,5];
console.log(plused); // [1, 2, 3];
