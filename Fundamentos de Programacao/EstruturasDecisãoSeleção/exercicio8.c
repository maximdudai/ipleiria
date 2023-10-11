#include <stdio.h>
#include <stdlib.h>

int main() {

  printf("Insert your salary: ");

  int salary;
  scanf("%d", &salary);

  printf("Insert number of independents: ");
  int independents;
  scanf("%d", &independents);

  float salaryBonus, finalSalary;

  switch (salary)
  {

    case 600:
      salaryBonus = independents >= 2 ? 0.09 : 0.05;
      break;
    case 750:
      salaryBonus = independents >= 2 ? 0.07: 0.03;
      break;
    case 1000:
      salaryBonus = independents >= 2 ? 0.05 : 0.02;
      break;
  }

  finalSalary = salary * (1 + salaryBonus);

  printf("Final salary (including a bonus of %.2f%%): %.2f\n", (salaryBonus * 100), finalSalary);

  return 0;
}