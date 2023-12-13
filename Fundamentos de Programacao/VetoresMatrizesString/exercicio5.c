#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int mostrar_menu(void);
int numero_vogais(char string[]);
void inverter_string(char string[]);
void remover_espacos(char string[]);

int main (void) {

  char string[100];

  printf("Digite uma string: ");
  gets(string);
  scanf("%100[^\n]", string);

  printf("Sting digitada: %s", string);

  int opcao = mostrar_menu();

  switch(opcao) {

    case 1:
      printf("Numero de vogais: %d", numero_vogais(string));
      break;
    case 2:
      printf("String invertida: \n");
      inverter_string(string);
      printf("%s", string);
      break;

    case 3:
      printf("String sem espacos em branco: \n");
      remover_espacos(string);
      printf("%s", string);
      break;

    default:
      printf("Invalid option!");
  }

  return 0;
}

int mostrar_menu(void) {

  int opcao;

  printf("1 - Numero de vogais da string\n");
  printf("2 - A string invertida\n");
  printf("3 - A string sem espaços em branco\n");

  printf("Digite uma opcao: ");
  scanf("%d", &opcao);

  return opcao;
}

int numero_vogais(char string[]) {
  char vogais[10] = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

  int contadorVogais = 0;

  for (int i = 0; i < strlen(string); i++) {
    for (int v = 0; v < 10; v++) {
      if (string[i] == vogais[v]) {
        contadorVogais++;
        break;
      }
    }
  }

  return contadorVogais;
}

void inverter_string(char string[]) {
  int tamanho = strlen(string);
  char inverted_string[tamanho];

  for (int i = 0; i < tamanho; i++) {
    inverted_string[i] = string[tamanho - i - 1];
  }

  for (int i = 0; i < tamanho; i++) {
    string[i] = inverted_string[i];
  }
  
  string[tamanho] = '\0';
}

void remover_espacos(char string[]) {
  int i, j;

  for (i = 0, j = 0; string[i] != '\0'; i++) {
    if (string[i] != ' ') {
      string[j] = string[i];
      j++;
    }
  }

  string[j] = '\0';
}