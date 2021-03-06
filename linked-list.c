/*
  Linked list:
    A data structure which contains nodes which have a value and a pointer to the next node.
*/

#include <stdio.h>
#include <stdlib.h>

typedef struct NODE
{
  int value;
  struct NODE *next;
} NODE;

NODE *rootNode = NULL;

void addNode(int val)
{
  NODE *newNode = malloc(sizeof(NODE));
  newNode->value = val;
  newNode->next = NULL;

  if (rootNode == NULL)
  {
    rootNode = newNode;
  }
  else
  {
    NODE *trav = rootNode;
    while (trav->next != NULL)
    {
      trav = trav->next;
    }

    trav->next = newNode;
  }
}

void displayList()
{
  NODE *trav = rootNode;

  printf("%i", trav->value);
  while (trav->next != NULL)
  {
    trav = trav->next;
    printf(", %i", trav->value);
  }
  printf("\n");
}

void freeNode(NODE *node)
{
  if (node->next != NULL)
  {
    freeNode(node->next);
  }
  free(node);
}

void freeList()
{
  // while (rootNode->next != NULL)
  // {
  //   NODE *prev = rootNode;
  //   NODE *next = rootNode->next;
  //   while (next->next != NULL)
  //   {
  //     prev = next;
  //     next = next->next;
  //   }
  //   free(next);
  //   prev->next = NULL;
  // }
  // free(rootNode);
  // rootNode = NULL;
  if (rootNode != NULL)
  {
    freeNode(rootNode);
  }
  rootNode = NULL;
}

NODE *hasValue(int val)
{
  if (rootNode == NULL)
    return NULL;

  NODE *trav = rootNode;
  if (trav->value == val)
  {
    printf("found %i\n", val);
    return trav;
  }

  while (trav->next != NULL)
  {
    trav = trav->next;
    if (trav->value == val)
    {
      printf("found %i\n", val);
      return trav;
    }
  }
  printf("did not find value\n");
  return NULL;
}

int main(void)
{
  addNode(5);
  addNode(8);
  addNode(9);
  addNode(4);

  displayList();

  NODE *item1 = hasValue(9);

  NODE *item2 = hasValue(7);

  addNode(7);
  displayList();

  NODE *item3 = hasValue(7);

  freeList();
}
