#include <stdio.h>
//Ex 10 Rescursiva  potencia
int pot (int x, int n){
	if (n==0){
		return 1;
	}
	else{

		return x * pot(x,n-1);
	}	
}

int main(){
	printf("%d\n",pot(5,2));
}

