// '2+2'
console.log('2+2');

// 4
console.log(eval('2+2'));

// 'alert(1)'
console.log('alert(1)');

// 실제로 alert창이 출력됨
console.log(eval('alert(1)'));

// scope
function x() {
   eval('var y = 10');
   // 10
   console.log(y);
}

x();

// undefind
console.log(y);