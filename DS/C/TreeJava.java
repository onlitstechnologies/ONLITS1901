class node {
	int number;
	node left;
	node right;
	
	node() {}
	node(int n) {
		number = n;
		left = null;
		right = null;
	}
	
	node createNode(int no, int left, int right) {
		node n = new node();
		n.number = no;
		n.left = new node(left);
		n.right = new node(right);
		return n;
	}
	void display(node r) {
		System.out.println("    " + r.number);
		System.out.println(" /    \\");
		System.out.println(r.left.number+ "\t" + r.right.number);
	}
}
class TreeJava {
	public static void main(String[] args) {
		node root = new node();
		root = root.createNode(10,20,30);
		root.display(root);
	}
}
