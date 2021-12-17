#include <stdio.h>
#include <stdlib.h>
int main () {
	float carroV, vv, sf, vcv,st;
	printf("Insira o total de carros vendidos: ");
	scanf("%f",&carroV);
	printf("Insira o valor total das vendas: ");
	scanf("%f",&vv);
	printf("Insira o seu salario fixo: ");
	scanf("%f",&sf);
	printf("Insira o valor por carro vendido: ");
	scanf("%f",&vcv);
	st = sf+(vcv*carroV)+(vv*0.05);
	printf("O seu salario total foi de : R$%.2f",st);
	getch();
}
