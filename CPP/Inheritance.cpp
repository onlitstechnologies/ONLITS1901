//									PROGRAM TO DEMONSTRATE INHERITANCE

#include<iostream>

using namespace std;

class A					//Base Class
{
	protected:
		int a;
		
	public:
		A()
		{
			a=10;
		}
};

class B : public A			//Derived Class (Class B inherits the public properties of Class A)
{
		int b;
	
	public:
		B()
		{
			b=20;
		}
		void displayAB()
		{
			cout<<"a="<<a<<", b="<<b<<endl;
		}	
};

int main()
{
	B obB;
	
	obB.displayAB();
	//obB.displayB();
	
	//obB.a = 40;		//cannot be used here as it is protected
	
	return 0;
}


/*
	Function overloading is found within a single class
	Function overriding is found between two different classes
	
	Access specifier/modifier
	1. private		- Can be used within the class
	2. public		- Can be used anywhere
	3. protected	- Can be used with the class and it derived classes
*/
