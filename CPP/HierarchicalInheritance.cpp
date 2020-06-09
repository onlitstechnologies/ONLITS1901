//									PROGRAM TO DEMONSTRATE INHERITANCE (SINGLE INHERITANCE)

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
		
		void displayA()
		{
			cout<<"a="<<a<<endl;
		}
};

class B : public A
{
	protected:
		int b;
	
	public:
		B()
		{
			b=20;
		}
		void displayB()
		{
			cout<<"b="<<b<<endl;
		}	
};

class C : public A
{
		int c;
	public:
		C()
		{
			c=30;
		}
		
		void displayC()
		{
			cout<<"c="<<c<<endl;
		}
};

class D : public A
{
		int d;
	public:
		D()
		{
			d=40;
		}
		
		void displayD()
		{
			cout<<"d="<<d<<endl;
		}
};

int main()
{
	B obB;
	C obC;
	D obD;
	
	cout<<"Calling displayA() using obB object:"<<endl;
	obB.displayA();		//call to displayA()
	obB.displayB();
	cout<<"Calling displayA() using obC object:"<<endl;
	obC.displayA();		//call to displayA()
	obC.displayC();
	cout<<"Calling displayA() using obD object:"<<endl;
	obD.displayA();		//call to displayA()
	obD.displayD();
	
	return 0;
}


/*
	Function overloading is found within a single class
	Function overriding is found between two different classes
	
	Access specifier/modifier
	1. private		- Can be used within the class
	2. public		- Can be used anywhere
	3. protected	- Can be used with the class and it derived classes
	
	
	Only public and protected member can be inherited
	
	public
	protected
	private
	
	Work on different situations.
	
*/
