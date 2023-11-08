#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Indique um numero inteiro: ");

  int num;
  scanf("%d", &num);

  while(num <= 0) {
    printf("Indique um numero inteiro: ");
    scanf("%d", &num);
  }

  int for_num = 0, while_num = 0, dowhile_num = 0;

  // for method
  for(int i = 0; i <= num; i++) {
    for_num += i;
  }
  printf("(for) Final: %d\n", for_num);

  int while_final_number = 1;

  // while method
  while(while_final_number <= num) {
    while_num += while_final_number;
    while_final_number++;
  }
  printf("(while) Final: %d\n", while_num);


  // do while method
  int do_while_num = 0;
  do {
    dowhile_num += do_while_num;
    do_while_num++;
  }
  while(do_while_num <= num);

  printf("(do while) Final: %d\n", dowhile_num);


  return 0;
}