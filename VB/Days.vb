'Program to accept a number between (1 and 7) and display day of week corresponding to the number.

Module Days
	Sub Main()
		Dim n as Integer
		Console.Write("Please enter a number: ")
		n = Console.ReadLine()
		
		Select n
			Case 1
				Console.WriteLine("Monday")
			Case 2
				Console.WriteLine("Tuesday")
			Case 3
				Console.WriteLine("Wednesday")
			Case 4
				Console.WriteLine("Thursday")
			Case 5
				Console.WriteLine("Friday")
			Case 6
				Console.WriteLine("Saturday")
			Case 7
				Console.WriteLine("Sunday")
			Case Else
				Console.WriteLine("Invalid Input!")
		End Select
		
	End Sub
End Module


'PascalCase
'camelCase