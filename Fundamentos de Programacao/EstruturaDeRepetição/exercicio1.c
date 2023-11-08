#include <stdio.h>
#include <stdlib.h>

int main()
{

  char continuarCalculo;
  int num;

  do
  {
    printf("Indique um numero inteiro: ");

    scanf("%d", &num);

    // if (num % 2 == 0)
    if (!num)
      printf("\nNumero nulo!");

    if (num)
      printf("\nNumero positivo!");
    else if (num < 0)
      printf("\nNumero negativo!");

    if (num % 2 == 0)
      printf("\nNumero par!");
    else
      printf("\nNumero impar!");

    getchar();

    printf("Pretende continuar o calculo? (s/n): ");
    scanf(" %c", &continuarCalculo);

    fflush(stdin);

  } while (continuarCalculo == 's' || continuarCalculo == 'S');

  return 0;
}