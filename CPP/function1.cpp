//Function to swap two integers by call by address method

#include<iostream>

using namespace std;

void swap(int*, int*);

int main()
{
	int a, b;
	
	cout<<"Please enter the values of a and b: ";
	cin>>a>>b;
	
	cout<<"The value of a and b before swapping are "<<a<<" and "<<b<<" respectively."<<endl;
	
	swap(&a,&b);
	
	cout<<"The value of a and b after swapping are "<<a<<" and "<<b<<" respectively."<<endl;
}

void swap(int *x, int *y)
{
	*x = *x + *y ;
	*y = *x - *y;
	*x = *x - *y;
}

/*
	endl is known as manipulator and just like endl there is another manipulator in c++ which setw()
	
	sin()
	cos()
	
	pointer is special variable which stores address of another variable
	
*/
