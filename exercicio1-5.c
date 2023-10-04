#include <stdio.h>
#include <stdlib.h>

int main() {

  int num1, num2;

  printf("Include 2 number to define which is bigger: \n");

  scanf("%d", &num1);
  scanf("%d", &num2);

  if (num1 > num2) {
    printf("\n\n%d is bigger than %d.\n", num1, num2);
  } else {
    printf("\n\n%d is bigger than %d.\n", num2, num1);
  }

  return 0;
}