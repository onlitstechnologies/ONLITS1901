'Program to display first n even number

Module NaturaNumber
	Sub Main()
		Dim n As Integer
		
		Console.Write("Please enter a number: ")
		n = Console.ReadLine()
		
		Console.WriteLine("The even numbers upto {0} are: ",n)
		
		For i as Integer = 2 to n Step 2
			Console.Write(i & ", ")
		Next i
		
	End Sub
End Module


'What is the default of Step in VB
'a) 0
'b) 1
'c) 2
'd) 3

'2 marks