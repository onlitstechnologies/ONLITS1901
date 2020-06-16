' PROGRAM TO ACCEPT AGE OF 5 STUDENTS AND DISPLAY THEIR AVERAGE

Module AverageAge
	Sub Main()
		Dim age(5), sum, avg As Single
		
		
		Console.WriteLine("Enter 5 age below:")
		
		For i As Integer = 0 to 4
			age(i) = Console.ReadLine()
			sum = sum + age(i)
		Next i
		
		avg = sum/5
		
		Console.WriteLine("The average age is " & avg)
		
		' ReDim age(10) - We can redeclare and array in VB.Net
		
	End Sub
End Module
