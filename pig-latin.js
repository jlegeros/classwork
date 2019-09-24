/*
Translate the provided string to pig latin.

Pig Latin takes the first consonant (or consonant cluster) of an English word, moves it to the end of the word and suffixes an "ay".

If a word begins with a vowel you just add "way" to the end.

Input strings are guaranteed to be English words in all lowercase.
*/

function translatePigLatin(str) {
  newString = str.split("");

  if (
    newString[0] == "a" ||
    newString[0] == "e" ||
    newString[0] == "i" ||
    newString[0] == "o" ||
    newString[0] == "u"
  ) {
    str = newString.join("") + "way";
  } else {
    let count = 1;
    while (true) {
      if (
        newString[count] == "a" ||
        newString[count] == "e" ||
        newString[count] == "i" ||
        newString[count] == "o" ||
        newString[count] == "u"
      ) {
        let tempString = newString.splice(0, count);
        //console.log(tempString);
        str = newString.join("") + tempString.join("") + "ay";
        break;
      }
      count++;
      if (count >= newString.length) {
        str = str + "ay";
        break;
      }
    }
  }

  return str;
}

translatePigLatin("consonant");
translatePigLatin("california"); //should return "aliforniacay".
translatePigLatin("paragraphs"); //should return "aragraphspay".
translatePigLatin("glove"); //should return "oveglay".
translatePigLatin("algorithm"); //should return "algorithmway".
translatePigLatin("eight"); //should return "eightway".
//Should handle words where the first vowel comes in the end of the word.
//Should handle words without vowels.
