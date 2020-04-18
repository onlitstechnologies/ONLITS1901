//Program to add two integer using pointer

#include<stdio.h>

int main()
{
	int a, b, c;
	int *p, *q, *r;
	p=&a;
	q=&b;
	r=&c;

	//printf("The value of *p, *q, *r are %p, %p, %p respectively\n.");

	printf("Enter the first number: ");
	scanf("%d",p);

	printf("Enter the second number: ");
	scanf("%d",q);

	*r = *p + *q;

	printf("The sum is %d.",*r);

	return 0;
}



/*
	Pointer is a special variable which stores the address of another variable.

	cons:
		1. Ulitising unnecessary amount of memory;
*/
