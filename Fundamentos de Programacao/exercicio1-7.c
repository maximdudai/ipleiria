#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Insert limit of summing: \n");

  int limit;
  scanf("%d", &limit);

  int somWith = limit;
  int somResult = 0;

  for(int i = 1; i < somWith; i++) { 
    somResult = i *= 2;
  }

  printf("%d\n", somResult);
  
  return 0;
}