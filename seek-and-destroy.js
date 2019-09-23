/*
You will be provided with an initial array (the first argument in the destroyer function), followed by one or more arguments. Remove all elements from the initial array that are of the same value as these arguments.

Note
You have to use the argumentsobject.
*/

function destroyer() {
  const arr = arguments[0];
  //console.log(arr);
  for (let i = 1; i < arguments.length; i++) {
    while (arguments[0].includes(arguments[i])) {
      arguments[0].splice(arguments[0].indexOf(arguments[i]), 1);
    }
  }

  //console.log(arr);
  return arr;
}

destroyer([1, 2, 3, 1, 2, 3], 2, 3);
