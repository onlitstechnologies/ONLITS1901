/*
	Lipsutz: Example 4.4 (a)
*/

#include<stdio.h>

int sales300(int[]);
void display(int[]);

int main()
{
	int AUTO[] = {152, 176, 305, 255, 365, 310, 156, 400, 202, 299, 189};
	printf("There are %d years in which more then 300 units were sold.\n", sales300(AUTO));
	display(AUTO);
	return 0;
}

int sales300(int A[])
{
	int num=0, k;
	
	for(k=0; k<10; k++)
	{
		if(A[k]>300)
		{
			num++;
		}
	}
	
	return num;
}

void display(int A[])
{
	int k;
	printf("%-10s%-10s\n","Year","Sales");
	printf("-----------------\n");
	for(k=0; k<10; k++)
	{
		printf("%-10d%-10d\n", k+1932, A[k]);
	}	
}
