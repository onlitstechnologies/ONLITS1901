import java.io.*;
class DifferentInputHEBR {
	public static void main(String[] args) throws IOException {

		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		String name = br.readLine();
		System.out.println("HI, " + name + ".");
		
		int age = Integer.parseInt(br.readLine());
		System.out.println(age);
		
		float salary = Float.parseFloat(br.readLine());
		System.out.println(salary);
	}
}
