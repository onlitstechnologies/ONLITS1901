#include<iostream>

using namespace std;

class complex
{
	private:
		float real;
		float imag;
	public:
		complex()		//default constructor
		{
			real = 0.0F;
			imag = 0.0F;
		}
		complex(float r, float i)	//parameterized constructor
		{
			real = r;
			imag = i;
		}
		complex operator+(complex x)	//operator overloading
		{
			complex r;
			r.real = real + x.real;
			r.imag = imag + x.imag;
			return r;
		}
		void display()
		{
			cout<<"real: "<<real<<"; imag: "<<imag<<endl;
		}
			
};

int main()
{
	complex *c1 = new complex(10.3,5.6);	//Object created without name
	complex *c2 = new complex(8.9,4.3);
	complex *c3;
	
	*c3 = *c1 + *c2;
	
	cout<<"*c1: ";
	c1->display();
	cout<<"*c2: ";
	c2->display();
	cout<<"*c3: ";
	c3->display();
	
	return 0;
}

//Pointer is a special variable which stores the address of another variable
//Since pointer stores address (reference) of another variable, they are also 
//known as reference types.
