/*
  Return true if a leap year, false if not
  if divisible by 4 its a leap year
  but if also divisible by 100 its not a leap year
  but if also divisible by 400, it is a leap year
*/

#include <stdbool.h>
#include <stdio.h>

bool determineIfLeapYear(int year)
{
  if (year % 4 == 0)
  {
    if (year % 100 == 0)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      return false;
    }
    return true;
  }
  return false;
}

int main(void)
{
  printf("%s\n", determineIfLeapYear(1900) ? "true" : "false");
}