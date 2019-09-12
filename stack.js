class Stack {
  constructor() {
    //initialize data/properties of the stack
    this._data = [];
  }
  push(element) {
    this._data.push(element);
  }
  pop() {
    return this._data.pop();
  }
  top() {
    return this._data[this._data.length - 1];
  }
  isEmpty() {
    return this.size == 0;
  }
  size() {
    return this._data.length;
  }
}

word = "apple";
ns = new Stack();
word.split("").map(c => {
  ns.push(c);
});

console.log(ns);
