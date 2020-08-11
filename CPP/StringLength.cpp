//Program to find the length of a string without using library function

#include<iostream>

using namespace std;

int main()
{
	char name[10];
	int i=0;
	
	cout<<"Please enter your name: ";
	cin>>name;
	
	while(name[i]!='\0')
	{
		i++;
	}
	
	cout<<"Your name has "<<i<<" characters.";
	return 0;
}
