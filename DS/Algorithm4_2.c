/*
	Algorithm 4.2
	
*/
#include<stdio.h>

void insert(int la[], int *n, int k, int item);
void display(int la[], int n);

int main()
{
	int la[10] = {23,4,12,58};
	int n=4, k=2, item=100; 
	
	printf("la before inserting is:\n");
	display(la, n);
	
	insert(la, &n, k, item);
	
	printf("la after inserting is:\n");
	display(la, n);
	
	k=1;
	item=200;
	
	insert(la, &n, k, item);
	
	printf("la after inserting second time is:\n");
	display(la, n);
	
	return 0;
}

void insert(int la[], int *n, int k, int item)
{
	
	int j = *n-1;		//j is the last index
	
	while(j>=k)			//To shift elements downwards
	{
		la[j+1] = la[j];
		j--;
	}
	
	la[k] = item;
	(*n)++;
}

void display(int la[], int n)
{
	int k;
	
	for(k=0; k<n; k++)
	{
		printf("%-5d%-5d\n", k, la[k]);
	}
}
