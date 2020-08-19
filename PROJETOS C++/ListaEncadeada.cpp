#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct _cliente{
	char nome[30];
	int idade;
} cliente;

typedef struct _lista{
	cliente info;
	struct _lista * prox;
} lista;

void inicializar(lista ** lst){
	*lst = NULL;
}

void inserirInicio(lista ** lst, cliente c){
	lista * aux;
	aux = (lista*) calloc(1,sizeof(lista));
	aux->info = c;
	aux->prox = *lst;
	*lst = aux;
}

void mostrarPrimeiro(lista * l){
	printf("Nome: %s\n",l->info.nome);
	printf("Idade: %d\n",l->info.idade);
}

void mostrarTodos(lista * l){
	lista * aux=l;
	while(aux!=NULL){
		printf("Nome: %s\n",aux->info.nome);
		printf("Idade: %d\n",aux->info.idade);
		printf("-------------------------------\n");
		aux = aux->prox;
	}
}

void eliminar(lista ** lst, int n){
	int i;
	lista * aux = *lst;
	lista * excluir;
	
	if((n==0)&&(aux!=NULL)){
		*lst = aux->prox;
		free(aux);
	}
	else { 
		for(i=0;i<n-1;i++){
			aux = aux->prox;
			if(aux==NULL){
				break;
			}
		}
		if((aux!=NULL)&&(aux->prox!=NULL)){
			excluir = aux->prox;
			aux->prox = excluir->prox;
			free(excluir);
		}
	}
}

void destruir(lista ** lst){
	lista * aux = *lst;
	lista * excluir;
	
	while(aux!=NULL){
		excluir = aux;
		aux = aux->prox;
		free(excluir);
	}
	
	*lst = NULL;
}

void mostrarN(lista * l, int n){ 
	lista * aux = l;
	int i = 0;
	
	while(aux!=NULL){
		if(i==n){
			printf("Nome: %s\n",aux->info.nome);
			printf("Idade: %d\n",aux->info.idade);
			printf("-------------------------------\n");
		}
		aux = aux->prox;
		i+=1;
	}
}

void inserirPosicao(lista ** lst, int n, cliente c){
	lista * aux = *lst;
	lista * aux2;
	int i=0;
	if(n==0){
		inserirInicio(lst, c);
	}
	else{
		for(i=0;i<n-1;i++){
			aux = aux->prox;
		}
		if(aux!=NULL){
			aux2 = (lista *) calloc(1,sizeof(lista));
			aux2->info = c;
			aux2->prox = aux->prox;
			aux->prox = aux2;
		}
		else{
			printf("posicao invalida\n");
			printf("-------------------------------\n");
		}
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

int buscar(lista * lst, char nome[]){
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
	int i=0;
	lista * aux = lst;
	while(aux!=NULL){
		aux = aux->prox;
		i++;
	}
	return i;
}

void inserirFinal(lista ** lst, cliente c){
	lista * aux = *lst;
	lista * aux2;
	if(aux==NULL){
		inserirInicio(lst,c);
	}
	else {
		while(aux->prox!=NULL) {
			aux = aux->prox;
		}
		aux2 = (lista *) calloc(1,sizeof(lista));
		aux2->info = c;
		aux2->prox = aux->prox;
		aux->prox = aux2;
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
	int op;
	inicializar(&l);
	
	while(op != 0 ){
		printf("1 - Inserir no inicio\n");
		printf("2 - Inserir na posicao\n");
		printf("3 - Inserir no final\n");
		printf("4 - Acessar cliente\n");
		printf("5 - Eliminar\n");
		printf("6 - Listar\n");
		printf("7 - Buscar\n");
		printf("8 - Ordem de idade\n");
		printf("9 - Inverter a lista");
		printf("0 - Sair\n");
		scanf("%d",&op);
		
		if(op == 1){
			printf("Digite o nome:");
			scanf("%s", c.nome);
			printf("Digite a idade:");
			scanf("%d",&c.idade);
			inserirInicio(&l,c);			
		}
		else if(op ==2){
			printf("Digite a posicao desejada:");
			scanf("%d",&pos);
			printf("Digite o nome:");
			scanf("%s", c.nome);
			printf("Digite a idade:");
			scanf("%d",&c.idade);
			inserirPosicao(&l,pos,c);				
		}
		else if(op == 3){
			printf("Digite o nome:");
			scanf("%s", c.nome);
			printf("Digite a idade:");
			scanf("%d",&c.idade);
			inserirFinal(&l,c);
		}
		else if(op == 4){
			printf("Qual posicao deseja acessar?\n");
			scanf("%d",&pos);
			pc = acessar(l,pos);
				if(pc!=NULL){
					printf("Nome: %s\n", pc->nome);
					printf("Idade: %d\n", pc->idade);
				}else{
					printf("nao existe\n");
					}
		}
		else if(op == 5){
			printf("Qual posicao deseja eliminar?\n");
			scanf("%d",&pos);
			eliminar(&l,pos);
		}
		else if(op == 6){
			if(l==NULL)
			{
				printf("A lista esta vazia\n");
				
			}else
			{
				mostrarTodos(l);
			}
	}
		else if(op==7){
			nome [30];
			printf("Digite o nome a ser procurado: ");
			scanf("%s",nome);
			if (buscar(l,nome)==-1){
				printf("Nao encontrado\n");
			}else{
				printf("Esta na posicao %d\n",buscar(l,nome));
			}
			;
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
	

	printf("FIM");
	return 0;
	}
}


