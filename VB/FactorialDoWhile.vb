Module Factorial
	Sub Main()
		Dim n, i, f as Integer
		
		f = 1
		
		Console.Write("Please enter a number: ")
		n = Console.ReadLine()
		
		i = n
		
		do						'Exit Controlled
			f = f * i
			i -= 1
		Loop While(i>=1)
		
		'Console.WriteLine("The factorial of {0} is {1}.", n, f)
		Console.WriteLine("The factorial of " & n & " is " & f & ".")	'Recommended
	End Sub
End Module

'Multiple variables cannot be initialized in a single declaration statement in VB.
'1 x 2 x 3 x 4 x 5
'5 x 4 x 3 x 2 x 1
'VB has an inbuilt garbage collector