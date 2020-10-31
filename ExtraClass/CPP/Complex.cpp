#include<iostream>

using namespace std;

class complex
{
	float real;
	float imag;
	
public:
	complex(){};
	complex(float r, float i)
	{
		real = r;
		imag = i;
	}
	
	complex operator+(complex x)
	{
		complex t;
		
		t.real = this->real + x.real;
		t.imag = this->imag + x.imag;
		
		return t;
	}
	
	void display()
	{
		cout<<"real: "<<real<<endl;
		cout<<"imaginary: "<<imag<<endl;
	}
};

int main()
{
	complex c1(5.5,4.5), c2(1.4, 2.3), c3;
	
	c3 = c1 + c2;
	
	
	cout<<"Displaying c3:"<<endl;
	c3.display();
	
	return 0;
}

//overloading unary operator
//overloading binary operator
//overloading using friend function
