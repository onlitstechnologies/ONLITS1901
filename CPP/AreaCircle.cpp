/*Program to accept radius of a circle and find its area*/

#include<iostream>

#define PI 3.14

using namespace std;

int main()
{
	float r, a;
	
	cout<<"Please enter radius: ";
	cin>>r;
	
	a = PI * r * r;
	
	cout.precision(2);
	cout<<"The area of circle is "<<a<<endl;
	
	return 0;
}
