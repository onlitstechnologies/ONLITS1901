//Program in C++ to concatenate two strings using object and operator overloading

#include<iostream>
#include<cstring>

using namespace std;

class mystring
{
	private:
		char str[30];
	public:	
		void input()	//If a function is defined inside class definition it becomes inline.
		{
			cin>>str;
		}
		
		void display()
		{
			cout<<str;
		}
		
		int length();
		mystring operator+(mystring x);
};

int mystring :: length()
{
	int i=0;
	while(str[i] != '\0')
		i++;
		
	return i;
}

mystring mystring :: operator+(mystring x)
{
	mystring temp;
	
	strcpy(temp.str, str);
	strcat(temp.str, x.str);
	
	return temp;
}

int main()
{
	mystring s1, s2, s3;
	
	int a, b, c;	//not part of this program
	
	cout<<"Please enter a string: ";
	s1.input();
	cout<<"Please enter another string: ";
	s2.input();
	
	cout<<"The length of s1 is "<<s1.length()<<endl;
	cout<<"The length of s2 is "<<s2.length()<<endl;
	
	//s3 = s1.concatenate(s2);

	c = a + b;		//not part of this program

	s3 = s1 + s2;
	
	cout<<"The resultant string is ";
	s3.display();
	
	cout<<endl;
	
	return 0;
}

/*
	In C prototype are recommended whereas in C++ they are required.
	
	In the above program our object is string.
	
	To create an object we have to create a class.
	
	object  = data + function
	
	data - 1 char array
	
	function:
		Input()
		display()
		length()
		contatenate()
		.
		.
		.
	
	
	
	2 X 1 = 2
	
	2 X 2 = 4					You ignored my 80% and considered my 20%.
	
	2 X 3 = 9
	
	2 X 4 = 8
	
	2 X 5 = 10
	
	
	How can I prevent my source code from being stolen?	Good for nothing.
	
	IP - Intellectual Property
	

	Operator overloading was introduced in C++ to treat user-defined type same as fundamental/primitive type
	
	
	
	Singleton class
	
	
	Overloading Unary Operators ++, --		i++ , i--	(Member function / Friend function)
	Overloading Binary Operators		a+b, a*b		(Member function / Friend function)

	
	
*/
