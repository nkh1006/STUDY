const colors = ['red', 'green', 'blue', 'yellow', 'pink'];
let i = 0;
let x = 0;

for (let color in colors) {
   // index, value
   console.log(color, colors[color]);
}

for (let color of colors) {
   // value
   console.log(color);
}

while (i <= 10) {
   if (i === 5) break;
   console.log(i);
   i++;
}

while (x <= 10) {
   if (x % 2 === 0) {
      x++;
      continue;
   }
   console.log(x);
   x++;
}