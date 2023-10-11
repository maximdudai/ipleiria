#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Insira o comprimento da primeira linha 1: ");
  int linha1;
  scanf("%d", &linha1);
  printf("Insira o comprimento da segunda linha 2: ");
  int linha2;
  scanf("%d", &linha2);
  printf("Insira o comprimento da terceira linha 3: ");
  int linha3;
  scanf("%d", &linha3);

  if(abs(linha1-linha2) < linha3 && linha3 < (linha1+linha2)) {
    if(linha1 == linha2 && linha1 == linha3) 
      printf("\nTriangulo Equilatero\n");
    if(linha1 != linha2 && linha1!= linha3 && linha2!= linha3)
      printf("\nTriangulo Escaleno\n");
    else
      printf("\nTriangulo Isosceles\n");
  }
  else 
    printf("Nao e possivel formar um triangulo");

  fflush(stdin);
  getchar();
  return 0;
}