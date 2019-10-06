/*
Convert the given number into a roman numeral.

All roman numerals answers should be provided in upper-case.
Test case only goes to 3999 (don't have to deal with 4000)
*/

function convertToRoman(num) {
  var numRN = "";
  var thousands = 0;
  while (num - 1000 >= 0) {
    thousands++;
    num -= 1000;
  }
  var hundreds = 0;
  while (num - 100 >= 0) {
    hundreds++;
    num -= 100;
  }
  var tens = 0;
  while (num - 10 >= 0) {
    tens++;
    num -= 10;
  }
  var singles = 0;
  while (num - 1 >= 0) {
    singles++;
    num -= 1;
  }

  if (thousands > 0 && thousands < 4) {
    for (let i = 0; i < thousands; i++) {
      numRN += "M";
    }
  }
  if (hundreds > 8) {
    for (let i = 0; i < 10 - hundreds; i++) {
      numRN += "C";
    }
    numRN += "M";
  } else if (hundreds > 5) {
    numRN += "D";
    for (let i = 0; i < hundreds - 5; i++) {
      numRN += "C";
    }
  } else if (hundreds == 5) {
    numRN += "D";
  } else if (hundreds == 4) {
    numRN += "CD";
  } else if (hundreds > 0) {
    for (let i = 0; i < hundreds; i++) {
      numRN += "C";
    }
  }
  if (tens > 8) {
    for (let i = 0; i < 10 - tens; i++) {
      numRN += "X";
    }
    numRN += "C";
  } else if (tens > 5) {
    numRN += "L";
    for (let i = 0; i < tens - 5; i++) {
      numRN += "X";
    }
  } else if (tens == 5) {
    numRN += "L";
  } else if (tens == 4) {
    numRN += "XL";
  } else if (tens > 0) {
    for (let i = 0; i < tens; i++) {
      numRN += "X";
    }
  }
  if (singles > 8) {
    for (let i = 0; i < 10 - singles; i++) {
      numRN += "I";
    }
    numRN += "X";
  } else if (singles > 5) {
    numRN += "V";
    for (let i = 0; i < singles - 5; i++) {
      numRN += "I";
    }
  } else if (singles == 5) {
    numRN += "V";
  } else if (singles == 4) {
    numRN += "IV";
  } else if (singles > 0) {
    for (let i = 0; i < singles; i++) {
      numRN += "I";
    }
  }

  return numRN;
}

console.log(convertToRoman(8));
