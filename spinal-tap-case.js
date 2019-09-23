/*
Convert a string to spinal case. Spinal case is all-lowercase-words-joined-by-dashes.
*/

function spinalCase(str) {
  // "It's such a fine line between stupid, and clever."
  // --David St. Hubbins
  let strArray = str.split("");
  let newString = "";
  let lengthDiff = 0;
  for (let i = 0; i < strArray.length; i++) {
    if (strArray[i] == " " || strArray[i] == "_") {
      newString += "-";
      //console.log(`strArray[i] = "${strArray[i]}" so I'm adding a "-"`);
    } else if (strArray[i] == strArray[i].toUpperCase()) {
      if (
        i != 0 &&
        (strArray[i] != "-" && newString[i + lengthDiff - 1] != "-")
      ) {
        //console.log(`because confusion, we add a dash...`);
        newString += "-";
        lengthDiff++;
      }
      newString += strArray[i].toLowerCase();
      //console.log(`strArray[i] = "${strArray[i]}" so we make it lowercase`);
    } else {
      //console.log(`strArray[i] = "${strArray[i]}" so we are keeping it!`);
      newString += strArray[i];
    }
  }
  // if space, remove space and add dash (if no dash is preceding)

  // if capital letter, set to lowercase and add dash before (unless first letter)

  // if an underscore, replace with dash

  return newString;
}

spinalCase("This Is Spinal Tap"); //should return "this-is-spinal-tap".
spinalCase("thisIsSpinalTap"); //should return "this-is-spinal-tap".
spinalCase("The_Andy_Griffith_Show"); //should return "the-andy-griffith-show".
spinalCase("Teletubbies say Eh-oh"); //should return "teletubbies-say-eh-oh".
spinalCase("AllThe-small Things"); //should return "all-the-small-things".
