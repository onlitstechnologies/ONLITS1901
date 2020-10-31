/*Program to traverse a linear array*/

public class Prog17 { 
	public static void main(String[] args) {
		int[] no = {56, 76, 5, 12, 99, 33, 20, 1, 101, 88};
		//int[] x = new int[10];  //This is how array is declared in Java
		int i;
	
		System.out.println("The array contains the following elements:");
	
		try {							//Exception Handling
			for(i=0; i<=10; i++) {
				System.out.println(no[i]);
			}
		}
		catch(Exception ex){}
		
		System.out.println("Program terminated normally!");
	}
}
