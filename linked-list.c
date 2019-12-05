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

int main(void)
{
  addNode(5);
  addNode(8);
  addNode(10);
  addNode(4);

  displayList();
}
