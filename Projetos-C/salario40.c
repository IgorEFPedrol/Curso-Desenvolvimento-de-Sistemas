#include <stdio.h>
#include <stdlib.h>
int main () {
	float ht, sph, sn, he, vhe, st;
	printf("Insira o total de horas trabalhadas: ");
	scanf("%f",&ht);
	printf("Insira quanto voce recebe por hora: ");
	scanf("%f",&sph);
	sn = 160 * sph;
	he = ht - 160;
    vhe = he * (sph*1.5);
	st = sn + vhe;
	printf("\nO seu salario final foi de: R$%.2f",st);
	getch();
}
