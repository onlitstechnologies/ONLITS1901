//PROGRAM TO DEMONSTRATE POINTER USING ADD OF TWO INTEGERS PROBLEM

#include<iostream>

using namespace std;

int main()
{
	int a, b, c;
	int *p, *q, *r;
	
	p=&a;
	q=&b;
	r=&c;
	
	cout<<"Please enter a number: ";
	cin>>*p;
	
	cout<<"Please enter another number: ";
	cin>>*q;
	
	*r = *p + *q;
	
	cout<<"The sum is "<<*r<<endl;
	
	return 0; 
}
