#include <stdio.h>
#include <stdlib.h>

int main() {

    printf("Please enter the first number: ");

    int first;
    scanf("%d", &first);

    printf("Please enter the second number: ");
    int second;
    scanf("%d", &second);

    printf("Please enter the operation: ");
    char operation;
    scanf(" %c", &operation);

    int somNumber, subNumber, multNumber, divNumber;

    switch (operation)
    {
      case '+':
        somNumber = first + second;
        printf("\nThe sum of the two numbers is %d", somNumber);
        break;
      case '-':
        subNumber = first - second;
        printf("\nThe substraction of the two number is %d", subNumber);
        break;

      case '*':
        if(first == 0 || second == 0)
          return printf("Erro – Divisão por zero");
          
        multNumber = first * second;
        printf("\nThe multiplication of the two number is %d", multNumber);
        break;

      case '/':
        divNumber = first / second;
        printf("\nThe division of the two number is %d", divNumber);
        break;
      default:
        printf("Invalid operation\n");
    }

    return 0;
}
