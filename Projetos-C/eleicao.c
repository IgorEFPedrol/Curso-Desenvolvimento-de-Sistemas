#include <stdio.h>
#include <stdlib.h>
int main () {
	float branco, nulo, valido, total, porcentB, porcentN, porcentV;
	printf("Informe a quantia de votos brancos: ");
	scanf("%f", &branco);
	printf("Informe a quantia de votos nulos: ");
	scanf("%f", &nulo);
	printf("Informe a quantia de votos validos: ");
	scanf("%f", &valido);
	total = branco + nulo + valido; 
	porcentB = (branco *100)/total;
	porcentN = (nulo *100)/total;
	porcentV = (valido *100)/total;
	printf("A porcentagem de votos  brancos foi de: %.2f", porcentB);
	printf("\nA porcentagem de votos  nulos foi de: %.2f", porcentN);
	printf("\nA porcentagem de votos  validos foi de: %.2f", porcentV);
	getch();
}
