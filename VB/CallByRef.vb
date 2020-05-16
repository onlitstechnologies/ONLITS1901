'Program to add two integers using sub-procedure (Call by reference + Cat5)

Module Cat2
	Sub Main()
		Dim a, b, q, r As Integer
		Console.Write("Please enter a number: ")
		a = Console.ReadLine()
		Console.Write("Please enter another number: ")
		b = Console.ReadLine()
		Call Add(a,b,q,r)
		Console.WriteLine("The quotient is " & q & " and remainder is " & r & ".")
	End Sub

	Sub Add(ByRef x as Integer, ByRef y as Integer, ByRef r1 as Integer, ByRef r2 as Integer)
		r1 = x\y
		r2 = x mod y
	End Sub
End Module
	
	
'CLR - Common Language Runtime
'No function prototyping needed



