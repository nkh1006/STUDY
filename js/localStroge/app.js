const nameInput = document.querySelector('#name');
const ageInput = document.querySelector('#age');
const addrInput = document.querySelector('#addr');
const addButton = document.querySelector('#addBtn');
const resetButton = document.querySelector('#resetBtn');
const personList = document.querySelector('.list-group');
const newList = document.createElement('li');
let persons = [];

addButton.addEventListener('click', addPerson);
resetButton.addEventListener('click', clearLocal);

window.onload = getStorage();

function getStorage() {
   let localPerson = JSON.parse(localStorage.getItem("person"));
   console.log(localPerson);
   if (localPerson) {
      for (p in localPerson) {
         newList.innerHTML = `${p} : ${localPerson[p]}`;
         newList.classList.add('list-group-item');
         personList.appendChild(newList);         
      }
   } else {
      console.log('no local storage items');
   }
}

function addPerson(e) {
   e.preventDefault();
   const nameValue = nameInput.value;
   const ageValue = ageInput.value;
   const addrValue = addrInput.value;   
   if (nameValue == "" || ageValue == "" || addrValue == "") {
      console.log(nameValue, ageValue, addrValue);
      alert('insert data');
   } else {
      newList.innerHTML = `name : ${nameValue}, age : ${ageValue}, addr : ${addrValue}`;
      newList.classList.add('list-group-item');
      personList.appendChild(newList);
      saveStorage();
   }
   
   function saveStorage() {
      let personData = `name : ${nameValue}, age : ${ageValue}, addr : ${addrValue}`;
      persons.push(personData);
      localStorage.setItem("person", JSON.stringify(persons));
   }
}

function clearLocal() {
   localStorage.clear();
   alert('clear local storage !');
}