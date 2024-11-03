#include <stdio.h>
#include <stdlib.h>

// aloca�oes:
int i,j;
int* alocaint(int n){
   int* pi = (int*) malloc(sizeof(int));
   *pi = n;

   return pi;
}
float* alocafloat(float nf){
    float* pf = (float*) malloc(sizeof(float));
    *pf = nf;
    return pf;
    }
char* alocachar(char c){
char* pc = (char*) malloc(sizeof(char));
*pc = c;
return pc;
}
struct Pessoa* alocaPessoa(char pnome[30],int pidade){
   struct Pessoa* pp = (struct Pessoa*) malloc(sizeof(struct Pessoa));
   pp->nome = pnome;
   pp->idade = pidade;
   return pp;
}
