const p = new Promise((resolve, reject) => {
   // pending
   setTimeout(() => {
      // fulfilled
      resolve();
   }, 1000);
});

p.then(() => {

});