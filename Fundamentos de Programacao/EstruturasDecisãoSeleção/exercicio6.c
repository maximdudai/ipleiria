#include <stdio.h>
#include <stdlib.h>

int main() {

    printf("Introduce a number from 1 to 10: ");
    int number;
    scanf("%d", &number);

    int result = 0;
    for(int i = 1; i <= number; i++)
    {
      result += i;
    }

    printf("The result is: %d\n", result);
    return 0;
}
