/*Program to demostrate pointer to derived class*/

#include<iostream>

using namespace std;

class B
{
		int b;
	public:
		B()
		{
			b=0;
		}
		B(int x)
		{
			b=x;
		}
		virtual void display() = 0;			//pure virtual function
		/*{
			cout<<"b="<<b<<endl;
		}*/
};


class D: public B		//Single Inheritance
{
		int d;
		
	public:
		D()
		{
			d=0;
		}
		
		D(int x)
		{
			d=x;
		}
		void display()
		{
			cout<<"d="<<d<<endl;
		}
};

int main()
{
	//B obb(10), *bp;
	B *bp;
	D obd(20);
	
	//bp = &obb;			//pointing to base class
	//bp->display();
	
	bp = &obd;			//pointing to derived class
	bp->display();
	
	//cout<<"size of obb is "<<sizeof(obb)<<" bytes."<<endl;
	//cout<<"size of bp is "<<sizeof(bp)<<" bytes."<<endl;
	
	return 0;	
}


/*
	If you call a function which is defined in both base as well as derived class using base pointer pointing 
	to derived class then the function defined in the base class is called.
	
	It is not possible to point to base class object using a derived class pointer. In other words, the
	pointer of derived class is not type-compatible to the pointer of base class. 
*/


