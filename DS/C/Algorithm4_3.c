/*
	Algorithm 4.2
	
*/
#include<stdio.h>

void delete(int la[], int *n, int k);
void display(int la[], int n);

int main()
{
	int la[10] = {23,4,12,58,99,100,200};
	int n=7, k=2; 
	
	printf("la before deleting is:\n");
	display(la, n);
	
	delete(la, &n, k);
	
	printf("la after deleting is:\n");
	display(la, n);
	
	k=1;
	
	delete(la, &n, k);
	
	printf("la after deleting second time is:\n");
	display(la, n);
	
	return 0;
}

void delete(int la[], int *n, int k)
{
	int j;
	int item = la[k];
	
	for(j=k; j <= *n-2; j++)			//To shift elements upwards
	{
		la[j] = la[j+1];
	}
	(*n)--;
}

void display(int la[], int n)
{
	int k;
	
	for(k=0; k<n; k++)
	{
		printf("%-5d%-5d\n", k, la[k]);
	}
}
