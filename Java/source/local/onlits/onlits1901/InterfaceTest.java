interface Interface {
	int a=10;
	public void display();
}

class InterfaceTest implements Interface {
	public void display()
	{
		System.out.println("Testing interface");
	}
	public static void main(String[] args) {
		InterfaceTest i = new InterfaceTest();
		i.display();
	}
}
