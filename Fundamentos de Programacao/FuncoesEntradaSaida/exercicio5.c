#include <stdio.h>
#include <stdlib.h>

int main() {

    printf("Please enter the first number: ");

    float first;
    scanf("%f", &first);

    printf("Please enter the second number: ");
    float second;
    scanf("%f", &second);

    float sumNumber = first + second;
    printf("\nThe sum of the two numbers is %.2f", sumNumber);

    float subNumber = first - second;
    printf("\nThe subtraction of the two numbers is %.2f", subNumber);

    float multNumber = first * second;
    printf("\nThe multiplication of the two numbers is %.2f", multNumber);

    float divNumber = first / second;
    printf("\nThe division of the two numbers is %.2f", divNumber);

    int percentNumber = (int)first % (int)second;
    printf("\nThe remainder of the division of the two numbers is %d", percentNumber);

    return 0;
}
