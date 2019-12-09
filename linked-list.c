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
  if (rootNode != NULL){
    freeNode(rootNode);
  }
  rootNode = NULL;
}

NODE* hasValue(int val)
{
  if (rootNode == NULL)
  {
    return NULL;
  }

  if (rootNode->next == NULL)
  {
    if (rootNode->value == val)
    {
      return rootNode;
    }
    return NULL;
  }

  NODE *trav = rootNode;

  while (trav->next != NULL)
  {
    if (trav->value == val)
    {
      return trav;
    }
    trav = trav->next;
  }

  return NULL;

  // return NULL if it does not exist
  // return the pointer to the value if it exists
}

int main(void)
{
  addNode(5);
  addNode(8);
  addNode(10);
  addNode(4);

  displayList();

  NODE *item1 = hasValue(9);
  if (item1 != NULL)
  {
    printf("%i\n", item1->value);
  }
  else
  {
    printf("Item not found\n");
  }

  NODE *item2 = hasValue(10);
  if (item2 != NULL)
  {
    printf("%i\n", item2->value);
  }
  else
  {
    printf("Item not found\n");
  }

  freeList();
}
