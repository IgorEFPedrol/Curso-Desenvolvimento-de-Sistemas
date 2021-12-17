#include <stdio.h>
#include <stdlib.h>
int main () {
	float salario, pensao;
	printf("Informe o seu salario: ");
	scanf("%f", &salario);
	pensao = (salario*30)/100;
	printf("Voce pagara de pensao o total de: R$%.2f", pensao);
	getch();
}
