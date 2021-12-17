#include <stdio.h>
#include <stdlib.h>
#include <time.h>
   int main(){
   	char nomeU[30], nomeA[30];
   	int pct;
   	//nomeU = nome usuario, nomeA = nome pessoa Amada, pct = porcentagem 
   	
   	srand (time(NULL));
   	pct = (rand()%101);
	
	printf("-----Calculadora Amorosa-----\n"); 
	printf("\nEscreva o seu nome: ");
	scanf("%s",&nomeU);
	
	printf("\nEscreva o nome de quem voce ama: ");
	scanf("%s",nomeA);
	
	printf("\nA chance eh de: %d\n",pct);
	
	if(pct == 0){
		printf("\nSem chance!");
	}
	
	else if(pct < 50){
		printf("\nVoces nao combinam");
	}
	
	else if(pct > 50){
		printf("\nAcredita que vai!");
	}
	else if(pct > 75){
		printf("\nTem boas chances de dar certo!");
	}
	else if(pct == 100){
		printf("\nVcs sao Almas Gemeas!");
	}

  return 0;	
}
