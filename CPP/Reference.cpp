//Program to demostrate reference variable in c++
#include<iostream>

using namespace std;

int main()
{
	int a=10, b=20, c;
	
	int &x = a;
	int &y = b;
	int &z = c;
	
	z = x + y;
	
	cout<<"The value of c is "<<c<<endl;
}






/*
	reference variable is an alias to an existing variable

*/
