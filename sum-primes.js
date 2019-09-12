/*
Sum all the prime numbers up to and including the provided number.

A prime number is defined as a number greater than one and having only two divisors, one and itself. For example, 2 is a prime number because it's only divisible by one and two.

The provided number may not be a prime.
*/

function sumPrimes(num) {
  let sum = 0;
  for (let i = 0; i <= num; i++) {
    sum += determineIfPrime(i) ? i : 0;
  }

  return sum;
}

// Determines if n is a prime number
function determineIfPrime(n) {
  for (let i = 2; i < n; i++) {
    if (n % i == 0) return false;
  }
  return n >= 2 ? true : false;
}

/*
for (let j = 0; j < 100; j++) {
  console.log(`is ${j} a prime? ${determineIfPrime(j)}`);
}
*/
console.log(sumPrimes(10));
