#include <stdio.h>
#include <stdlib.h>

int main() {

    printf("Please insert the number of cars sold: ");

    int carsSold;
    scanf("%d", &carsSold);

    int volumeInvoicedSales;
    printf("Please enter the volume of the invoiced sales: ");
    scanf("%d", &volumeInvoicedSales);

    printf("\n\nSALARY DETAILS:\n");

    int basicSalary = 600;
    int sellBonus = 100;
    float invoicedSales = 1.50 / 100;

    printf("Basic salary: %d\n", basicSalary);

    int bonusForSold = sellBonus * carsSold;
    printf("For every solded car: %d\n", bonusForSold);

    float totalInvoicedSales = invoicedSales * volumeInvoicedSales;
    printf("1.5%% of the invoiced sales: %.2f\n\n", totalInvoicedSales);

    printf("\t\t------------------");

    float finalSalary = basicSalary + bonusForSold + totalInvoicedSales;
    printf("\nFinal salary: %.2f\n\n", finalSalary);

    return 0;
}
