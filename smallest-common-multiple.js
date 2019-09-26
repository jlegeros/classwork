/*
Find the smallest common multiple of the provided parameters that can be evenly divided by both, as well as by all sequential numbers in the range between these parameters.

The range will be an array of two numbers that will not necessarily be in numerical order.

For example, if given 1 and 3, find the smallest common multiple of both 1 and 3 that is also evenly divisible by all numbers between 1 and 3. The answer here would be 6.
*/

function smallestCommons(arr) {
  let range = [];
  if (arr[0] < arr[1]) {
    for (let n = arr[1]; n >= arr[0]; n--) {
      range.push(n);
    }
  } else {
    for (let n = arr[0]; n >= arr[1]; n--) {
      range.push(n);
    }
  }

  let multiplesOfLargest;
  for (let p = 1; true; p++) {
    multiplesOfLargest = range[0] * p;
    for (let i = 1; i <= range.length; i++) {
      if (i == range.length) {
        return multiplesOfLargest;
      }
      if (multiplesOfLargest % range[i] != 0) {
        break;
      }
    }
  }
}

//smallestCommons([1, 5]); //should return a number.
//smallestCommons([1, 5]); //should return 60.
//smallestCommons([5, 1]); //should return 60.
//smallestCommons([2, 10]); //should return 2520.
//smallestCommons([1, 13]); //should return 360360.
smallestCommons([23, 18]); //should return 6056820.
