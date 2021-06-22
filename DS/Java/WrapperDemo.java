public class WrapperDemo {
	public static void main(String[] args) {
		int a = 20;
		Integer or = new Integer(a);	//Boxing
		Integer or2;
		or2 = a;
		int b = or2.intValue();			//Unboxing
		System.out.println(b);
	}
}

/*
	Wrapper class - A class that hides a basic type in itself
*/
