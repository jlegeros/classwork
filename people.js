class Person {
  constructor(name, age) {
    // underscore is the convention of a private key/value
    // note, Javascript does not enforce private values
    this._name = name;
    this.age = age;
  }

  printName() {
    console.log(this._name);
  }

  changeName(newName) {
    this._name = newName;
  }
}

class Employee extends Person {}

const newPerson = new Person("Jason", 29);
newPerson.printName();
newPerson.changeName("Jack");
newPerson.printName();
console.log(newPerson._name);
const newEmployee = new Employee("test", 13);
newEmployee.printName();
