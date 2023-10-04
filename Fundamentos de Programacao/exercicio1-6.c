#include <stdio.h>
#include <stdlib.h>

int main() {

  int somWith = 10;
  int somResult = 0;

  for(int i = 1; i < somWith; i++) { 
    somResult = i *= 2;
  }

  printf("%d\n", somResult);
  
  return 0;
}