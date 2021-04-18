// FUNCTIONS -> SPECIAL OBJECT
// BIND CALL APPLY

const person = {
   firstName: 'Ed',
   lastName: 'Developer',
   getName() {
      console.log(this.firstName + ' ' + this.lastName);
   }
}

function registerUser() {
   console.log(this);
}

function registerUser(country, lang) {
   this.getName();
   console.log(`MY country is ${country} and my language is ${lang}`);
}

registerUser.call(person, 'hungary', 'en');

registerUser();

// registerUser.apply(person, ['hungary', 'en']);