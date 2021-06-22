class Int {
	private int i;
	
	Int() {}
	Int(int x)
	{
		i = x;
	}
	
	void inc()
	{
		i++;
	}
	
	int intValue() {
		return i;
	}
	
}

public class BoxingUnboxing {
	public static void main(String[] args) {
		int a = 10;
		Int or = new Int(a);		//Boxing
		Int or2 = a;				//AutoBoxing
		or2.inc();
		a = or2.intValue();			//Unboxing
		System.out.println("The incremented value of a is " + a);
	}
}

/*
	Here class Int is called a wrapper class as it wraps i inside it
*/
