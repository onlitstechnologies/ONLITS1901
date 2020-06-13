'E. Balagurusamy Exercise 5.1 in VB.Net

Class BankAccount
	Private name as String
	Private acno as Integer
	Private actype as String
	Private balance as Single
	
	Sub Menu()
		Console.WriteLine()
		Console.WriteLine("------------------------------------------")
		Console.WriteLine("Select an option from below:")
		Console.WriteLine("1. Deposit amount")
		Console.WriteLine("2. Withdraw amount")
		Console.WriteLine("3. Check Balance")
		Console.WriteLine("4. Exit")
		Console.Write("Enter choice: ")
		Dim ch As Integer = Console.ReadLine()
		Console.WriteLine("------------------------------------------")
		
		Select Case (ch)
			Case 1
				Deposit()
				Menu()
			Case 2
				Withdraw()
				Menu()
			Case 3
				ShowBalance()
				Menu()
			Case 4
			
			Case Else
				Console.WriteLine("Invalid Option")
				Menu()
		End Select
	End Sub
	
	Sub New()		' Default Constructor
		name = "Suraj Raj"
		acno = 123456
		actype = "SA"
		balance = 10000
	End Sub
	
	Sub New(n as string, ano as integer, atype as string, bal as single) 'Parameterized Constructor
		name = n
		acno = ano
		actype = atype
		balance = bal
	End Sub
	
	Sub Deposit()
		Console.Write("Enter amount: ")
		Dim amt As Single = Console.ReadLine()
		balance = balance + amt
	End Sub
	
	Sub Withdraw()
		Console.Write("Enter amount: ")
		Dim amt As Single = Console.ReadLine()
		If(amt<= balance)
			balance = balance - amt
		Else
			Console.WriteLine("Transaction Declined!")
		End If
	End Sub
	
	Sub ShowBalance()
		Console.WriteLine("Depositor Name: " & name)
		Console.WriteLine("Balance: " & balance)
	End Sub
End Class


Module Bank
	Sub Main()
		Dim ac1 As New BankAccount()
		'Dim ac1 As New BankAccount("Aman Kumar",56985,"CA",25000)
		
		ac1.Menu()
	
	End Sub
End Module


' In VB.Net/Java all objects are referece type (similar to pointer in C, C++) and they are assiged dynamically.
' BankAccount ac1;	C++
' BankAccount ac1 = new BankAccount(); Here ac1 is a reference which can compared to pointer in c, C++
' BankAccount *ac1 = new BankAccount(); Pointer to object

' Constructor is a special member function whose task is to initialize objects of a class.

' In VB.Net the name of the class and its constructor are not same.

' Infact, the name of the constructor is always New()

' Files or Database

' Operator Overloading does not work in VB.Net