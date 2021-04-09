const numbers = [1, [2, [3, [4]]]];

const result = numbers.flat();
const result2 = numbers.flat(3);

// [1, 2, [3, [4]]]
console.log(result);

// [1, 2, 3, 4]
console.log(result2);