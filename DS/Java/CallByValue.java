public class CallByValue {
	public static void main(String[] args) {
		int a = 20, b = 10;
		swap(a, b);		//Error about static content
		System.out.println("The values of a and b after swapping are " + a + ", " + b + ", respectively.");
	}
	static void swap(int x, int y) {
		int t = x;
		x = y;
		y = x;	
	}
}
