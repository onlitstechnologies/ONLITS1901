//Program to find factorial of a given number using function

#include<stdio.h>

int factorial(int);


int main()
{
	int n;
	printf("Please enter a number: ");
	scanf("%d",&n);

	int f = factorial(n);

	printf("The factorial of %d is %d.\n", n, f);

	return 0;
}

int factorial(int n)
{
	int fact = 1;

	for(int i=n; i>1; i--)		//C++ type of variable declaration is possible only in c99 onwards compilers
	{
		fact = fact * i;
	}

	return fact;
}
