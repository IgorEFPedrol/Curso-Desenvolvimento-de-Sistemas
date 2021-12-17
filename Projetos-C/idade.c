#include<stdio.h>
#include<stdlib.h>
int main(){
	int a1, a2, i, di;
	printf("Informe o ano atual:");
	scanf("%d, & a1");
	printf("Informe seu ano de nascimento:");
	scanf("%d, & a2");
	i= a1-a2;
	di= i*365;
	printf("Você tem %d anos e viveu %d dias", i, di);
	getch();
}
