// array

const item = ['banana', 'chocolate noddle', 'apple', 'cheesee', 'foods'];

const item1 = item[0];
const item2 = item[1];
const item3 = item[2];
const item4 = item[3];

// banana chocolate noddle apple cheesee
console.log(item1, item2, item3, item4);

// deconstruct array
const [banana, chcolate, apple, ...food] = item;
const [data1, data2, ...data3] = item;

// banana chocolate noddle apple ["cheesee", "foods"]
console.log(banana, chcolate, apple, food);

// banana chocolate noddle
console.log(data1, data2);

// ["apple", "cheesee", "foods"]
console.log(data3);

// object
const user = {
   name: 'Ed',
   photos: [1,2,3,4,5,6,7],
   age: 25,
   analytics: {
      subsribers: 25000,
      videos: 250
   }
}

const photos = user.photos;

// [1,2,3,4,5,6,7]
console.log(photos);

// deconstruct array object
const { analytics, age } = user;

// {subsribers: 25000, videos: 250} 25
console.log(analytics, age);