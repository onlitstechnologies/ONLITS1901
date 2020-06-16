REM									PROGRAM TO DEMONSTRATE INHERITANCE (SINGLE INHERITANCE)

Class A					'Base Class

	Protected a as integer
		
	Public Sub New()		'Constructor		
		a=10
	End Sub
End Class

Class B 			'Derived Class (Class B inherits the public properties of Class A)
	Inherits A
	
	Private b as integer
	
	public Sub New()		'Constructor
		b=20
	End Sub
	Public Sub DisplayAB()
		Console.WriteLine("a=" & a & ", b=" & b)
	End Sub
End Class

Module Inheritance
	Sub Main()
		Dim obB as new B()
	
		obB.DisplayAB()
	End Sub
End Module
