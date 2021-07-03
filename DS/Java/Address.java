import java.util.Scanner;

class AddressOf {
    int a;
}

public class Address {
    public static void main(String[] args) {
        Integer i = 10;     //Autoboxing
        System.out.println("i = " + i);  //Unboxing

        Scanner sc = new Scanner(System.in);
        System.out.println("sc = " + sc);

        AddressOf ob = new AddressOf();
        System.out.println("ob = " + ob);
    }
}