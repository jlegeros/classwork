/*
Return trueif the passed string looks like a valid US phone number.

The user may fill out the form field any way they choose as long as it has the format of a valid US number. The following are examples of valid formats for US numbers (refer to the tests below for other variants):

555-555-5555
(555)555-5555
(555) 555-5555
555 555 5555
5555555555
1 555 555 5555

For this challenge you will be presented with a string such as 800-692-7753or 8oo-six427676;laskdjf. Your job is to validate or reject the US phone number based on any combination of the formats provided above. The area code is required. If the country code is provided, you must confirm that the country code is 1. Return trueif the string is a valid US phone number; otherwise return false.
*/

function telephoneCheck(str) {
  // Good luck!
  var validChars = new RegExp("[0-9]|[-()\\s]", "g");
  var excessStr = str.replace(validChars, "");
  if (excessStr.length > 0) {
    return false;
  }
  var nonNumbers = new RegExp("[-()\\s]", "g");
  var numbersOnly = str.replace(nonNumbers, "");
  if (numbersOnly.length < 10 || numbersOnly.length > 11) {
    return false;
  } else if (numbersOnly.length == 11 && str[0] != "1") {
    return false;
  }
  if (!validChars.test(str[0])) {
    return false;
  }
  var parantheses = new RegExp("\\(|\\)");
  var properParantheses = new RegExp("\\(\\d\\d\\d\\)");
  if (parantheses.test(str)) {
    if (!properParantheses.test(str)) {
      return false;
    }
  }

  return true;
}

console.log(telephoneCheck("555-555-5555")); //should return a boolean.
console.log(telephoneCheck("1 555-555-5555")); //should return true.
console.log(telephoneCheck("1 (555) 555-5555")); //should return true.
console.log(telephoneCheck("5555555555")); //should return true.
console.log(telephoneCheck("555-555-5555")); //should return true.
console.log(telephoneCheck("(555)555-5555")); //should return true.
console.log(telephoneCheck("1(555)555-5555")); //should return true.
console.log(telephoneCheck("555-5555")); //should return false.
console.log(telephoneCheck("5555555")); //should return false.
console.log(telephoneCheck("1 555)555-5555")); //should return false.
console.log(telephoneCheck("1 555 555 5555")); //should return true.
console.log(telephoneCheck("1 456 789 4444")); //should return true.
console.log(telephoneCheck("123**&!!asdf#")); //should return false.
console.log(telephoneCheck("55555555")); //should return false.
console.log(telephoneCheck("(6054756961)")); //should return false
console.log(telephoneCheck("2 (757) 622-7382")); //should return false.
console.log(telephoneCheck("0 (757) 622-7382")); //should return false.
console.log(telephoneCheck("-1 (757) 622-7382")); //should return false
console.log(telephoneCheck("2 757 622-7382")); //should return false.
console.log(telephoneCheck("10 (757) 622-7382")); //should return false.
console.log(telephoneCheck("27576227382")); //should return false.
console.log(telephoneCheck("(275)76227382")); //should return false.
console.log(telephoneCheck("2(757)6227382")); //should return false.
console.log(telephoneCheck("2(757)622-7382")); //should return false.
console.log(telephoneCheck("555)-555-5555")); //should return false.
console.log(telephoneCheck("(555-555-5555")); //should return false.
console.log(telephoneCheck("(555)5(55?)-5555")); //should return false.
