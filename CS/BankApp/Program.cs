using System;

namespace BankApp
{
    //-----------Class Declaration section-----------------
class bank_account
{
	string dep_name;
	int acno;
	string actype;
	float balance;
	
//---------------------------------------------------------
//------------Class function definition--------------------
public void menu()
{
	int ch;
	Console.Write("What do you want to do:\n");
	Console.Write("1. Deposit\n");
	Console.Write("2. Withdraw\n");
	Console.Write("3. Display Balance\n");
	Console.Write("4. Exit\n");
	Console.Write("Enter you choice:");
	ch = Convert.ToInt32(Console.ReadLine());
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
			//Environment.Exit(0);
            break;
		default:
			Console.Write("Invalid option!");
			menu();
            break;
	}
}

public void init()
{
	dep_name = "Ritik";
	acno = 123;
	actype = "SA";
	balance = 10000.00F;
}

void deposit()
{
	float amount;
	Console.Write("Enter amount to deposit: ");
	amount = Convert.ToSingle(Console.ReadLine());
	balance = balance + amount;
	menu();
}

void withdraw()
{
	float amount;
	Console.Write("Enter amount to withdraw: ");
	amount = Convert.ToSingle(Console.ReadLine());
	if(amount<=balance)
		balance = balance - amount;
	else
		Console.Write("Transaction Declined!");
	menu();
}

void display()
{
    Console.WriteLine("Account #: {0}", acno);
	Console.WriteLine("Depositor Name: {0}", dep_name);
    Console.WriteLine("Account Type: {0}", actype);
	Console.WriteLine("Balance: {0}", balance);
	menu();
}
//-------------------------------------------------------------
}
    class Program
    {
        static void Main(string[] args)
        {
            bank_account acc = new bank_account();
	        acc.init();
	        acc.menu();
        }
    }
}


//Scaffolding