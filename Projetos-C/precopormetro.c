#include<stdio.h>
#include<stdlib.h>
int main(){
	float c,l,pm,vf,p;
	printf("Informe o comprimento:");
	scanf("%f",&c);
	printf("Informe a largura:");
	scanf("%f",&l);
	printf("Informe o preço por metro:");
	scanf("%f",&pm);
	p= (2*c)+(2*l);
	vf= p/pm;
	printf("O valor total foi de: %f",vf);
	getch();
}
