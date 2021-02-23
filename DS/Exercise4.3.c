#include<stdio.h>

#define SIZE 25

void sum25(int x[]);
int even(int x[]);
int odd(int x[]);

int main()
{
	int a[] = {10,11,8,9,15,2,1,6,8,14,0,25,23,2,56,74,1,2,3,6,18,7,6,5,44};
	int evnum, odnum;
	printf("Number pairs whose sum is 25:\n");
	sum25(a);
	evnum = even(a);
	odnum = odd(a);
	printf("Number of even numbers in a: %d\n", evnum);
	printf("Number of odd numbers in a: %d\n", odnum);	
}

void sum25(int x[])
{
	int i, j;
	
	for(i=0; i<SIZE-1; i++)
	{
		for(j=i+1; j<SIZE; j++)
		{
			if(x[i] + x[j] == 25)
				printf("[%d,%d]\n", x[i],x[j]);
		}
	}
}

int even(int x[])
{
	int i, evnum=0;
	for(i=0; i<SIZE; i++)
	{
		if(x[i] % 2 == 0)
			evnum++;
	}
	return evnum;
}

int odd(int x[])
{
	int i, odnum=0;
	for(i=0; i<SIZE; i++)
	{
		if(x[i] % 2 != 0)
			odnum++;
	}
	return odnum;
}


/*
	POP is a type of structured programming
	
	CASE tools: Computer Aided Software Engineering
*/
