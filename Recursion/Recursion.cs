namespace Recursion
{
    public class Recursion
    {
        public static void SimpleRecursiveFunction(int n)
        {
            if (n == 0) { return; }
            Console.WriteLine($"Print value of {n}");
            SimpleRecursiveFunction(n - 1);
        }

    }
}
