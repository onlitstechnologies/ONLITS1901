//Program to demonstrate pointer to array

#include<iostream>

void displayarray(int*);

using namespace std;

int main()
{
	int integer[5];		//The size of integer is 40 bytes
	int *p;
	
	p = integer;
	
	cout<<"Enter five integers below:"<<endl;			//1
	for(int i=0; i<5; i++)
		cin>>integer[i];
	
	cout<<"The value of array integer index-wise is: "<<endl;		//2
	for(int i=0; i<5; i++)
		cout<<i<<"\t"<<integer[i]<<endl;							//3-7
		
	cout<<endl<<"Address of integer is "<<integer<<endl;			//8
	cout<<"Address in p is "<<p<<endl;
	
	cout<<"The address of array integer index-wise is: "<<endl;		//9
	for(int i=0; i<5; i++)
		cout<<i<<"\t"<<&integer[i]<<endl;							//10-14
		
	cout<<"The value of array integer index-wise (using pointer) is: "<<endl;	//15
	for(int i=0; i<5; i++,p++)
		cout<<i<<"\t"<<*p<<endl;												//16-20
		
	displayarray(integer);
	

	cout<<"The address of *p is "<<&p<<endl;			//27

	return 0;
}

void displayarray(int *p)		//The size of p is 8 bytes
{
	cout<<"The value of array integer index-wise is (from function display): "<<endl;		//21
	for(int i=0; i<5; i++,p++)
		cout<<i<<"\t"<<*p<<endl;															//22-26
}

/*
	Array is finite collection of similar elements.
	
	Array uses contiguous blocks of memory
	
	The address of first element of array can be given by the arrary name
*/
