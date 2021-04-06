const numbers = [1, -1, 2, 3, 4, 10, 13];

let sum = 0;
for (let n of numbers) 
   sum += n;

console.log(sum); // 32

// 1, -1
// 0, 2
// 5 4
// 9 10
// 19 13

const result = numbers.reduce((acc, value) => {
   console.log(acc, value);
   return acc + value;
});

console.log(result); // 32