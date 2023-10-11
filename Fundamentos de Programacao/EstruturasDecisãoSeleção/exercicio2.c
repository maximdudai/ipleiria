#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Insira o comprimento da primeira linha");
  int linha1;
  scanf("%d", &linha1);
  printf("Insira o comprimento da segunda linha");
  int linha2;
  scanf("%d", &linha2);
  printf("Insira o comprimento da terceira linha");
  int linha3;
  scanf("%d", &linha3);

  if(linha1 == linha2 && linha2 == linha3)
    printf("O triangulo e equilatero\n");
  if(linha1 == linha2 || linha2 == linha3 || linha1 == linha3)
    printf("O triangulo e escaleno\n");
  else
    printf("O triangulo e isosceles\n");

  getchar();
  return 0;
}