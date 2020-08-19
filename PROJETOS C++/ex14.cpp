#include <stdio.h>
//Ex14
int pos = 0;
int aux = 0;
int inverte(int tamanho, int vet[]){
	if (tamanho < pos){
		return vet[tamanho];
	}
	else{
		aux = vet[tamanho];
		vet[tamanho] = vet[pos];
		vet[pos] = aux;
		pos++;
		
		return inverte(tamanho-1, vet);		
	}
}
int main(){
	int tamanho = 0;
	printf("Digite o tamanho do vetor:\n");
	scanf("%d",&tamanho);
	int vet[tamanho];
	printf("-----Digite os numeros do vetor-----\n");
	for (int i = 0; i<tamanho; i++){
		printf("Digite o elemento %d\n",i);
		scanf("%d",&vet[i]);
	}
	
	printf("-----Vetor Original----- \n");
	
	for (int y = 0; y<tamanho; y++){
		printf("O vetor[%d] = %d\n",y,vet[y]);
	}
	
	printf("-----Vetor Invertido----- \n");
				
	inverte(tamanho-1, vet);
	
	for (int z = 0; z<tamanho; z++){
		printf("O vetor[%d] = %d\n",z,vet[z]);
	}
}
