/*
Return trueif the given string is a palindrome. Otherwise, return false.

A palindrome is a word or sentence that's spelled the same way both forward and backward, ignoring punctuation, case, and spacing.

Note
You'll need to remove all non-alphanumeric characters (punctuation, spaces and symbols) and turn everything into the same case (lower or upper case) in order to check for palindromes.

We'll pass strings with varying formats, such as "racecar", "RaceCar", and "race CAR"among others.

We'll also pass strings with special symbols, such as "2A3*3a2", "2A3 3a2", and "2_A3*3#A2".
*/

function palindrome(str) {
  // set str to lowercase
  str = str.toLowerCase();

  // interate through both sides, skipping non alphanumeric characters
  // if character doesn't match, return false
  // if the right and left iterators ever cross without failing, return true
  var right = 0;
  var left = str.length - 1;
  while (true) {
    while (true) {
      var charCode = str.charCodeAt(right);
      if (
        !(charCode > 47 && charCode < 58) && // numeric (0-9)
        !(charCode > 64 && charCode < 91) && // upper alpha (A-Z)
        !(charCode > 96 && charCode < 123) // lower alpha (a-z)
      ) {
        right++;
        continue;
      }
      break;
    }
    while (true) {
      var charCode = str.charCodeAt(left);
      if (
        !(charCode > 47 && charCode < 58) && // numeric (0-9)
        !(charCode > 64 && charCode < 91) && // upper alpha (A-Z)
        !(charCode > 96 && charCode < 123) // lower alpha (a-z)
      ) {
        left--;
        continue;
      }
      break;
    }
    if (str[right] != str[left]) {
      return false;
    }
    if (right >= left) {
      return true;
    }
    right++;
    left--;
  }
}

console.log(palindrome("A man, a plan, a canal. Panama"));
