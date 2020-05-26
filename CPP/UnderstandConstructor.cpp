//To understand the working of constructor

#include<iostream>

using namespace std;

class ConstructorDemo
{
	private:
		int i;
		float f;
	public:

		ConstructorDemo()	//Default Constructor
		{
			i = 0;
			f = 0.0f;
		}
		
		void input()
		{
			cout<<"Enter an integer: ";
			cin>>i;
			cout<<"Enter a float:";
			cin>>f;
		}
		
		ConstructorDemo(int x, float y)
		{
			i = x;
			f = y;
		}
		
		
		void display()
		{
			cout<<"i="<<i<<", f="<<f<<endl;
		}
};

int main()
{
	ConstructorDemo demo1, demo2(10,20.5f),demo3(demo2);
	
	cout<<"Printing demo1:"<<endl;
	demo1.input();
	demo1.display();
	cout<<"Printing demo2:"<<endl;
	demo2.display();
	cout<<"Printing demo3:"<<endl;
	demo3.display();
	
	return 0;
}

/*

	Q. If we do not explicitly create a constructor does the compiler creates a constructor?
	A. If no constructor is defined explicitly then the compiler supplies a default constructor.
	
	Q. I am have multiple constructors in my class but I am not have a default constructor, then also
	   does the compiler supplies a default constructor?
	A. No, the compiler does not supply a defualt constructor in this case, hence, the programmer has
	   to explicitly create a default constructor if required.
	
	
	- The main difference between a constructor and a normal function is that constructors are called
	  automatically when objects of its class are created whereas other functions have to be called explicitly.
	  
	- Most C++ compiler automatically creates on demand a copy constructor. 
	  
	  Encapsulation: The wrapping up of data and function into a single unit known as class.
	  
	  
	  - Constructor and its charactristics
	  - Default
	  - Parameterized
	  - Copy (intro)
	  - Constructor Overloading
	  
	  copy constructor
	  dynamic
	  new/delete
	  
	  
	  Which is cheaper petrol for car or petrol for helicopter (Aviation Petrol)?
	  
	  car - litres			75/l		= VAT (State GOVT.)
	  AP  - Kilolitres		22000/1000 = 22/l
	  
	  30 Galon in 1 hours
	  30 X 4l	120l
	  
	  
	  Drone
	  Hydro
	  Wind
	  Solar
*/





