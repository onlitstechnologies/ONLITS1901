//Constructor with Destructor
#include<iostream>

using namespace std;

class ConstructDestroy
{
	int i=0;
	
	public:
		ConstructDestroy()
		{
			i++;
			cout<<"Object created!"<<endl;
		}
	
		~ConstructDestroy()		//~ is known as tilde
		{
			cout<<"Object destroyed!"<<endl;
		}
		
		void display()
		{
			cout<<"Hello"<<endl;
		}
};

int main()
{
	ConstructDestroy cd1;						//Object 1 created
	
	{
		ConstructDestroy cd2;					//Object 2 created
		cd2.display();
	}											//Object 2 destroyed
	
	//cd2.display();
	{
		ConstructDestroy cd3;					//Object 3 created
	}											//Object 3 destroyed
	
	return 0;
}												//Object 1 destroyed



//Scope, Visibility and Lifetime of a Variable

//Object are complex variables


//cout<<"n="<<n;
