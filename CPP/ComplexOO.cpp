//Program to add two complex numbers with Operator Overloading

#include<iostream>

using namespace std;

class complex
{
	private:
		float real;
		float imag;
	public:
		complex()
		{
			real = 0.0F;
			imag = 0.0F;
		}
		complex(float p, float q)
		{
			real = p;
			imag = q;
		}
		void display()
		{
			cout<<"real: "<<real<<", imaginary: "<<imag<<endl;
		}
		complex operator+(complex &x);			//declaration
};

complex complex :: operator+(complex &x)
{
	complex ct;
	
	ct.real = real + x.real;
	ct.imag = this->imag + x.imag;
	

	return ct;			//this is one the explicit use of 'this pointer' 				
}

int main()
{
	complex c1(10.0F,20.0F), c2(30.0F,40.0F), c3;
	
	c3 = c1 + c2;		//c3=c1.operator+(c2);
	
	cout<<"c1:"<<endl;
	c1.display();
	cout<<"c2:"<<endl;
	c2.display();
	cout<<"c3:"<<endl;
	c3.display();
	return 0;
}



//Complex number is number which has two part one being real and the other being imaginary
//We have see a complex number is composed of two things- real number and imaginary number
//By adding two complex numbers implies add real to real and imaginary to imaginary
//Overloaded binary operator (+) using member function
