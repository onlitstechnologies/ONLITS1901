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
		
		void display()
		{
			cout<<"a="<<a<<endl;
		}
};

class B			//Base Class
{
	protected:
		int b;
	
	public:
		B()
		{
			b=20;
		}
		void display()
		{
			cout<<"b="<<b<<endl;
		}	
};

class C : public A, public B
{
		int c;
	public:
		C()
		{
			c=30;
		}
		
		void display()
		{
			cout<<"c="<<c<<endl;
		}
};


int main()
{
	C obC;
	
	obC.A::display();
	obC.B::display();
	obC.display();
	
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
