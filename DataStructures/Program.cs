using DataStructures.LinkedList;
using Recursion;
class Program
{
    // Main Method 
    static void Main()
    {

        SinglyLinkedList<string> customSinglyLinkedList = new SinglyLinkedList<string>();

        customSinglyLinkedList.AddToFront("a");
        customSinglyLinkedList.AddToFront("b");
        customSinglyLinkedList.AddToFront("c");
        customSinglyLinkedList.AddToEnd("d");
        customSinglyLinkedList.AddToEnd("e");

        foreach (string s in customSinglyLinkedList)
        {
            Console.WriteLine(s);
        }

        // Console.WriteLine(FibonacciSeries.FindNthFibonacciTerm(10));

        //Console.WriteLine(TaylorSeries.RecursiveCall(3, 10));

        //Recursion.Recursion.SimpleRecursiveFunction(10);

        Console.ReadKey();
    }
}