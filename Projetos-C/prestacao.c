#include <stdio.h>
#include <stdlib.h>
int main () {
	float prestV, tpj, pa, jpa, vt; 
	printf("Insira o valor da prestacao vencida: ");
	scanf("%f",&prestV);
	printf("Insira a taxa periodica de juros: ");
	scanf("%f",&tpj);
	printf("Insira o periodo de atraso: ");
	scanf("%f",&pa);
	jpa = tpj*pa;
	vt = jpa+prestV;
	printf("O valor da prestacao atrasada foi de: R$%.2f",prestV);
	printf("\nO periodo de atraso foi de: %.1f dias", pa);
	printf("\nOs juros cobrados pelo periodo de atraso foi de: R$%.2f", jpa);
	printf("\nO valor total a pagar: R$%.2f", vt);
	getch();
}
