#include<iostream>
using namespace std;
class A
{
protected:
	int a;
public:
	virtual void display() = 0;		//pure virtual function
};

class B : public A
{
	int b;
public:
	B()
	{
		a=20;
		b=30;
	}
	void display()
	{
		cout<<"a="<<a<<"\tb="<<b<<endl;
	}
	void hello()
	{
		cout<<"Hello"<<endl;
	}
};

int main()
{
	A *ptrA;
	B ptrB;
	
	ptrA = new B();
	
	ptrA->display();
	ptrB.hello();
	
	return 0;
}


