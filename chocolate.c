/*
  Make Chocolate: We want to build a gift basket with x kilos of chocolate
  We have two sized bars available small bars at 1 kilo and big bars at 5 kilo each
  return number of small bars used assuming we always use large bars first
  return -1 if if can't be done.

  Examples:
    function(s, b, x) : s = small available, b = big available, x = kilo goal
    function(4, 1, 9) => 4
    function(4, 1, 10) => -1
    function(1, 2, 7) => -1
*/

#include <stdio.h>

int makeChocolate(int small, int large, int goal)
{
  goal = goal / 5 <= large ? goal % 5 : goal - (large * 5);

  return goal <= small ? goal : -1;
}

int main(void)
{
  printf("%i\n", makeChocolate(4, 1, 9));
  printf("%i\n", makeChocolate(4, 1, 10));
  printf("%i\n", makeChocolate(1, 2, 7));
  printf("%i\n", makeChocolate(6, 1, 11));
  return 0;
}