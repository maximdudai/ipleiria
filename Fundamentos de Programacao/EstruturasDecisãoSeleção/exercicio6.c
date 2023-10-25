#include <stdio.h>
#include <stdlib.h>

int main() {

    printf("Introduce a number from 1 to 10: ");
    int number;
    scanf("%d", &number);

    int result = 0;
    
    switch (number)
    {
      case 10: result += 10;
      case 9: result += 9;
      case 8: result += 8;
      case 7: result += 7;
      case 6: result += 6;
      case 5: result += 5;
      case 4: result += 4;
      case 3: result += 3;
      case 2: result += 2;
      case 1: 
        result += 1;
        break;

      default:
        printf("Invalid number\n"); 
    }

    if(result)
      printf("The result is: %d\n", result);
      
    return 0;
}
