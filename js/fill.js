const numbers1 = [1, 2, 3, 4, 5];
const numbers2 = [1, 2, 3, 4, 5];

numbers1.fill(0);
numbers2.fill(0, 1, 3);

// [0, 0, 0, 0, 0]
console.log(numbers1);
// [1, 0, 0, 4, 5]
console.log(numbers2);


// 1. Array(n) lenght의 배열을 생성
// 2. 해당 배열을 일단 0으로 채움
// 3. map methods를 통해서 각각의 배열마다 index + 1의 값을 넣어줌

const fillInNumber = (n) => {
   return Array(n).fill(0).map((_, idx) => idx + 1);
}

// [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
console.log(fillInNumber(10));