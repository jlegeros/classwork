#include <stdio.h>

int main(void)
{

    printf("Enter the pyramid height: ");

    int height;
    scanf("%i", &height);

    //printf("%i\n", height);

    for (int line = 1; line <= height; line++)
    {
        //string output = "";
        int spaces = 0;
        while (spaces < height - line)
        {
            printf(" ");
            spaces++;
        }
        int hashes = 0;
        while (hashes < line)
        {
            printf("#");
            hashes++;
        }
        printf("\n");
    }
}