#include <stdio.h>
//Ex12 contador de numeros
int cont(int num, int busc){
	if(num == 0){
		return 0;
	}
	else{
		if(num%10 == busc){
			printf("%d\n",num);
			return 1 + cont(num/10,busc);
		}
		else{
			return cont(num/10,busc);
		}
	}
}

int main(){
	int num = 0;
	int busc = 0;
	printf("Numero:");
	scanf("%d", &num);
	printf("Numero que será buscado: ");
	scanf("%d", &busc);	
	
	printf("As vezes que o numero apareceu: %d\n", cont(num,busc));
}
