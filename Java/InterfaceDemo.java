import java.util.Scanner;

interface Shape {
    float PI = 3.14F;

    void input();
    float area();
}

class Circle implements Shape {
    private float rad;
    public float test = 32.0F;
    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter radius: ");
        rad = sc.nextFloat();
        sc.close();
    }

    public float area() {
        return PI * rad * rad;
    }
}

class Rectangle {

}

class Triangle {

}

class InterfaceDemo {
    public static void main(String[] args) {
        Shape s = new Circle();
        s.input();
        System.out.println("The area of circle is " + s.area());
    }
}