#include <stdio.h>
#include <stdlib.h>
int main () {
	float am, desist, dispenLTT, dispenFI, porcentDesis, rest, porcentLTT, porcentFI;
	printf("Informe a quantia de alunos matriculados: ");
	scanf("%f", &am);
	printf("Informe a quantia de desistentes: ");
	scanf("%f", &desist);
	printf("Informe a quantia de alunos dispensados de LTT: ");
	scanf("%f", &dispenLTT);
	printf("Informe a quantia de alunos dispensados de FI: ");
	scanf("%f",&dispenFI);
	rest = am - desist;
	porcentDesis = (desist*100)/am;
	porcentLTT = am - ((dispenLTT *100)/rest);
	porcentFI = am - ((dispenFI *100)/rest);
	printf("A porcentagem de alunos desistentes foi de: %.2f", porcentDesis);
	printf("\nA porcentagem de alunos que nao frequentam a aula de LTT: %.2f",porcentLTT);
	printf("\nA porcentagem de alunos que nao frequentam a aula de FI: %.2f",porcentFI);
	getch();
}

