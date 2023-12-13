#include <string.h>
#include <stdlib.h>
#include <stdio.h>

char nome_maiuscula(char string[]);
int palavras_nome(char string[]);
char forma_nome(char string[]);

int main (void) {

  char nome_completo[256];
  printf("Digite seu nome completo: ");
  fgets(nome_completo, 256, stdin);

  printf("Nome completo: %s", nome_completo);
  printf("Iniciais do nome em maiusculo: %s", nome_maiuscula(nome_completo));


  return 0;
}

char nome_maiuscula(char string[]) {

  char string_maiuscula[256];

  return string_maiuscula;

}