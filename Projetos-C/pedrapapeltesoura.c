#include <stdio.h>
#include <stdlib.h>
#include <time.h>
  int main(){
  	int opc, ale;
  	
  	printf("Escolha uma opcao: \n1 - Pedra\n2 - Papel\n3 - Tesoura\n");
  	scanf("%d",&opc);
  	
  	srand(time(NULL));
  	ale = (rand()%3)+1;
  	printf("O computador Jogou: %d\n", ale);
  	
	  if(opc == 1 && ale == 2){
  		printf("O vencedor foi o Computador!");
	  }
	  
	  else if(opc == 1 && ale == 3){
	  	printf("O vencedor foi o Usuario!");
	  }
	  
	  else if(opc == 2 && ale == 1){
	  	printf("O vencedor foi o Usuario!");
	  }
	  
	  else if(opc == 2 && ale == 3){
	  	printf("O vencedor foi o Computador!");
	  }
	  
	  else if(opc == 3 && ale == 2){
	  	printf("O vencedor foi o Usuario!");
	  }
	  
	  else if(opc == 3 && ale == 1){
	  	printf("O vencedor foi o Computador!");
	  }
	  
	  else{
	  	printf("Foi um Empate!");
	  }
	  return 0;
  }
