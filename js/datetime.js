// Date 객체는 js스크립트에서 지원해주는 양식으로써 여러가지 활용방법이 있기 때문에
// 각각의 상황에 맞춰서 활용 하는 것이 좋다.

// Date 객체 생성
const newDate = new Date();

console.log(newDate); // Mon Feb 08 2021 21:50:05 GMT+0900 (대한민국 표준시)
console.log(newDate.getFullYear()); // 2021
// js는 0부터 시작한다 0 ~ 11 따라서 정확한 값을 계산하려면 + 1 을 해주어야한다.
console.log(newDate.getMonth() + 1); // 1 
console.log(newDate.getDate()); // 8
// 마찬가지로 0이 일요일 ~ 6까지 있다. 즉 1은 월요일
console.log(newDate.getDay()); // 1
console.log(newDate.getHours()); // 21
console.log(newDate.getMinutes()); // 50
console.log(newDate.getSeconds()); // 22

// 값을 만들어 낼수도있다.
const setDate = new Date("Jan 1, 2021 00:00:00 GMT+0900");
console.log(setDate); // Fri Jan 01 2021 00:00:00 GMT+0900 (대한민국 표준시)
console.log(setDate.getTime()); // 1609426800000 해당 시간을 ms로 반환 해준다.
console.log(newDate.getTime()); // 1612788893506
console.log(newDate.getTime() - setDate.getTime()); // 해당 시간까지의 남은 값을 ms로 반환 해준다.
let distanceTime = (newDate.getTime() - setDate.getTime()) / 1000;
console.log(Math.floor(distanceTime)); // 3362210 남은 초를 계산할수도있다. 현재는 지난 시간 ...

// 전월 구하기 
var nowDate = new Date();
var firstDayOfMonth = new Date(nowDate.getFullYear(), nowDate.getMonth(), 1 );
var lastMonthLastDay = new Date(firstDayOfMonth.setDate(firstDayOfMonth.getDate() - 1));
console.log(lastMonthLastDay); // Sun Jan 31 2021 00:00:00 GMT+0900 (대한민국 표준시)