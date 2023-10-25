#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Insert the value of shopping items purchased: ");
  int shoppingItemsValue;
  scanf("%d", &shoppingItemsValue);

  float shoppingDiscount;

  if(shoppingItemsValue < 500)
    shoppingDiscount = 0;
  else if(shoppingItemsValue >= 500 && shoppingItemsValue <= 1250)
    shoppingDiscount = 0.04;
  else if(shoppingItemsValue >= 1250 && shoppingItemsValue <= 2000)
    shoppingDiscount = 0.06;
  else if(shoppingItemsValue > 2000)
    shoppingDiscount = 0.08;


  float finalPriceWithDiscount = shoppingItemsValue * (1 - shoppingDiscount);

  printf("\n\n- - - - Final price details - - - -");
  printf("\nFinal Price (with discount): %.2f", finalPriceWithDiscount);

  printf("\nDiscount: %.2f", shoppingDiscount);

  getchar();
  return 0;
}