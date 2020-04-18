//Program to find factorial of a given number using function

#include<iostream>

int factorial(int);

using namespace std;

int main()
{
	int n;
	cout<<"Please enter a number: ";
	cin>>n;

	int f = factorial(n);

	cout<<"The factorial of "<<n<<" is "<<f<<"."<<endl;

	return 0;
}

int factorial(int n)
{
	int fact = 1;

	for(int i=n; i>1; i--)
	{
		fact = fact * i;
	}

	return fact;
}
