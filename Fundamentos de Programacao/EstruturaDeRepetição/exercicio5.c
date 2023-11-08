#include <stdio.h>
#include <stdlib.h>

int main()
{
  int tamanhoLetra;

  printf("Tamanho da letra: ");
  scanf("%d", &tamanhoLetra);

  for (int linha = 1; linha <= tamanhoLetra; linha++)
  {
    for (int coluna = 1; coluna <= tamanhoLetra; coluna++)
    {
      if (coluna == 1 || coluna == tamanhoLetra || coluna == linha)
        printf("*");
      else
        printf(" ");
    }
    printf("\n");
  }
  return 0;
}