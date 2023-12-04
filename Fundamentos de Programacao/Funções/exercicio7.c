#include <stdio.h>
#include <stdlib.h>

#define PRECO_GASOLINA 1.85
#define PRECO_GASOLEO 1.80
#define PRECO_GPL 0.93

float obter_distancia_percorrida(void);
float obter_valor_dispendido(void);
int obter_tipo_combustivel(void);
float obter_preco_litro(int);
float calcular_litros_gastos(float, float);
float calcular_consumo_medio(float, float);

char obter_opcao_menu(void);

int main()
{
  char opcao;
  float total_kms = 0, total_litros = 0;
  float num_kms, valos_gasto, preco_litro, litros_gasto_percurso;
  int tipo_combustivel;

  do {

    switch (opcao)
    {
      case 'I':
      case 'i':
        num_kms = obter_distancia_percorrida();
        total_kms += num_kms;
        valos_gasto = obter_valor_dispendido();
        tipo_combustivel = obter_tipo_combustivel();
        preco_litro += obter_preco_litro(tipo_combustivel);

        litros_gasto_percurso = calcular_litros_gastos(valos_gasto, preco_litro);
        total_litros += calcular_litros_gastos(valos_gasto, preco_litro);

        printf("Percurso introduzido!\n");

        fflush(stdin);
        getchar();
        break;

      case 'C':
      case 'c':
        if(total_kms == 0 && total_litros == 0)
          printf("Percurso nao registado!\n");
        else
          printf("Consumo medio: %.2f\n", calcular_consumo_medio(total_kms, total_litros));
  
        fflush(stdin);
        getchar();
        break;

    default:
      break;
    }

    opcao = obter_opcao_menu();
  }
  while(opcao != 'T' && opcao != 't');

  obter_opcao_menu();
  return 0;
}

float obter_distancia_percorrida(void)
{
  float distancia;
  do
  {
    printf("Distancia percorrida: ");
    scanf("%f", &distancia);
    if (distancia <= 0)
    {
      printf("Distancia invalida!\n");
    }
  } while (distancia <= 0);

  return distancia;
}
float obter_valor_dispendido(void)
{
  float valor_final;
  do
  {
    printf("Valor dispendido: ");
    scanf("%f", &valor_final);
    if (valor_final <= 0)
    {
      printf("Valor invalido!\n");
    }
  } while (valor_final <= 0);

  return valor_final;
}
int obter_tipo_combustivel(void)
{
  int tipo;
  do
  {
    printf("Tipo de combustivel (1 - Gasolina, 2 - Gasoleo, 3 - GPL): ");
    scanf("%d", &tipo);

  } while (tipo < 1 || tipo > 3);

  return tipo;
}
float obter_preco_litro(int tipo)
{
  float preco = 0;

  switch (tipo)
  {
  case 1:
    preco = PRECO_GASOLINA;
    break;
  case 2:
    preco = PRECO_GASOLEO;
    break;
  case 3:
    preco = PRECO_GPL;
    break;

  default:
    printf("Tipo de combustivel invalido!\n");
  }

  return preco;
}
float calcular_litros_gastos(float valor_gasto, float preco_litro)
{
  float litros_gastos;

  litros_gastos = valor_gasto / preco_litro;

  return litros_gastos;
}
float calcular_consumo_medio(float distancia_percorrida, float litros_gastos)
{

  float consumo_medio;

  consumo_medio = (litros_gastos * 100) / distancia_percorrida;

  return consumo_medio;
}

char obter_opcao_menu(void)
{
  char opcao;

  int tipo;

  do
  {
    system("cls");
    printf("-------------------------- Menu --------------------------\n");
    printf("(I) ntroduzir percurso\n");
    printf("(C) onsumo medio\n");
    printf("(T) erminar\n");
    printf("Opcao: ");
    scanf(" %c", &opcao);
  } while (opcao != 'I' && opcao != 'i' && opcao != 'C' && opcao != 'c' && opcao != 'T' && opcao != 't');

  switch (opcao)
  {
  case 'I':
  case 'i':

    distancia = obter_distancia_percorrida();
    valor = obter_valor_dispendido();

    printf("\n");
    printf("Distancia: %.2f\n", distancia);
    printf("Valor: %.2f\n", valor);

    printf("Percurso introduzido!\n");

    obter_opcao_menu();
    break;

  case 'C':
  case 'c':

    if (!distancia && !valor)
    {
      printf("Percurso nao registado!\n");
    }
    else
    {
      printf("\n");
      printf("Distancia: %.2f KM\n", distancia);
      printf("Valor: $%.2f\n", valor);
      printf("\n");

      tipo = obter_tipo_combustivel();
      preco = obter_preco_litro(tipo);

      litros = calcular_litros_gastos(valor, preco);
      consumo = calcular_consumo_medio(distancia, litros);

      printf("Consumo medio: %.2f\n", consumo);
    }

    break;

  case 'T':
  case 't':

    printf("A terminar...\n");
    break;
  }
}