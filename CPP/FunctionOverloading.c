//Program to verify if we can create two functions by the same name in C or not

#include<stdio.h>

int add2nos(int, int);
int add3nos(int, int, int);		//conflicting types for add(int, int, int)

int main()	//Entry point of our program
{	
	printf("The sum of 10 and 20 is %d.",add2nos(10,20));
	printf("The sum of 10, 20 and 30 is %d.",add3nos(10,20,30));
}

int add2nos(int a, int b)		//This function adds two integers
{
	return a + b;
}

int add3nos(int a, int b, int c)	//This function adds three integers
{
	return a + b + c;
}
