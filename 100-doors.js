function getFinalOpenedDoors(numDoors) {
  // Generate an array of numDoors closed doors
  // false will be closed, true will be open
  let doorOpenArray = [];
  for (let i = 0; i < numDoors; i++) {
    doorOpenArray[i] = false;
  }

  // Make 100 passes
  // First pass, visit every door and toggle it
  // Second pass, visit every second door and toggle it
  // Third pass, visit every third door and toggle it
  // ...
  // 100th pass, visit every 100th door and toggle it
  for (let passes = 1; passes <= numDoors; passes++) {
    for (let pattern = passes - 1; pattern < numDoors; pattern += passes) {
      doorOpenArray[pattern] = toggleDoor(doorOpenArray[pattern]);
    }
  }

  let openDoors = [];
  for (let j = 0; j < numDoors; j++) {
    if (doorOpenArray[j]) {
      openDoors.push(j + 1);
    }
  }

  return openDoors;
}

function toggleDoor(isOpen) {
  if (isOpen) return false;
  return true;
}

console.log(getFinalOpenedDoors(100));
