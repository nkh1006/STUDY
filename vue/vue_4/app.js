Vue.component('my-todo-item', {
   props:  ['todo'],
   template: `<li>
            <input type="checkbox" v-model="todo.done">
            <span v-bind:class="{ done: todo.done}">{{ todo.title }}</span>
         </li>`
});


const vm = new Vue({
   el: "#app",
   data: {
      todos: [
         {
            id: '1',
            title: '아침 먹기',
            done: true
         },
         {
            id: '2',
            title: '점심 먹기',
            done: false
         },
         {
            id: '3',
            title: '저녁 먹기',
            done: false
         },
         {
            id: '4',
            title: '간식 먹기',
            done: false
         },
         {
            id: '5',
            title: '야식 먹기',
            done: false
         },
      ]
   }
});