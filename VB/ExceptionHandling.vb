Module ErrorHandiling
	Sub Main()
		Dim a as integer = 250
		Dim b as integer = 100
		Dim c as integer = 50
		Dim x as integer
		Dim age(5) as integer
		
		try
			x = a/(b-c)
			Console.WriteLine("x = " & x)
			
			Console.WriteLine(age(500))
			
		catch ex as ArithmeticException			'Exception Handler
			Console.WriteLine("b and c are same, it will cause division by zero error.")
		catch ex as IndexOutOfRangeException
			Console.WriteLine("Array index out of bound")
		end try
		
		Console.WriteLine("0")
	End Sub
End Module