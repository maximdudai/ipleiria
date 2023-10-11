#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Indique um numero inteiro: ");

  int num;
  scanf("%d", &num);

  // if (num % 2 == 0) 
  if(!num) 
    printf("\nNumero nulo!");

  if(num)
    printf("\nNumero positivo!");
  else if(num < 0)
    printf("\nNumero negativo!");
  
  if(num % 2 == 0) 
    printf("\nNumero par!");
  else
    printf("\nNumero impar!");

  return 0;
}