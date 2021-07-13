package local.onlits.onlits1901.interfacedemo;

import java.util.Scanner;

interface Shape {
    float PI = 3.14F;
    void input();

    float area();
}

interface Shape2 {

}

class Circle implements Shape, Shape2 {     //Multiple Inheritance in Java
    private float rad;
    public float test = 32.0F;

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter radius: ");
        rad = sc.nextFloat();
        //sc.close();
    }

    public float area() {
        return PI * rad * rad;
    }
}

class Rectangle {

}

class Triangle implements Shape {
    float a, b, c, s;

    public void input() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the value of a: ");
        a = sc.nextFloat();
        System.out.print("Enter the value of b: ");
        b = sc.nextFloat();
        System.out.print("Enter the value of c: ");
        c = sc.nextFloat();
    }

    public float area() {
        s = (a + b + c)/2;
        return (float) Math.sqrt(s * ((s-a) * (s-b) * (s-c)));
    }
}

class InterfaceDemo {
    public static void main(String[] args) {
        Shape s = new Circle();
        s.input();      //Runtime Polymorphism
        System.out.println("The area of circle is " + s.area());    //Runtime Polymorphism

        s = new Triangle();
        s.input();          //Runtime Polymorphism
        System.out.printf("The area of triangle is %f ", s.area());     //Runtime Polymorphism
    }
}