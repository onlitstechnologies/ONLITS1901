public class FibonacciRecursion {
    int a;

    static int fibonacci(int n) {
        // Base Case (case that will terminate this function)
        if (n <= 1)
            return n;

        // Recursive Call
        int fn = fibonacci(n - 1) + fibonacci(n - 2);
        System.out.print(fn + " ");
        return fn;
    }

    public static void main(String[] args) {
        // FibonacciRecursion or = new FibonacciRecursion();
        // or.fibonacci(5);
        System.out.println(fibonacci(5));

        //Code for printing series
        // for (int i = 1; i <= 10; i++)
        //     System.out.print(fibonacci(i) + " ");
        // System.out.println();
    }
}
