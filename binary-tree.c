#include <stdio.h>
#include <stdlib.h>

// create a binary node
// node should have an integer value
// node should have two branches

typedef struct BINARYNODE
{
  int value;
  struct BINARYNODE *greater;
  struct BINARYNODE *lesser;
} BINARYNODE;

BINARYNODE *root = NULL;

void addNode(int val)
{
  BINARYNODE *newNode = malloc(sizeof(BINARYNODE));
  newNode->value = val;
  newNode->greater = NULL;
  newNode->lesser = NULL;

  if (root == NULL)
  {
    root = newNode;
    printf("Added %i node to the root\n", val);
  }
  else
  {
    BINARYNODE *trav = root;
    int count = 1;

    if (trav->value < newNode->value)
    {
      while (trav->greater != NULL)
      {
        trav = trav->greater;
        count++;
      }
      trav->greater = newNode;
      printf("Added %i Node to left side, %i branches down\n", val, count);
    }
    else
    {
      while (trav->lesser != NULL)
      {
        trav->lesser = newNode;
        count++;
      }
      trav->lesser = newNode;
      printf("Added %i Node to right side, %i branches down\n", val, count);
    }
  }
}

int main(void)
{
  addNode(7);
  addNode(9);
  addNode(4);
  addNode(11);
}