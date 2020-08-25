//Program to demostrate friend function

#include<iostream>

using namespace std;

class A
{
	private:
		int a;
	
	public:
		A()				//Default constructor
		{
			a=0;		//Initialized using a constant
		}
		
		A(int x)		//Parameterized constructor
		{
			a = x;		//Initialized using a variable etc.
		}
		
		void display_a()
		{
			cout<<"a="<<a<<endl;
		}
		friend void func_b(int y);
};

void func_b(int y)
{
	int b=y;
	A oba(10);
	cout<<"a="<<oba.a<<", b="<<b<<endl;
}

int main()
{
	//A oba(10);			//Implicit call to constructor
	//A oba = A(10);			//Explicit call to constructor
	//oba.display_a();
	func_b(20);
	return 0;
}
