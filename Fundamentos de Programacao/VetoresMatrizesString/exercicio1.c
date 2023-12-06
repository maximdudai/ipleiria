#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_ALUNOS 60
#define MIN_NOTA 10

int ler_numero(void);
int ler_notas_alunos(int aluno);
int mostrar_notas_alunos(int total_notas[MAX_ALUNOS], int size);
int calcular_media_notas(int notas[MAX_ALUNOS], int size);
int calcular_nota_alta(int notas[MAX_ALUNOS], int size);
int calcular_nota_baixa(int notas[MAX_ALUNOS], int size);
int calcular_notas_positivas(int notas[MAX_ALUNOS], int size);
int calcular_notas_negativas(int notas[MAX_ALUNOS], int size);
int calcular_nota_alta_baixa(int notas[MAX_ALUNOS], int size);
int mostrar_menu(void);

int main()
{

  int opcao_menu;
  int total_estudantes;
  int notas[MAX_ALUNOS], nota_aluno = 0, numero_total_notas = 1;

  total_estudantes = ler_numero();

  do
  {
    opcao_menu = mostrar_menu();
  
    switch (opcao_menu)
    {
    case 1: // Registrar notas dos alunos
      do
      {
        nota_aluno = ler_notas_alunos(numero_total_notas);

        notas[numero_total_notas] = nota_aluno;

        numero_total_notas++;

      } while (numero_total_notas <= total_estudantes);

      break;

    case 2: // mostras notas
    {
      if (numero_total_notas < total_estudantes)
      {
        printf("Não existem notas!");
        break;
      }

      mostrar_notas_alunos(notas, total_estudantes);
      break;
    }
    case 3: // Mostras Media das Notas
    {
      if (numero_total_notas < total_estudantes)
      {
        printf("Não existem notas!");
        break;
      }

      calcular_media_notas(notas, total_estudantes);
      break;
    }
    case 4: // Mostras notas positivas
    {
      if (numero_total_notas < total_estudantes)
      {
        printf("Não existem notas!");
        break;
      }

      calcular_notas_positivas(notas, total_estudantes);
      break;
    }
    case 5: // Mostrar notas negativas
    {
      if (numero_total_notas < total_estudantes)
      {
        printf("Não existem notas!");
        break;
      }

      calcular_notas_negativas(notas, total_estudantes);
      break;
    }
    case 6: // Mostrar nota mais alta e nota mais baixa
    {
      if (numero_total_notas < total_estudantes)
      {
        printf("Não existem notas!");
        break;
      }

      calcular_nota_alta_baixa(notas, total_estudantes);
      break;
    }
    default:
      printf("Menu Exit!");
      break;
    }

  } while (opcao_menu != 0 || opcao_menu > 6);

  return 0;
}

int ler_numero(void)
{
  int numero;
  do
  {
    printf("\n\nIndique o numero de estudantes: ");
    scanf("%d", &numero);

  } while (!numero || numero > MAX_ALUNOS);

  return numero;
}

int ler_notas_alunos(int aluno)
{
  int nota_aluno;

  do
  {
    printf("Indique a nota do aluno %d: ", aluno);
    scanf("%d", &nota_aluno);

  } while (nota_aluno < 0 || nota_aluno > 20);

  return nota_aluno;
};

int mostrar_notas_alunos(int total_notas[MAX_ALUNOS], int size)
{
  printf("\n\n------------- N O T A S -------------\n");

  for (int i = 0; i < size; i++)
  {
    printf("Nota do aluno %d: %d\n", i, total_notas[i]);
  }
  return 0;
};

int calcular_notas_positivas(int total_notas[MAX_ALUNOS], int size)
{

  for (int i = 0; i < size; i++)
  {
    if (total_notas[i] >= MIN_NOTA)
    {
      printf("Nota do aluno %d: %d\n", i, total_notas[i]);
    }
  }

  return 0;
};

int calcular_notas_negativas(int total_notas[MAX_ALUNOS], int size)
{

  for (int i = 0; i < size; i++)
  {
    if (total_notas[i] < MIN_NOTA)
    {
      printf("Nota do aluno %d: %d\n", i, total_notas[i]);
    }
  }

  return 0;
};

int calcular_media_notas(int notas[MAX_ALUNOS], int size)
{

  int total_notas = 0;

  for (int i = 0; i < size; i++)
  {
    total_notas += notas[i];
  }

  printf("Media das notas: %d", total_notas / MAX_ALUNOS);

  return 0;
};

int calcular_nota_alta_baixa(int notas[MAX_ALUNOS], int size)
{

  int nota_alta = 0, nota_baixa = 0;

  for (int i = 0; i < size; i++)
  {
    if (notas[i] > nota_alta)
    {
      nota_alta = notas[i];
    }

    if (notas[i] < nota_baixa)
    {
      nota_baixa = notas[i];
    }
  }

  printf("Nota mais alta: %d\n", nota_alta);
  printf("Nota mais baixa: %d\n", nota_baixa);

  return 0;
};

int mostrar_menu(void)
{

  int opcao;

  printf("\n\n------------- M E N U -------------\n");
  printf("1 - Registrar notas dos alunos\n");
  printf("2 - Mostrar notas dos alunos\n");
  printf("3 - Calcular media das notas\n");
  printf("4 - Mostras notas positivas\n");
  printf("5 - Mostrar notas negativas\n");
  printf("6 - Mostrar nota mais alta e mais baixa\n");
  printf("0 - Sair\n");
  printf("-----------------------------------\n");

  do
  {
    printf("Indique a opcao desejada: ");
    scanf("%d", &opcao);
  } while (opcao < 0 || opcao > 6);

  return opcao;
}