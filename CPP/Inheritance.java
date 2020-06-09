//									PROGRAM TO DEMONSTRATE INHERITANCE (SINGLE INHERITANCE)

class A					//Base Class
{
		int a;
	
		A()
		{
			a=10;
		}
};

class B extends A			//Derived Class (Class B inherits the public properties of Class A)
{
		int b;
	
		B()
		{
			b=20;
		}
		void displayAB()
		{
			System.out.println("a=" + a + ", b=" + b);
		}	
};

public class Inheritance
{ 
	public static void main(String[] args)
	{
		B obB = new B();
	
		obB.displayAB();
	}
}


/*
	In C++ object may be created statically (Compile-time) or dynamically (Runtime) 
	whereas in java it is created dynamically
	
*/
