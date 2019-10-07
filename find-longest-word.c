#include <stdio.h>
#include <string.h>

int findLongestWordLength(char str[])
{
    int largest = 0;
    int count = 0;

    for (int i = 0; i < strlen(str); i++)
    {
        if (str[i] != ' ')
        {
            count++;
        }
        else
        {
            if (count > largest)
            {
                largest = count;
            }
            count = 0;
        }
    }
    // catches the length of the last word...
    if (count > largest)
    {
        largest = count;
    }
    printf("longest word in '%s' is %i characters long\n", str, largest);
    return largest;
}

int main(void)
{
    findLongestWordLength("test two a");
    findLongestWordLength("Google do a barrel roll");
    findLongestWordLength("May the force be with you");
    findLongestWordLength("The quick brown fox jumped over the lazy dog");
    findLongestWordLength("What is the average airspeed velocity of an unladen swallow");
    findLongestWordLength("What if we try a super-long word such as otorhinolaryngology");
    return 0;
}