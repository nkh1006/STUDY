const vm = new Vue({
   el: "#app",
   data: {
      msgA: 'Message A !',
      msgB: ''
   },
   methods: {
      changeMessage: function () {
         if(this.msgA === 'Changed Message A !') {
            this.msgA = 'Message A !'
         } else {
            this.msgA = 'Changed Message A !'
            this.msgB = 'Changed Message B !'
         }
      }
   },
   computed: {},
   watch: {
      msgA(value) {
         console.log(value);
      }
   },
   created() {

   },
});

console.log(vm);