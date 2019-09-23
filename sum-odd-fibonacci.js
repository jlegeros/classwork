/*
Given a positive integer num, return the sum of all odd Fibonacci numbers that are less than or equal to num.

The first two numbers in the Fibonacci sequence are 1 and 1. Every additional number in the sequence is the sum of the two previous numbers. The first six numbers of the Fibonacci sequence are 1, 1, 2, 3, 5 and 8.

For example, sumFibs(10)should return 10because all odd Fibonacci numbers less than or equal to 10are 1, 1, 3, and 5.
*/

function sumFibs(num) {
  let loop = true;
  let count = 1;
  let sum = 0;
  while (loop) {
    let fibNum = getFibonacci(count);
    if (fibNum <= num) {
      count++;
      if (fibNum % 2 == 1) {
        sum += fibNum;
        //console.log(fibNum);
      }
    } else {
      loop = false;
    }
  }
  return sum;
}

// Returns the n fibonacci value
function getFibonacci(n) {
  if (n == 1) return 0;
  if (n == 2) return 1;
  if (n > 2) return getFibonacci(n - 1) + getFibonacci(n - 2);
}

/*
// Generate Fibonacci numbers
for (let i = 1; i < 20; i++) {
  console.log(getFibonacci(i));
}
*/
console.log(sumFibs(4));
