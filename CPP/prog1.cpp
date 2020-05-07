#include<iostream>

using namespace std;

class candidate
{
	private:		//access specifier/modifier
		int cand_id=1;
		char name[30];
		char gender;
		char dob[11];
	
	public:
		void print()
		{
			cout<<cand_id<<endl;
		}
};

int main()
{
	candidate c,d;
	
	c.print();
	d.print();
	
	return 0;
}


/*
	object 	- dish	(ingredients)
	class (data/variables + procedure (function/method)	- recipe (ingredients + procedure)


	Indirectly we will try to introduce vb and java also because c++, vb.net, java are similar
	
	We will not show you how to create GUI programming in c++
	
	We teach you GUI in vb.net (IDE - Visual Studio) and java (without IDE)
	
	Microsoft Visual C++ (Customised Library - MFC - Microsoft Foundation Classes)
	
	.NET Framework
	
	cout, cin , namespace std, iostream
	
	Default access specifier for class members in C++ is private

*/


