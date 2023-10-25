#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Insert your category: ");

  int category;
  scanf("%d", &category);

  printf("Insert number of independents: ");
  int independents;

  scanf("%d", &independents);
  float salaryBonus, finalSalary;

  finalSalary = category == 1 ? 600 : category == 2 ? 750 : 1000;

  printf("\nsalary bonus: %d\n category: %d\n", salaryBonus, category);


  switch (category)
  {
    case 1:
      salaryBonus = independents >= 2 ? 0.09 : 0.05;
      break;
    case 2:
      salaryBonus = independents >= 2 ? 0.07: 0.03;
      break;
    case 3:
      salaryBonus = independents >= 2 ? 0.05 : 0.02;
      break;
  }

  finalSalary += salaryBonus * (100 + salaryBonus);

  printf("Final salary by category (including a bonus of %.2f%%): %.2f\n", (salaryBonus * 100), finalSalary);

  return 0;
}