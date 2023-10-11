#include <stdio.h>

int main() {
    int num1, num2, num3;

    printf("Enter three numbers: ");
    scanf("%d %d %d", &num1, &num2, &num3);

    // Assuming num1 is the smallest
    int smallest = num1;
    int middle = num2;
    int largest = num3;

    if (num2 < num1 && num2 < num3) {
        smallest = num2;
        middle = num1;
        if (num3 < num1) {
            middle = num3;
            largest = num1;
        }
        else {
            largest = num3;
        }
    }
    else if (num3 < num1 && num3 < num2) {
        smallest = num3;
        middle = num1;
        if (num2 < num1) {
            middle = num2;
            largest = num1;
        }
        else {
            largest = num2;
        }
    }

    printf("Sorted numbers: %d, %d, %d\n", smallest, middle, largest);
    return 0;
}
