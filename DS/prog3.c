//Program to add two integers using array

#include<stdio.h>

int main()
{
	int no[3];

	printf("Please enter a number: ");
	scanf("%d",&no[0]);

	printf("Please enter another number: ");
	scanf("%d",&no[1]);

	no[2] = no[0] + no[1];

	printf("The sum is %d.",no[2]);

	return 0;
}


/*
	1. Array
	2. Pointer
	3. Structure
*/
