//Program to find the length of a string without using library function

#include<iostream>
#include<cstring>

using namespace std;

int main()
{
	char name[10];
	int i;
	
	cout<<"Please enter your name: ";
	cin>>name;
	
	i = strlen(name);
		
	cout<<"Your name has "<<i<<" characters.";
	return 0;
}
