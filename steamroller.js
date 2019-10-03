/*
Flatten a nested array. You must account for varying levels of nesting.
*/

function steamrollArray(arr) {
  let newArr = [];
  while (arr.length > 0) {
    // use isArray --
    if (arr[0].length != undefined && typeof arr[0] != "string") {
      newArr = newArr.concat(steamrollArray(arr.shift()));
    } else {
      newArr.push(arr.shift());
    }
  }
  return newArr;
}

console.log(steamrollArray([[["a"]], [["b"]]])); //should return ["a", "b"].
console.log(steamrollArray([1, [2], [3, [[4]]]])); //should return [1, 2, 3, 4].
console.log(steamrollArray([1, [], [3, [[4]]]])); //should return [1, 3, 4].
console.log(steamrollArray([1, {}, [3, [[4]]]])); //should return [1, {}, 3, 4].
console.log(steamrollArray([[["a"]], [["b"]]]));
