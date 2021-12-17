#include<stdio.h>
#include<stdlib.h>
int main(){
	float p,a,imc;
	printf("Informe o peso:");
	scanf("%f",&p);
	printf("Informe a altura:");
	scanf("%f",&a);
	imc= p/(a*a);
	printf("O seu IMC vale:%f",imc);
	getch();
}
