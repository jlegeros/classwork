/*
Given a month and year
Determine the 2 decimal year value in relation to today.

H Challenge: allow user to enter past and future date and determine year in relation to that
*/

const readline = require("readline");

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question(
  "Please make a choice\n1) Calculate years passed since a date\n2) Calculate years between two dates\n: ",
  answer => {
    if (answer == 1) {
      rl.question("Please enter the year: ", year => {
        rl.question("please enter the month: ", month => {
          //call function which calculates the differential
          if (month >= 1 && month <= 12) {
            calculateYearsBetween(month, year);
          } else console.log("You did not enter a valid month...");
          rl.close();
        });
      });
    } else if (answer == 2) {
      rl.question("Please enter the starting year: ", startYear => {
        rl.question("please enter the starting month: ", startMonth => {
          rl.question("Please enter the ending year: ", endYear => {
            rl.question("please enter the ending month: ", endMonth => {
              if (
                startMonth >= 1 &&
                startMonth <= 12 &&
                endMonth >= 1 &&
                startMonth <= 12
              ) {
                if (
                  startYear < endYear ||
                  (startYear == endYear && startMonth < endMonth)
                ) {
                  calculateYearsBetween(
                    startMonth,
                    startYear,
                    endMonth,
                    endYear
                  );
                } else console.log(`You entered an invalid date range`);
              } else console.log(`You entered an invalid month`);
              rl.close();
            });
          });
        });
      });
    } else {
      console.log(`You did not enter a valid input...`);
      rl.close();
    }
  }
);

function calculateYearsPassed(month, year) {
  const CURRENTDATE = new Date();
  const CURRENTYEAR = CURRENTDATE.getFullYear();
  const CURRENTMONTH = CURRENTDATE.getMonth() + 1;
  if (CURRENTYEAR > year || (year == CURRENTYEAR && month < CURRENTMONTH)) {
    console.log(
      (((CURRENTYEAR - year) * 12 + (CURRENTMONTH - month)) / 12).toFixed(2)
    );
  } else {
    console.log("Your date is not in the past...");
  }
}

function calculateYearsBetween(
  startMonth,
  startYear,
  endMonth = -1,
  endYear = -1
) {
  if (endMonth == -1) {
    endMonth = new Date().getMonth() + 1;
    endYear = new Date().getFullYear();
  }
  if (endYear > startYear || (startYear == endYear && startMonth < endMonth)) {
    console.log(
      `${(((endYear - startYear) * 12 + (endMonth - startMonth)) / 12).toFixed(
        2
      )}`
    );
  }
}
