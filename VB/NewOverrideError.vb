Class A
	Dim a as Integer
	
	Protected Sub New()		//Hiding Constructor
		a = 10
	End Sub
	
	Public Sub Display()
		Console.WriteLine("The value of a is " & a)
	End Sub
End Class

Class B
	Inherits A
	
	Public Function CreateA() As A
		return new A()
	End Function
End class

Module NewOverrideError
	Sub Main()
		Dim ObA as A
		Dim obB as new B()
		obA = obB.CreateA()
		ObA.Display()
	End Sub
End Module