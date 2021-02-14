Module KnowReDim
	Sub Main()
		Dim names(5) As String
		
		names(0) = "Neha"		'Won't work in C
		names(1) = "Banty"
		names(3) = "Prince"
		names(2) = "Aman"
		names(4) = "Waseem"
		
		ReDim names(6)
		names(5) = "John"
		
		For i As Integer = 0 To 5
			Console.WriteLine(names(i))
		Next
		
	End Sub
End Module

'In C compiler does not check for array bounds instead
'programmer has to do it by themselves.