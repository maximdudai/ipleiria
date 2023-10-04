#include <stdio.h>
#include <stdlib.h>

int main() {

    printf("Please enter the first number: ");

    float first;
    scanf("%f", &first);

    printf("Please enter the second number: ");
    float second;
    scanf("%f", &second);

    float somNumber = first + second;
    printf("\nThe sum of the two numbers is %.3f", somNumber);

    float subNumber = first - second;
    printf("\nThe substraction of the two number is %.3f", subNumber);

    float multNumber = first * second;
    printf("\nThe multiplication of the two number is %.3f", multNumber);

    float divNumber = first / second;
    printf("\nThe division of the two number is %.3f", divNumber);

    int percentNumber = (int)first % (int)second;
    printf("\nThe division of the two number is %d", percentNumber);



    return 0;
}
