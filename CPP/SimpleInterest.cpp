//Program to find simple interest

#include<iostream>

using namespace std;

int main()
{
	float p, r, t, si;

	cout<<"Enter Principal: ";
	cin>>p;

	cout<<"Enter Rate: ";
	cin>>r;

	cout<<"Enter Time: ";
	cin>>t;

	si = (p*r*t)/100;

	cout<<"Simple Interest is: "<<si<<endl;

	return 0;
}

//How can you reduce number of decimal places in c++?
