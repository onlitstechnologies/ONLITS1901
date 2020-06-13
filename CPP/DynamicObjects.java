class A
{
	private int a;
		
	public A()
	{
		a=10;
	}
	void displayA()
	{
		System.out.println("a=" + a);
	}
};


class DynamicObjects
{
	public static void main(String[] args)
	{
		//A obA;			//Statically or compile time
		A obA = new A();	//Dynamically or run time using pointer to object
	
		obA.displayA();
	
	}
}


// In Java the main function also has to reside in class
// And usually the name of the file is same as that of the class in which main is defined
//In java all the objects are created dynamically


//command line arguments
//you will find it in your C book in pre-processor chapter