Class A
	Private a As Integer
		
	Public Sub New()
		a=10
	End Sub
	
	Public Sub DisplayA()
		Console.WriteLine("a=" & a)
	End Sub
End Class

Module DynamicObjects
	Sub Main()
		'Dim obA as A			'Statically or compile time
		Dim obA As New A()		'Dynamically or run time using pointer to object
	
		obA.displayA()
	
	End Sub
End Module

' All Objects are created dynamically in VB.Net
' There is no pointer in VB
' If you create a variable of class then it is treated as pointer / reference variable
' Reference's default value is null (Empty)
