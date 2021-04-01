class Circumference {
	public static void main(String[] args) {
		float r=5.0F, c;
		MyLib m = new MyLib();
		c = 2 * m.pi() * r;
		System.out.println("The circumference is " + c);
	}
}

/*
	out is not an object of System class. Infact, it is an object
	of printstream class.
*/
