#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Indique um numero");
  int num;
  scanf("%d", &num);

  if (num % 2 == 0) {
    printf("%d e par", num);
  } else {
    printf("%d e impar", num);
  }
  
  return 0;
}
