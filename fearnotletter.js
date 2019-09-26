/*
Find the missing letter in the passed letter range and return it.

If all letters are present in the range, return undefined.
*/

function fearNotLetter(str) {
  let start = undefined;
  for (let i = 0; i < str.length; i++) {
    if (start == undefined) {
      start = str.charCodeAt(i);
    } else {
      if (start + i != str.charCodeAt(i)) {
        return String.fromCharCode(start + i);
      }
    }
  }
  return undefined;
}

fearNotLetter("abce"); //should return "d".
fearNotLetter("abcdefghjklmno"); //should return "i".
fearNotLetter("stvwx"); //should return "u".
fearNotLetter("bcdf"); //should return "e".
fearNotLetter("abcdefghijklmnopqrstuvwxyz"); //should return undefined.
