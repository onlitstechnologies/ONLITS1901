//Program to explain pointer concept

#include<iostream>

using namespace std;

int main()
{
	int a=10;
	double b=20.6;
	int *p,**q;	//Here p is a pointer whereas q is a pointer to pointer
	double *fp, **fq;
	void *v=NULL;
	
	p=&a;
	q=&p;
	
	cout<<"The value of a is "<<a<<"."<<endl;
	cout<<"The address of a is "<<&a<<"."<<endl;
	cout<<"The size of a is "<<sizeof(a)<<"."<<endl<<endl;
	
	cout<<"The value of p (an address) is "<<p<<"."<<endl;
	cout<<"The address of p is "<<&p<<"."<<endl;
	cout<<"The value of the address p is pointing to is "<<*p<<"."<<endl;
	cout<<"The size of p is "<<sizeof(p)<<"."<<endl<<endl;
	
	cout<<"The value of q (an address to pointer) is "<<q<<"."<<endl;
	cout<<"The address of q is "<<&q<<"."<<endl;
	cout<<"The value of the address q is pointing to (which is value of p) is "<<*q<<"."<<endl;
	cout<<"The value of the address p is pointing to (which is the value of a) is "<<**q<<"."<<endl;
	cout<<"The size of q is "<<sizeof(q)<<"."<<endl<<endl;
	
	fp=&b;
	fq=&fp;
	
	cout<<"The value of b is "<<b<<"."<<endl;
	cout<<"The address of b is "<<&b<<"."<<endl;
	cout<<"The size of b is "<<sizeof(b)<<"."<<endl<<endl;
	
	cout<<"The value of fp (an address) is "<<fp<<"."<<endl;
	cout<<"The address of fp is "<<&fp<<"."<<endl;
	cout<<"The value of the address fp is pointing to is "<<*fp<<"."<<endl;
	cout<<"The size of fp is "<<sizeof(fp)<<"."<<endl<<endl;
	
	cout<<"The value of fq (an address to pointer) is "<<fq<<"."<<endl;
	cout<<"The address of fq is "<<&fq<<"."<<endl;
	cout<<"The value of the address fq is pointing to (which is value of fp) is "<<*fq<<"."<<endl;
	cout<<"The value of the address fp is pointing to (which is the value of b) is "<<**fq<<"."<<endl;
	cout<<"The size of fq is "<<sizeof(fq)<<"."<<endl<<endl;
	
	cout<<"The size of v is "<<sizeof(v)<<"."<<endl<<endl;
	
	return 0;
}


/*
	Pointer to Array
	Pointer to Structure
	Pointer to String
	Pointer to Object
	
	Copy/Paste has issues - Inefficient (more memory), Inconsistent, Duplicacy
	
	Size of pointer is architecture dependent ie. on 32-bit computer the size of pointer will be 32-bit,
	similarly, on a 64-bit computer it will be 64-bit(8 bytes)
	
*/
