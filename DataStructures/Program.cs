using DataStructures.LinkedList;
using DataStructures.Strings;
using Recursion;
class Program
{
    // Main Method 
    static void Main()
    {
        #region Strings

        StringExercise.ConvertStringToNumber("123456789");
        #endregion



        #region Singly Linked List
        /*  // Custom Singly Linked List
       SinglyLinkedList<string> singlyList = new SinglyLinkedList<string>();

       singlyList.AddToFront("a");
       singlyList.AddToFront("b");
       singlyList.AddToFront("c");
       singlyList.AddToEnd("d");
       singlyList.AddToEnd("e");
       singlyList.Remove("b");

       var arr = new string[7];
       singlyList.CopyTo(arr, 2);

       foreach (string s in singlyList)
       {
           Console.WriteLine(s);
       }

       //Console.WriteLine($"Contains b: " + singlyList.Contains("b"));
       //Console.WriteLine($"Contains b: " + singlyList.Contains("c")); */
        #endregion

        //Console.WriteLine(FibonacciSeries.FindNthFibonacciTerm(10));
        //Console.WriteLine(TaylorSeries.RecursiveCall(3, 10));

        //Recursion.Recursion.SimpleRecursiveFunction(10);

        Console.ReadKey();
    }
}