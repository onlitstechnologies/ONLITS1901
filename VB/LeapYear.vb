REM - PROGRAM TO ACCEPT A YEAR AND FIND WHETHER IT IS A LEAP YEAR OR NOT

Module LeapYear
	Sub Main()
		Dim yr as Integer
		
		Console.Write("Please enter a year: ")
		yr = Console.ReadLine()
		
		If ((yr Mod 4 = 0 And yr Mod 100 <> 0) Or yr Mod 400 = 0)
			Console.WriteLine(yr & " is a leap year.")
		Else
			Console.WriteLine(yr & " is a common year.")
		End If
	End Sub
End Module


' Select-Case, Loops, Array, Dim