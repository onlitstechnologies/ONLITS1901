//Program to add two integers using function (call by address)

#include<iostream>

using namespace std;

int add(int*, int*);

int main()
{
	int a, b, c;

	cout<<"Enter the first number: ";
	cin>>a;
	cout<<"Enter the second number: ";
	cin>>b;

	c = add(&a,&b);

	cout<<"The sum is "<<c;

	return 0;
}

int add(int *n1, int *n2)
{
	return *n1 + *n2;
}


/*
	cout pronounced as 'c' out  is a predefined object which represent standard output stream.

	In c we develop Procedure Oriented Programs
	In C++ we develop mostly Object Oriented Programs
*/
