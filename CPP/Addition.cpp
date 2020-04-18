//Every C program is a C++ program

//Program to add two integers

#include<iostream>

using namespace	std;							//namespace: A collection of types, variables and constants

int main()
{
	int a, b, c;
	
	cout<<"Please enter a number: ";		//cout: Predefined object which represents the standard output stream (Screen)
	cin>>a;									//cin: Predefined object which represents the standard input stream (Keyboard)
	
	cout<<"Please enter another number: ";
	cin>>b;
	
	c = a + b;
	
	cout<<"The sum is "<<c<<endl;			//endl is a manipulator in c++ which gives us the functionality of \n
	
	return 0; 
}

/*

1. Not giving & while taking input.
2. Control string are missing (%d).
3. <<,was known as left shift operator (bitwise operators) in c. In C++ it does carry the old meaning as well as it has a new function
	and in this role it is known as "Insertion Operator or Put to operator" 
4. >>, was known as right shift operator in c. In c++ it does carry the old meaning as well as it has a new function and in this role it
	is known as "Extraction operator or get from operator".

*/
