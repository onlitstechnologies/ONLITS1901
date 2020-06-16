//									PROGRAM TO DEMONSTRATE INHERITANCE (SINGLE INHERITANCE)

#include<iostream>

using namespace std;

class A					//Base Class
{
	private:
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



int main()
{
	//A obA;			//Statically or compile time
	A *obA = new A();	//Dynamically or run time using pointer to object
	
	obA->displayA();
	
	return 0;
}
