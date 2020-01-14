/*
  You are given two arrays and an index.

  Use the array methods slice and splice to copy each element of the first array into the second array, in order.

  Begin inserting elements at index n of the second array.

  Return the resulting array. The input arrays should remain the same after the function runs.
*/

#include <stdio.h>

void frankenSplice(int arr1[], int arr2[], int index )
{

}

void displayArray(int arr[], int n)
{
  printf("[");
  for (int i = 0; i < n; i++ )
  {
    if ( i != 0)
    {
      printf(", ");
    }
    printf("%i", arr[i]);
  }
  printf("]\n");
}

int main(void)
{
  int testArray[3] = {3, 4, 5};
  displayArray(testArray, sizeof(testArray)/sizeof(int));
  return 0;
}