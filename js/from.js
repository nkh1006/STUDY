// Array

const str = '1234567';
const result = Array.from(str, mapFunction);

function mapFunction(x) {
   return Number(x);
}

console.log(result);


const numbers = [1,2,3,4,5,6,7,8];
const newNumbers = Array.from(numbers, mapFuntion2);

function mapFuntion2(x) {
   return x * 2;
}

console.log(newNumbers);