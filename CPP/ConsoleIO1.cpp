#include<iostream>

using namespace std;

int main()
{
	int au, ad, sum;
	cout<<"Enter Augend: ";
	cin>>au;
	cout<<"Enter Addend: ";
	cin>>ad;
	sum = au + ad;
	
	cout<<au<<endl;
	cout<<ad<<endl;
	cout<<"--"<<endl;
	cout<<sum<<endl;
	cout<<"--"<<endl;
	
	cout<<"Please enter your full name: ";
	char name[50];
	
	cin.getline(name,50);		//Not working
	
	cout<<"Good Morining! "<<name<<endl;
	return 0;
}
