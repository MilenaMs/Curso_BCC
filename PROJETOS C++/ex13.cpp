#include <stdio.h>
//Ex13
int mdc(int p, int s)
{
   if ( p == s ) {
   return p;
   }
   if ( p < s ){
   return mdc(s, p);
   }
   return mdc(p-s,s);
}
int main(){
	int primeiro = 0;
	int segundo = 0;
	printf("Digite os dois numeros a serem calculados o MDC:\n");
	printf("1:");
	scanf("%d", &primeiro);
	printf("2:");
	scanf("%d", &segundo);
	printf("O MDC de %d e %d = %d",primeiro,segundo,mdc(primeiro,segundo));

}
