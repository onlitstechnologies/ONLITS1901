//Program to demonstrate pointer to array

#include<iostream>

void displayarray(int*);

using namespace std;

int main()
{
	int integer[10];		//The size of integer is 40 bytes
	int *p;
	
	p = integer;
	
	cout<<"Enter five integers below:"<<endl;
	for(int i=0; i<5; i++)
		cin>>integer[i];
	
	cout<<"The value of array integer index-wise is: "<<endl;
	for(int i=0; i<5; i++)
		cout<<i<<"\t"<<integer[i]<<endl;
		
	cout<<endl<<"Address of integer is "<<integer<<endl;
	cout<<"Address in p is "<<p<<endl;
	
	cout<<"The address of array integer index-wise is: "<<endl;
	for(int i=0; i<5; i++)
		cout<<i<<"\t"<<&integer[i]<<endl;
		
	cout<<"The value of array integer index-wise (using pointer) is: "<<endl;
	for(int i=0; i<5; i++,p++)
		cout<<i<<"\t"<<*p<<endl;
		
	displayarray(integer);
		
	return 0;
}

void displayarray(int *p)		//The size of p is 8 bytes
{
	cout<<"The value of array integer index-wise is (from function display): "<<endl;
	for(int i=0; i<5; i++,p++)
		cout<<i<<"\t"<<*p<<endl;
}
/*
	Array is finite collection of similar elements.
	
	Array uses contiguous blocks of memory
	
	The address of first element of array can be given by the arrary name
*/
