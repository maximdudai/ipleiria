#include <stdio.h>
#include <stdlib.h>

#define PESO_PROVA_ESCRITA1 0.5
#define PESO_PROVA_ESCRITA2 0.5

#define PESO_TP 0.5
#define PESO_PL 0.5

#define PESO_PROVA_ENTREGA1 0.6
#define PESO_PROVA_ENTREGA2 0.4


int main() {

  float nota_escrita1, nota_escrita2, nota_entrega1, nota_entrega2;

  float nota_final_escrita, nota_final_entrega, nota_final;

  printf("Classificacao Prova Escrita 1 [0:20]\n");

  printf("Digite a nota da prova escrita 1 (50%%): ");
  scanf("%f", &nota_escrita1);
  printf("Digite a nota da prova escrita 2 (50%%): ");
  scanf("%f", &nota_escrita2);
  printf("Digite a nota da prova entrega 1 (60%%): ");
  scanf("%f", &nota_entrega1);
  printf("Digite a nota da prova entrega 2 (40%%): ");
  scanf("%f", &nota_entrega2);
  
  nota_final_escrita = (nota_escrita1 * PESO_PROVA_ESCRITA1) + (nota_escrita2 * PESO_PROVA_ESCRITA2);
  nota_final_entrega = (nota_entrega1 * PESO_PROVA_ENTREGA1) + (nota_entrega2 * PESO_PROVA_ENTREGA2);

  nota_final = (nota_final_escrita * PESO_TP) + (nota_final_entrega * PESO_PL);

  printf("\n\nEpoca de avaliacao periodica\n\n");

  printf("\nComponente TP: %.2f", nota_final_escrita);
  printf("\nComponente PL: %.2f", nota_final_entrega);
  printf("\nClassificacao final (0:20): %.2f (%.0f VALORES)\n\n", nota_final, nota_final);


  fflush(stdin);
  getchar();


  return 0;
}
