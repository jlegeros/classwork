#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// create a binary node
// node should have an integer value
// node should have two branches

typedef struct BINODE
{
  char *word;
  struct BINODE *greater;
  struct BINODE *lesser;
} BINODE;

BINODE *root = NULL;

void addNode(char *val)
{
  BINODE *newNode = malloc(sizeof(BINODE));
  newNode->word = val;
  newNode->greater = NULL;
  newNode->lesser = NULL;

  if (root == NULL)
  {
    root = newNode;
    return;
  }

  BINODE *trav = root;

  while (1)
  {
    if (trav->word - val > 0)
    {
      if (trav->greater == NULL)
      {
        trav->greater = newNode;
        return;
      }
      trav = trav->greater;
      continue;
    }
    if (trav->lesser == NULL)
    {
      trav->lesser = newNode;
      return;
    }
    trav = trav->lesser;
    continue;
  }
}

// prints node, then its children from left to right
// void displayTreeOnEnter(BINARYNODE *node)
// {
//   if (node == NULL)
//     return;
//   printf(" %i ", node->value);
//   if (node->lesser != NULL)
//     displayTreeOnEnter(node->lesser);
//   if (node->greater != NULL)
//     displayTreeOnEnter(node->greater);
// }

// prints children, then itself
// void displayTreeOnExit(BINARYNODE *node)
// {
//   if (node == NULL)
//     return;
//   if (node->lesser != NULL)
//     displayTreeOnExit(node->lesser);
//   if (node->greater != NULL)
//     displayTreeOnExit(node->greater);
//   printf(" %i ", node->value);
// }

BINODE *hasValue(char *val)
{
  if (root == NULL)
    return NULL;

  BINODE *trav = root;

  while (1)
  {
    if (trav->word - val == 0)
    {
      int valLength = strlen(val);
      int travWordLength = strlen(trav->word);

      if (valLength == travWordLength)
      {
        int flag = 1;
        for (int i = 0; i < valLength; i++)
        {
          if (val[i] != trav->word[i])
          {
            flag = 0;
            break;
          }
        }
        if (flag == 1)
        {
          printf("Found %s\n", val);
          return trav;
        }
        if (trav->lesser != NULL)
        {
          trav = trav->lesser;
          continue;
        }
        printf("%s not found\n", val);
        return NULL;
      }
      


      if (trav->word[0] == val[0])
      {
        printf("first letter matched!\n");
      }
      if (trav->word[1] == val[1])
      {
        printf("second letter matched!\n");
      }
      printf("Found %s", val);
      return trav;
    }

    if (trav->word - val > 0)
    {
      if (trav->greater != NULL)
      {
        trav = trav->greater;
        continue;
      }
      printf("%s not found\n", val);
      return NULL;
    }

    if (trav->lesser != NULL)
    {
      trav = trav->lesser;
      continue;
    }
    printf("%s not found\n", val);
    return NULL;
  }
}

int main(void)
{
  char *stream[] = {"he", "cat", "dog", "cap", "cats", "log", "help", "hello", "hell"};

  for (int i = 0; i < 9; i++)
  {
    addNode(stream[i]);
  }

  hasValue("cat");
  hasValue("cats");
  hasValue("dog");
  hasValue("dogs");
  hasValue("catz");
  hasValue("he");
  hasValue("she");
  hasValue("help");
  hasValue("helps");
}