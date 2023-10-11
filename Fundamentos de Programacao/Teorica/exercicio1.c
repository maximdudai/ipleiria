#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Indique um numero ");
  int num;
  scanf("%d", &num);

  switch (num)
  {
    default:
      printf("Invalido");
    case 0:
      printf("0"); break;

    case 1:
      printf("1"); break;
  }  
  return 0;
}
