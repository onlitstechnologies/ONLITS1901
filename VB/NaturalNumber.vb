'Program to display first n natural number

Module NaturaNumber
	Sub Main()
		Dim n As Integer
		
		Console.Write("Please enter a number: ")
		n = Console.ReadLine()
		
		Console.WriteLine("The first {0} natural numbers are: ",n)
		
		For i as Integer = 1 to n
			Console.Write(i & ", ")
		Next i
		
	End Sub
End Module