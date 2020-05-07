//Program to demonstrate function overloading in C++

#include<iostream>

using namespace std;

int add(int, int);
int add(int, int, int);

int main()	//Entry point of our program
{	
	cout<<"The sum of 10 and 20 is "<<add(10,20)<<endl;
	cout<<"The sum of 10, 20 and 30 is "<<add(10,20,30)<<endl;
}

int add(int a, int b)		//This function adds two integers
{
	return a + b;
}

int add(int a, int b, int c)	//This function adds three integers
{
	return a + b + c;
}
