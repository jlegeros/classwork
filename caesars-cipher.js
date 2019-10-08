/*
One of the simplest and most widely known ciphers is a Caesar cipher, also known as a shift cipher. In a shift cipherthe meanings of the letters are shifted by some set amount.

A common modern use is the ROT13 cipher, where the values of the letters are shifted by 13 places. Thus 'A' ↔ 'N', 'B' ↔ 'O' and so on.

Write a function which takes a ROT13 encoded string as input and returns a decoded string.

All letters will be uppercase. Do not transform any non-alphabetic character (i.e. spaces, punctuation), but do pass them on.
*/

function rot13(str) {
  // LBH QVQ VG!
  var decodedStr = "";

  // Capital letters are ascii code 65 - 90
  // Iterate through the encoded str and add the decoded letter to the decodedStr;
  for (var i = 0; i < str.length; i++) {
    var asciiValue = str[i].charCodeAt(0);
    if (asciiValue >= 65 && asciiValue <= 90) {
      asciiValue = ((asciiValue - 65 + 13) % 26) + 65;
      decodedStr += String.fromCharCode(asciiValue);
    } else {
      decodedStr += str[i];
    }
    //console.log(`char: ${str[i]} is ${asciiValue}`);
  }

  return decodedStr;
}

// Change the inputs below to test
console.log(rot13("SERR PBQR PNZC"));
console.log(rot13("LBH QVQ VG!"));
console.log(rot13("SERR CVMMN!"));
console.log(rot13("SERR YBIR?"));
console.log(rot13("GUR DHVPX OEBJA SBK WHZCF BIRE GUR YNML QBT."));
