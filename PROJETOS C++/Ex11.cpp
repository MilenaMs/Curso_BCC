#include <stdio.h>
//Ex11 Recursiva somar todos os numeros de um vetor
int soma (int vet[], int n){
	if(n==0){
		return 0;
	}
	else{
		return vet[n] + soma (vet,n-1); 
	}
}

int main(){
	int vet[10] = {1,2,3,4,5,6,7,8,9,10};
	printf("%d\n", soma(vet,10));
}
