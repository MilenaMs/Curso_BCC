#include<stdio.h>
#include<stdlib.h>
#include<string.h>
typedef struct _cliente{
	char nome[30];
	int idade;
} cliente;


typedef struct _lista {
	cliente info;
	struct _lista * prox;
} lista;


void inicializar(lista ** lst){
	*lst = NULL;
	
}

void inserirInicio(lista ** lst, cliente c){
	lista * aux;
	aux = (lista*) calloc(1, sizeof(lista)); //sizeof(lista) = tamanho da caixinha
	aux ->info = c; 
	aux ->prox = *lst;
	*lst = aux;
}

void mostrarPrimeiro(lista * l){
	printf("nome: %s\n", l->info.nome);
	printf("idade: %d\n", l->info.idade);
	printf("------------------------------------\n");
}

void mostrarTodos(lista * l){
	lista * aux = l;
	while(aux != NULL){
		printf("nome: %s\n", aux->info.nome);
		printf("idade: %d\n", aux->info.idade);
		aux = aux->prox;
}
}
void  eliminar(lista ** lst, int n){
	lista * aux = *lst;
	lista * excluir;
	printf("%d", n);
	if ((n==0)&&(aux != NULL)){
		*lst = aux->prox;
		free(aux);
	}
	else{
		for (int i=0; i!=n;i++){
			
			if((i+1==n)&&(aux!=NULL)){
				
				excluir = aux->prox;
				aux->prox=excluir->prox;
				free(excluir);
				break;
			}
			aux=aux->prox;

		}

	}
	
}
void destruir(lista ** lst){
	lista * aux = *lst;
	lista * excluir;
	while(aux!=NULL){
			excluir=aux;
			aux=aux->prox;
			free(excluir);
		}
		*lst = NULL;
}

void mostrarN(lista * l, int n){
			//  se n == 0, mostrar o primeiro 
			// 	se n == 1, mostrar o segundo  
		lista * aux = l;
		int i = 0;
		while(aux!= NULL){
			if(i==n){
				printf("nome: %s\n", aux->info.nome);
				printf("idade: %d\n", aux->info.idade);
			}
			aux = aux->prox;
			i+=1;		
		}		
}


cliente * acessar(lista * l, int n){
	lista * aux = l;
	int i;
	for(i=0;i<n;i++){
		if(aux==NULL) {
			 break;
		}
		aux = aux->prox;
	}
	if(aux!=NULL) {
		return &aux->info;
	}
	else {
		return NULL;
	}
}

int buscar(lista * lst, char nome[]){//posicão do nome
	int i=0;
	lista * aux = lst;

	while(aux!=NULL){
		if(strcmp(nome,aux->info.nome)==0){
			break;
		} else {
			aux = aux->prox;
			i++;
		}
	}
	if(aux==NULL) {
		return -1;
	}
	else {
		return i;
	}
}



int tamanho(lista * lst){
	int i = 0;
	lista * aux = lst;
	while(aux!=NULL){
		aux=aux->prox;
		i++;
	}
	
	return i;
}


void inserirPosicao(lista ** lst, int pos, cliente c){
	lista * aux = *lst;
	lista * aux2;
	int i = 0;
	if(pos == 0){
		inserirInicio(lst, c);
		}
	
	else{
		while (i != pos-1){
			aux = aux->prox;
			i+=1;	
		}
		if (aux != NULL){
			aux2 = (lista*) calloc(1, sizeof(lista));
			aux2->info = c; 
			aux2->prox = aux->prox;
			aux->prox=aux2;
		}
		else{
			printf("Posicao Invalida.\n");
		}
		}
	}
	
void inserirFinal(lista ** lst, cliente c){
	lista * aux = *lst;
	lista * auxfinal;
	if (aux == NULL){
		inserirInicio(lst, c);	
	}
	else{
	
		for (int i = 0; aux->prox != NULL ; i++){
			aux = aux->prox;
		}
		auxfinal = (lista*) calloc(1, sizeof(lista));
		auxfinal->info = c;
		auxfinal->prox = aux->prox;
		aux->prox = auxfinal;
		}
	}
	
void ordemIdade(lista ** l, cliente c){
	lista * aux = *l;
	lista * aux2;
	lista * auxAntes;
	for (int i = 0; aux != NULL; i++){
		if((c.idade>aux->info.idade)&&(aux->prox==NULL)){
			aux2 = (lista*) calloc (1,sizeof(lista));
			aux2->info = c;
			aux->prox=aux2;
			aux2->prox=NULL;
			break; 
		}
		if(c.idade<aux->info.idade){
			aux2 = (lista*) calloc (1,sizeof(lista));
			aux2->info = c;
			aux2->prox = aux;
			auxAntes->prox=aux2;	
			break;
			}
		else{
			auxAntes = aux;
			aux=aux->prox;
			
		}
	}
}

void inverter(lista ** l){
	lista * auxD;
	lista * aux = *l ;
	lista * auxA = NULL ;

	if (aux!=NULL){
		while(aux!=NULL){
			auxD = aux->prox;
			aux->prox = auxA;
			auxA = aux;
			if(auxD!=NULL){
				aux = auxD;
			}
			else{
				*l = aux;
				printf("Invertido\n");
				return;
			}
		}
	}
	else{
		printf("lista inexistente.\n");
		return;
	}
}	

int main(){
	lista * l;
	cliente c;
	cliente * pc;
	int pos;
	char nome[30];
	int idade;
	int op = -1;

	
	inicializar(&l);
	while(op != 0){

	printf("1 - Inserir no inicio\n");
	printf("2 - Inserir na Posicao\n");
	printf("3 - Inserir no final\n");
	printf("4 - Acessar cliente\n");
	printf("5 - Eliminar\n");
	printf("6 - Listar\n");
	printf("7 - Buscar\n");
	printf("8 - Ordem de idade\n");
	printf("9 - Inverter a lista");
	printf("0 - Sair\n");	
	scanf("%d", &op);
	if(op==1){
		printf("Digite o nome depois a idade:\n");
		scanf("%s",nome);
		strcpy(c.nome,nome);
		scanf("%d",&c.idade);
		inserirInicio(&l, c);
		printf("-------------\n");		
	}	
	else if(op==2){	
		printf("Digite a posicao que quer inserir:\n");
		scanf("%d",&pos);
		printf("Digite o nome depois a idade:\n");
		scanf("%s",nome);
		strcpy(c.nome,nome);
		scanf("%d",&c.idade);
		inserirPosicao(&l,pos,c);
		printf("-------------\n");


	}
	else if(op==3){
		printf("Digite o nome depois a idade:\n");
		scanf("%s",nome);
		strcpy(c.nome,nome);
		scanf("%d",&c.idade);
		inserirFinal(&l,c);	
		printf("-------------\n");
	}
	else if(op==4){
		printf("Digite a posicao que quer acessar: \n");
		scanf("%d",&pos);
		pc = acessar (l,pos);
		if(pc!=NULL){
		printf ("Nome: %s\n", pc->nome);
		printf ("Idade: %d\n", pc->idade);
	}
	else {
		printf("Nao Existe.");
	}
	printf("-------------\n");
	}
	else if(op==5){
		pos = 0;
		printf("Digite a posicao que quer eliminar: \n");
		scanf("%d",&pos);
		eliminar(&l,pos);
		printf("-------------\n");
	}
	else if(op==6){
		mostrarTodos(l);
		printf("-------------\n");
	}
	else if(op==7){
		printf("Digite o nome que quer buscar:\n");
		scanf("%s",nome);
		strcpy(c.nome,nome);
		pos = buscar(l,nome);
	printf("encontrou: %d\n",pos);
	
	if(pos>=0){
		pc = acessar(l,pos);
		if(pc!=NULL){
			printf("Nome: %s\n", pc->nome);
			printf("Idade: %d\n", pc->idade);
		}else{
			printf("nao existe\n");
		}
		printf("-------------\n");
	}
		
		}
	else if(op==8){
		printf("Digite o nome depois a idade:\n");
		scanf("%s",nome);
		strcpy(c.nome,nome);
		scanf("%d",&c.idade);
		ordemIdade(&l, c);
	}
	
	else if(op==9){
		inverter(&l);

	}
	
	}
	return 0;
}
