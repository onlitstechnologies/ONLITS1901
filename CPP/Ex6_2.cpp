//Exercise 6.2

#include<iostream>
#include<cstring>

using namespace std;

class String									//Ob 1
{
	private:
		char *p;
	
	public:
		String();							//Default Constructor
		String(const char *x);				//Parameterized Constructor
		String concatenate(String x);
		void display();
};

String::String()								//Ob 2
{
	p = new char[0];
	p = NULL;
}

String::String(const char *x)					//Ob 3
{
	p = new char[strlen(x)];
	strcpy(p,x);
}

String String::concatenate(String x)				//Ob 7
{
	String temp(this->p);
	
	
	strcat(temp.p, x.p);
	
	return temp;
}

void String::display()								//Ob 8
{
	cout<<p;
}

int main()
{
	String s1("Hello "), s2("World");						//Ob 6
	String s3;												//Ob 5
	
	cout<<"s1=";
	s1.display();										//Ob 8
	cout<<endl<<"s2=";
	s2.display();										//Ob 8
	
	s3 = s1.concatenate(s2);							//Ob 7	as well as ob 4
	
	cout<<endl<<"s3=";
	s3.display();										//Ob 8
	
	cout<<endl;
	return 0;
}




/*
	Scope, visibility, and lifetime of a variable.
	this pointer: it is a special pointer that contains the reference/address to a current class object

	- New/Delete
	- Have to show destructor also.

	Objectives:
	1. Define a class String - Done
	2. Define a constructor to create an uninitialized string 
	3. Define a constructor to initialize string with a constant 
	4. use '=' to copy strings
	5. Create Unilitialized string
	6. Create inilitialize string
	7. Concatenate
	8. Display
*/
