#include<iostream>

using namespace std;

class integer
{
	private:
		int i;			
	public:
		integer()		//default constructor
		{
			i=0;
		}
		integer(int x)	//Parameterized constructor
		{
			i=x;
		}
		void display()
		{
			cout<<i;
		}
};

int main()
{
	integer i1(10), i2(20);		//Implicit call
	integer i3 = integer(30);	//Explicit call
	
	cout<<"i1 = ";
	i1.display();
	cout<<endl<<"i2 = ";
	i2.display();
	cout<<endl<<"i3 = ";
	i3.display();
	cout<<endl;
	return 0;
}


/*
	-Encapsulation 	: 	The wrapping of data and function into a single unit (class). Data/Information Hiding
	-Abstraction	:	Representing essential features 
	-Inheritance	:
	-Polymorphism	:
	
	
	Constructor overloading: Since constructor is also a function hence just like a normal C++ function it
	can also be overloaded.
	
	Types of constructor:
	1) Default Constructor - A constructor that does not accept parameters. In a default constructor members
		are initialized with constants.
	2) Parameterized Constructor - As the name implies this constructor accepts parameters.
	3) Copy Constructor
	4) Dynamic Constructor
	
*/
