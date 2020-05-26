//Exercise 6.2

#include<iostream>
#include<cstring>

using namespace std;

class String
{
	private:
		char *p;
	
	public:
		String();
		String(const char *x);	
		String operator+(String x);
		void display();
};

String::String()	
{
	p = new char[0];
	p = NULL;
}

String::String(const char *x)		
{
	p = new char[strlen(x)];
	strcpy(p,x);
}

String String::operator+(String x)		
{
	String temp(this->p);
	
	
	strcat(temp.p, x.p);
	
	return temp;
}

void String::display()						
{
	cout<<p;
}

int main()
{
	String s1("Hello "), s2("World");						
	String s3;											
	
	cout<<"s1=";
	s1.display();								
	cout<<endl<<"s2=";
	s2.display();							
	
	s3 = s1 + s2;			//The objective of the question has been achieved
	
	cout<<endl<<"s3=";
	s3.display();						
	
	cout<<endl;
	return 0;
}




/*
	Objective:
	
	- Concatenate two strings using operator overloading
	
	- Operator overloading is process of assigning a new meaning to an existing operator so that it 
	  work with a user-defined type as it works with built in types.
	  
	Topic related to Operator Overloading:
		- Overload unary operator (--, ++, -)
			- member function and friend function
		- Overload binary operator
			- member function and friend function
		- Operator that cannot be overloaded
	  
*/
