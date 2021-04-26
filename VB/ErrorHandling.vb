Module ErrorHandiling
	Sub Main()
		Dim a as integer = 250
		Dim b as integer = 50
		Dim c as integer = 50
		Dim x as integer
		
		
		On Error GoTo ErrHandler
		x = a/(b-c)
		Console.WriteLine("x = " & x)
		
		ErrHandler:			'Error Handler
		Console.WriteLine("b and c are same, it will cause division by zero error.")
		
	End Sub
End Module