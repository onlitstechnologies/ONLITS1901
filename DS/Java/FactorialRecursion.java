public class FactorialRecursion {
    static int factorial(int n) {
        //Base/exit condition/case
        if(n<=1)
            return 1;
        //recursive call
        int fact = n * factorial(n-1);
        return fact;
    }
    public static void main(String[] args) {
        int n = 5;
        System.out.println(n + "! = " + factorial(n));
    }
}

/*
    O(n)
*/