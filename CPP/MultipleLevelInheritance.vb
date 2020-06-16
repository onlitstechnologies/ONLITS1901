REM									PROGRAM TO DEMONSTRATE INHERITANCE (MULTILEVEL INHERITANCE)

class A

	protected a as integer
		
	public sub new()

			a=10
	end sub
		
	public sub displayA()
		
			console.writeline("a=" & a)
	end sub
end class

class B 
	inherits A

	protected b as integer
	
	public Sub New()
		
			b=20
	End Sub
		
	public sub displayB()
		
			console.writeline("b=" & b)
	end sub
end class

class C 
	inherits B

		private c as integer
	public sub new()
		
			c=30
	end sub
		
	private sub displayC()
		
		console.writeline("c=" & c)
	end sub
end class


Module Multilevel
	sub main()

		Dim obC as new C();

		obC.displayA();	
		obC.displayB();
		obC.displayC();
	
	end sub
end module