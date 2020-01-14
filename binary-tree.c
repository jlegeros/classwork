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
    return;
  }

  BINARYNODE *trav = root;
  int count = 1;

  while (1 == 1)
  {
    if (trav->value < newNode->value)
    {
      if (trav->greater == NULL)
      {
        trav->greater = newNode;
        return;
      }
      trav = trav->greater;
      continue;
    }
    else
    {
      if (trav->lesser == NULL)
      {
        trav->lesser = newNode;
        return;
      }
      trav = trav->lesser;
      continue;
    }
  }
}

// prints node, then its children from left to right
void displayTreeOnEnter(BINARYNODE *node)
{
  if (node == NULL)
    return;
  printf(" %i ", node->value);
  if (node->lesser != NULL)
    displayTreeOnEnter(node->lesser);
  if (node->greater != NULL)
    displayTreeOnEnter(node->greater);
}

// prints children, then itself
void displayTreeOnExit(BINARYNODE *node)
{
  if (node == NULL)
    return;
  if (node->lesser != NULL)
    displayTreeOnExit(node->lesser);
  if (node->greater != NULL)
    displayTreeOnExit(node->greater);
  printf(" %i ", node->value);
}

BINARYNODE *hasValue(int val)
{
  if (root == NULL)
    return NULL;
  BINARYNODE *trav = root;

  while (1)
  {
    if (trav->value == val)
    {
      printf("Found %i\n", val);
      return trav;
    }

    if (trav->value < val && trav->greater != NULL)
    {
      trav = trav->greater;
      continue;
    }

    if (trav->value > val && trav->lesser != NULL)
    {
      trav = trav->lesser;
      continue;
    }

    printf("%i not found\n", val);
    return NULL;
  }
}

// free list - easy

// display levels
// 5
// 4 8
// 2 6 9
// 1 3 7 10

int main(void)
{
  int stream[] = {5, 8, 9, 4, 6, 7, 2, 3, 1, 10};
  for (int i = 0; i < 10; i++)
  {
    addNode(stream[i]);
  }

  // should display 5, 4, 2, 1, 3, 8, 6, 7, 9, 10
  displayTreeOnEnter(root);
  printf("\n");
  // should display 1, 3, 2, 4, 7, 6, 10, 9, 8, 5
  displayTreeOnExit(root);
  printf("\n");

  hasValue(5);
  hasValue(404);
  hasValue(4);
  hasValue(8);
  hasValue(7);

  if ("cat" - "cats" < 0)
  {
    printf("test cat worked\n");
  }
}