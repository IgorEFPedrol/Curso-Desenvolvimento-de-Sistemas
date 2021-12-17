#include <stdio.h>
#include <stdlib.h>
int main() {
	int u, x, r;
	printf("\nEscolha um numero inteiro de 0 a 10: ");
	scanf("%d", & u);
	
	if(u < 0 || u>10) {
		printf("\nNUMERO INVALIDO");
	}	
	else {
	    printf("\nO usuario informou: %d", u);
		 
	    for(x=0; x<=10; x++) {
	 	    r= x * u;
	 	    printf("\n%d * %d = %d", x, u, r);
    	}
    	printf("\n");
    	for(x=10; x>=0; x--) {
    		r= x * u;
    		printf("\n%d * %d = %d", x, u, r);
		}
	}
	getch();
}
