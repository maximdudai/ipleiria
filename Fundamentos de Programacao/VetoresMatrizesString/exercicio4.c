#include <stdio.h>

// Função para imprimir a matriz
void imprimirMatriz(int matriz[10][10]) {
    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 10; j++) {
            printf("%d\t", matriz[i][j]);
        }
        printf("\n");
    }
}

// Função para pesquisar o valor X na matriz
void pesquisarValor(int matriz[10][10], int valor) {
    int encontrado = 0;
    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 10; j++) {
            if (matriz[i][j] == valor) {
                printf("Valor encontrado! Localização: Linha %d, Coluna %d\n", i + 1, j + 1);
                encontrado = 1;
                break;
            }
        }
    }

    if (!encontrado) {
        printf("Valor não encontrado!\n");
    }
}

int main() {
    int matriz[10][10];

    // Inicializar a matriz com uma estrutura de repetição
    int valor = 1;
    for (int i = 0; i < 10; i++) {
        for (int j = 0; j < 10; j++) {
            matriz[i][j] = valor++;
        }
    }

    // Imprimir a matriz
    printf("Matriz:\n");
    imprimirMatriz(matriz);

    // Ler o valor X
    int valorX;
    printf("Digite o valor a ser pesquisado (X): ");
    scanf("%d", &valorX);

    // Pesquisar o valor na matriz
    pesquisarValor(matriz, valorX);

    return 0;
}
