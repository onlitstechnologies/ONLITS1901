/*
Excercise 5.1 from E. Balagurusamy
*/

#include<iostream>
#include<cstring>

using namespace std;

//-----------Class Declaration section-----------------
class bank_account
{
	private:
		string dep_name;
		int acno;
		char actype[3];
		float balance;
	
	public:
		void menu();
		void init();
		void deposit();
		void withdraw();
		void display();
};
//---------------------------------------------------------
//------------Class function definition--------------------
void bank_account :: menu()
{
	int ch;
	cout<<"What do you want to do:"<<endl;
	cout<<"1. Deposit"<<endl;
	cout<<"2. Withdraw"<<endl;
	cout<<"3. Display Balance"<<endl;
	cout<<"4. Exit"<<endl;
	cout<<"Enter you choice:";
	cin>>ch;
	switch(ch)
	{
		case 1:
			deposit();
			break;
		case 2:
			withdraw();
			break;
		case 3:
			display();
			break;
		case 4:
			exit(0);
		default:
			cout<<"Invalid option!"<<endl;
			menu();
	}
}

void bank_account :: init()
{
	dep_name = "Ritik";
	acno = 123;
	strcpy(actype,"SA");
	balance = 10000.00F;
}

void bank_account :: deposit()
{
	float amount;
	cout<<"Enter amount to deposit: ";
	cin>>amount;
	balance = balance + amount;
	menu();
}

void bank_account :: withdraw()
{
	float amount;
	cout<<"Enter amount to withdraw: ";
	cin>>amount;
	if(amount<=balance)
		balance = balance - amount;
	else
		cout<<"Transaction Declined!"<<endl;
	menu();
}

void bank_account :: display()
{
	cout<<"Depositor Name: "<<dep_name<<endl;
	cout<<"Balance: "<<balance<<endl;
	menu();
}
//-------------------------------------------------------------
//------------Main Function------------------------------------
int main()
{
	bank_account acc;
	acc.init();
	acc.menu();
	
	return 0;
}

/*

cout is an object of ostream class

If a function is defined within the class boundary it is treated as inline function

:: - Scope resolution operator

Software should always be developed according to user requirements

There is a special function in c++ whose name is same as that of the class and this function 
is known as constructor. Its task is to initialize the data members of a class.

*/
