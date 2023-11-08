#include <stdio.h>
#include <stdlib.h>

int main() {

  int tamanhoLetra = 0, contador = 0;

  do {

    printf("Tamanho da letra: ");
    scanf("%d", &tamanhoLetra);

  } while(tamanhoLetra < 0);

  // linha |
  // coluna -

  printf("-------- INICIO ------------\n");

  while(contador <= tamanhoLetra) {

    for(int linha = 1; linha <= tamanhoLetra; linha++) {

      for(int coluna = 1; coluna <= tamanhoLetra; coluna++) {

        if(coluna == 1 || coluna == tamanhoLetra || linha == tamanhoLetra - linha)
          printf("*");
        else
          printf("\n");
      }
    }
    contador ++;
  }

  printf("\n-------- FiM ------------");

  return 0;
}