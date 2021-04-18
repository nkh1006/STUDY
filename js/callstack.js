// Global Execution Context

// 1. Creation Phase
// 이때 Hoisting 현상이 발생한다.
// 1-1. global object
// 1-2. this
// 1.3. scope chain

// 2. Execution Phase

function sayHi() {
   console.log(`hello there ${name}`);
   changeName();
   console.log(`sayHi is finished`);
}

function changeName() {
   name = "Bobby";
   console.log(`we chaged it to ${name}`);
   console.log(`changeName is finished`);
}

let name = "dev ed";

sayHi();

console.log(`We are done with the code`);