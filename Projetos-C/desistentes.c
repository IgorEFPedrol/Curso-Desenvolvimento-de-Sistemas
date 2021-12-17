#include <stdio.h>
#include <stdlib.h>
int main () {
	float am, desist, dispenLTT, dispenFI, porcentDesis, restante, porcentLTT, porcentFI;
	printf("Informe a quantia de alunos matriculados: ");
	scanf("%f", &am);
	printf("Informe a quantia de desistentes: ");
	scanf("%f", &desist);
	printf("Informe a quantia de alunos dispensados de LTT: ");
	scanf("%f", &dispenLTT);
	printf("Informe a quantia de alunos dispensados de FI: ");
	scanf("%f",&dispenFI);
	porcentDesis = (desist*100)/am;
	porcentLTT = (dispenLTT *100)/am;
	porcentFI = (dispenFI *100)/am;
	printf("A porcentagem de alunos desistentes foi de: %.2f", porcentDesis);
	printf("\nA porcentagem de alunos dispensados de LTT foi de: %.2f",porcentLTT);
	printf("\nA porcentagem de alunos dispensados de FI foi de: %.2f",porcentFI);
	getch();
}
