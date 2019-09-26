/*
Create a function that sums two arguments together. If only one argument is provided, then return a function that expects one argument and returns the sum.

For example, addTogether(2, 3)should return 5, and addTogether(2)should return a function.

Calling this returned function with a single argument will then return the sum:

var sumTwoAnd = addTogether(2);

sumTwoAnd(3)returns 5.

If either argument isn't a valid number, return undefined.
*/

function addTogether() {
  for (let i = 0; i < arguments.length; i++) {
    if (!isNumber(arguments[i])) {
      return undefined;
    }
  }
  if (arguments.length == 1) {
    let num1 = arguments[0];
    return function(num2) {
      if (!isNumber(num2)) {
        return undefined;
      } else {
        return num1 + num2;
      }
    };
  } else {
    return arguments[0] + arguments[1];
  }
}

function isNumber(arg) {
  if (typeof arg == "number") {
    return true;
  } else {
    return false;
  }
}

addTogether(2, 3); //should return 5.
addTogether(2)(3); //should return 5.
addTogether("http://bit.ly/IqT6zt"); //should return undefined.
addTogether(2, "3"); //should return undefined.
addTogether(2)([3]); //should return undefined.
