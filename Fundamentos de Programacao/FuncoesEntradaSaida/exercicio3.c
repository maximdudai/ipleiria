#include <stdio.h>
#include <stdlib.h>


int main() {

  printf("Please insert a number for convert (ex: 123.456): ");

  float number;
  scanf("%f", &number);

  printf("\n\nAligned to left: %f\n", number);
  printf("With signal +: %+f\n", number);
  printf("Aligned to right: %10.3f\n", number);
  printf("Aligned to right: %010.3f\n", number);
  return 0;
}