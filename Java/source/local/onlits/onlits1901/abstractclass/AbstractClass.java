package local.onlits.onlits1901.abstractclass;
import java.util.Scanner;

abstract class Shape {
    public final float PI = 3.14F;
    int x;

    public abstract void input();
    public abstract float area();
    public void test() {
        System.out.println("This is a test method!");
    }
}

class Circle extends Shape {
    private float rad;

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

class AbstractClass {
    public static void main(String[] args) {
        Shape s = new Circle();
        s.input();              //Runtime Polymorphism
        System.out.println("The area of circle is " + s.area()); //Runtime Polymorphism
    }
}