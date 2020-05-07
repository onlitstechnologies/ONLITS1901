//Program in C++ to concatenate two strings

#include<iostream>
#include<cstring>

using namespace std;

int main()
{
	char str1[30], str2[30], result[60];
	
	cout<<"Please enter a string: ";
	cin>>str1;
	cout<<"Please enter another string: ";
	cin>>str2;
	
	strcpy(result, str1);	//Concatenates (join) two strings
	strcat(result, str2);
	
	//result = str1 + str2;
	
	cout<<"The resultant string is "<<result<<endl;
	
	return 0;
}





/*
	In C prototype are recommended whereas in C++ they are required.
	
	In the above program our object is string.

*/
