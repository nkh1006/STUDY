function user() {
   const name = 'Ed';
   const displayName = function(greeting) {
      console.log(greeting + name);
   };
   return displayName;
}

const say = user();