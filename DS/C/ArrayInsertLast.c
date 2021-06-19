/*
	Program to insert an element at the end of array
*/


#include<stdio.h>

void display(int[], int);

int main()
{
	int no[50] = {152, 176, 305, 255, 365, 310, 156, 400, 202, 299, 189};	//Hardcoded
	int size=11;
	char ch='n';
	
	do
	{
		printf("Please enter a number to insert in array: ");
		scanf("%d", &no[size]);
		size++;
		printf("Do you want to enter another one (y/n): ");
		getchar();
		scanf("%c", &ch);
	}
	while(ch=='y');
	
	display(no, size);
	return 0;
}




void display(int n[], int s)
{
	int k;
	printf("%-10s%-10s\n","Year","Sales");
	printf("-----------------\n");
	for(k=0; k<s; k++)
	{
		printf("%-10d%-10d\n", k, n[k]);
	}	
}
