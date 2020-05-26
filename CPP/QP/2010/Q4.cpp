#include<iostream>

using namespace std;

void swap(int&, int&);	//Function Prototype

int main()
{
	int a=10, b=20;
	
	cout<<"The value of a and b before swapping are "<<a<<" and "<<b<<", respectively."<<endl;
	
	swap(a, b);
	
	cout<<"The value of a and b after swapping are "<<a<<" and "<<b<<", respectively."<<endl;
	
	return 0;
}

//Function Definition
void swap(int &x, int &y)	//Function Header
{
	int z;					//Function Body
	z = x;
	x = y;
	y = z;
}
