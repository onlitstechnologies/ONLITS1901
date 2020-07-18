//Program to find the length of a string using function of string class

#include<iostream>

using namespace std;

int main()
{
	string name;
	int i;
	
	cout<<"Please enter your name: ";
	cin>>name;
	
	i = name.length();
		
	cout<<"Your name has "<<i<<" characters.";
	return 0;
}
