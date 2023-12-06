#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_QUARTOS 10
#define IS_OCUPED 10

char hostel_menu(void);

char ocupar_quarto(int quartos[MAX_QUARTOS]);
char *isRoomOcupated(int quartos[MAX_QUARTOS], int quarto);

int menu_principal(void);
int inicializar_quartos(int quartos[]);
char estado_quarto(int quartos[]);
int conta_quartos_estado(int quartos[]);

int main()
{
  char opcao_menu;
  int quartos[MAX_QUARTOS];

  opcao_menu = hostel_menu();

  do
  {
    switch (opcao_menu)
    {
    case 'O':
    case 'o':
      ocupar_quarto(quartos);
      break;

    case 'D':
    case 'd':
      ocupar_quarto(quartos);
      break;

    case 'V':
    case 'v':
      estado_quarto(quartos);
      break;

    case 'S':
    case 's':
      printf("Sair\n");
      break;

    default:
      printf("Opcao invalida!\n");
      break;
    }

    opcao_menu = hostel_menu();

  } while (opcao_menu != 'S' && opcao_menu != 's');

  return 0;
}

// return a string depend on room ocuped state
char *isRoomOcupated(int quartos[], int quarto_id)
{
  char isOcupated[8];

  char *finalOcuped = !quartos[quarto_id] ? "Ocupado" : "Livre";
  strcpy(isOcupated, finalOcuped);

  return isOcupated;
}

// modify room ocuped state
char ocupar_quarto(int quartos[])
{
  int ocupar_quarto_id;

  printf("Quartos disponíveis:\n");
  for (int i = 1; i <= MAX_QUARTOS; i++)
    printf("Quarto: %d - Estado: %s\n", i, isRoomOcupated(quartos, i));

  printf("\n\nIndique o quarto a ocupar: ");
  scanf("%d", &ocupar_quarto_id);
  quartos[ocupar_quarto_id] = quartos[ocupar_quarto_id] == 1 ? 0 : 1;

  printf("Quarto (#%d) está neste momento: %s", ocupar_quarto_id, isRoomOcupated(quartos, ocupar_quarto_id));

  return 0;
}

char hostel_menu(void)
{

  char opcao_menu;

  printf("\n\nHostel Menu:\n");
  printf("(O)cupar quarto\n");
  printf("(D)esocupar quarto\n");
  printf("(V)er estado dos quartos\n");
  printf("(S)air\n");

  do
  {
    printf("\n\nIndique a opcao do Hostel: ");
    fflush(stdin);
    scanf("%c", &opcao_menu);
  } while (opcao_menu != 'O' && opcao_menu != 'D' && opcao_menu != 'V' && opcao_menu != 'S' && opcao_menu != 'o' && opcao_menu != 'd' && opcao_menu != 'v' && opcao_menu != 's');

  return opcao_menu;
}

int inicializar_quartos(int quartos[])
{
  int init = 0;

  do
  {
    printf("\nIndique como quer inicializar o estado dos quartos (0 = livre | 1 = ocupado)");
    scanf("%d", &init);
  } while (init < 0 || init > 1);

  for (int i = 1; i < MAX_QUARTOS; i++)
    quartos[i] = init;

  printf("Estado dos quartos atualizado com sucesso!");

  return 0;
}
char estado_quarto(int quartos[])
{

  int menu_principal_opcao;

  printf("\nQuartos disponíveis:\n");
  for (int i = 1; i <= MAX_QUARTOS; i++)
    printf("Quarto: %d - Estado: %s\n", i, isRoomOcupated(quartos, i));

  // do
  // {
  //   menu_principal_opcao = menu_principal();

  //   switch (menu_principal_opcao)
  //   {
  //   case 'b':
  //   {
  //     inicializar_quartos(quartos);
  //     break;
  //   }
  //   case 'c':
  //   {
  //     estado_quarto(quartos);
  //     break;
  //   }

  //   case 'd':
  //   {
  //     conta_quartos_estado(quartos);
  //     break;
  //   }

  //   default:
  //     break;
  //   }
  // } while (
  //     menu_principal_opcao != 'B' && menu_principal_opcao != 'b' &&
  //     menu_principal_opcao != 'C' && menu_principal_opcao != 'c' &&
  //     menu_principal_opcao != 'D' && menu_principal_opcao != 'd');

  return 0;
}
int conta_quartos_estado(int quartos[])
{

  int ocupados = 0, livres = 0;

  for (int i = 1; i <= MAX_QUARTOS; i++)
    !quartos[i] ? ocupados++ : livres++;

  printf("Total Quartos Ocupados: %d", ocupados);
  printf("Total Quartos livres: %d", livres);

  return 0;
}

int menu_principal(void)
{

  int opcao;

  return opcao;
}