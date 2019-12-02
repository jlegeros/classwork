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

void addNode(int val, NODE *listNode)
{
  while (listNode->next != NULL)
  {
    listNode = listNode->next;
  }
  NODE *newNode = malloc(sizeof(NODE));
  newNode->value = val;
  newNode->next = NULL;
  listNode->next = newNode;
}

int main(void)
{
  NODE rootNode;
  rootNode.value = 5;
  rootNode.next = NULL;

  addNode(8, &rootNode);
  addNode(10, &rootNode);

  printf("%i\n", rootNode.value);
  printf("%i\n", rootNode.next->value);
  printf("%i\n", rootNode.next->next->value);
}
