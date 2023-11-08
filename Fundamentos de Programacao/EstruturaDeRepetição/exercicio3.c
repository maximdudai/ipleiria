#include <stdio.h>

int main()
{
  int comprimento, total_saltos = 0, maior_salto = 0, menor_salto = 999;
  float media;
  int contador = 0;

  printf("Introduza os comprimentos de salto (introduza 0 para terminar):\n");

  while (comprimento > 0)
  {
    printf("Salto %d: ", contador + 1);
    scanf("%d", &comprimento);

    total_saltos += comprimento;

    if(comprimento > maior_salto)
      maior_salto = comprimento;

    if(comprimento < menor_salto)
      menor_salto = comprimento;

    contador++;
  }

  media = (float)total_saltos / contador;

  printf("\nResultados:\n");
  printf("saltos: %d\n", contador);
  printf("Maior: %d\n", maior_salto);
  printf("Menor: %d\n", menor_salto);
  printf("Média: %.2f\n", media);

  return 0;
}
