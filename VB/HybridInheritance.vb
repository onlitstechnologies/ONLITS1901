REM									PROGRAM TO DEMONSTRATE INHERITANCE (HYBRID INHERITANCE)

Class A	
	protected a As Integer;
		
	Public Sub New()
		a=10
	End Sub
		
	Public Sub DisplayA()
		Console.WriteLine("a=" & a)
	End Sub
End Class

Class B 
	Inherits A
	
	Protected b As Integer
	
	Public Sub New()
		b=20
	End Sub
	
	Public Sub DisplayB()
		Console.WriteLine("b=" & b)
	End Sub
End Class

Class C 
	Inherits A

	Private c As Integer
	Public New()
		c=30
	End Sub
		
	Public Sub DisplayC()
		Console.WriteLine("c=" & c)
	End Sub
End Class

class D : public B, public C
{
		int d;
	public:
		D()
		{
			d=40;
		}
		
		void displayD()
		{
			cout<<"d="<<d<<endl;
		}
};

int main()
{
	D obD;
	
	obD.displayA();
	obD.displayB();
	obD.displayC();
	obD.displayD();
	
	return 0;
}


/*
	Function overloading is found within a single class
	Function overriding is found between two different classes
	
	Access specifier/modifier
	1. private		- Can be used within the class
	2. public		- Can be used anywhere
	3. protected	- Can be used with the class and it derived classes
	
	
	Only public and protected member can be inherited
	
	public
	protected
	private
	
	Work on different situations.
	
*/
