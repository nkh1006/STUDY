// Constructor Function

function Todo(name, completed) {
   this.name = name;
   this.completed = completed;
   /*
   this.getTodoName = function() {
      console.log(this.name);
   };
   */
   this.checkCompleted = function() {
      console.log("check");
   };
   this.deleteTodo = function() {
      console.log("deletes");
   }
}

Todo.prototype.getTodoName = function() {
   console.log(this.name);
}

const todo = new Todo("Buy Eggs", false);
const todo2 = new Todo("Do my homework", false);