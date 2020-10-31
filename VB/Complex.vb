class Complex
	Private real as Single
	Private imag as Single
	
	Public Sub New()		'default constructor
		
		real = 0.0
		imag = 0.0
	End Sub
	Public Sub New(r as Single, i as Single)	'parameterized constructor
		real = r
		imag = i
	End Sub
		
	Public Function Add(x as Complex) as Complex
		Dim r as new Complex()				
		r.real = real + x.real
		r.imag = imag + x.imag
		return r
	End Function
	
	Public Sub display()
		Console.Writeline("real: " & real & "; imag: " & imag)
	End Sub
			
End Class

Module ModComplex
Sub Main()
	Dim c1 as new Complex(10.3,5.6)			'Declaration + Memory-allocation + Initialization
	Dim c2 as new Complex(8.9,4.3)
	Dim c3 as Complex						'Declaration
	
	c3 = c1.Add(c2)
	
	Console.Write("c1: ")
	c1.display()
	Console.Write("c2: ")
	c2.display()
	Console.Write("c3: ")
	c3.display()
End Sub
End Module

'Here c1, c2 and c3 are references to objects.