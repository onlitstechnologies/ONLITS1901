import java.util.Scanner;

class DifferentInputHE {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		String name = scan.next();
		System.out.println("HI, " + name + ".");
		
		int age = scan.nextInt();
		System.out.println(age);
		
		float salary = scan.nextFloat();
		System.out.println(salary);
	}
}
