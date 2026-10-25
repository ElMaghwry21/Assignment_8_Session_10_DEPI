using System.Collections;

namespace Assignment_8_Session_10_DEPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Before Sorting: " + string.Join(", ", numbers));

            Assignment_8_Session_10_DEPI.BubbleSortOptimizer.Sort(numbers);

            Console.WriteLine("After Sorting:  " + string.Join(", ", numbers));


            var intRange = new Range<int>(10, 50);

            Console.WriteLine($"Is 25 in range? {intRange.IsInRange(25)}"); 
            Console.WriteLine($"Is 55 in range? {intRange.IsInRange(55)}"); 
            Console.WriteLine($"Range Length: {intRange.Length()}");


            ArrayList numbersList = new ArrayList { 10, 20, 30, 40, 50 };

            Console.WriteLine("Before Reverse: " + string.Join(", ", numbersList.ToArray()));

            ArrayListReverser.Reverse(numbersList);

            Console.WriteLine("After Reverse:  " + string.Join(", ", numbersList.ToArray()));
        }
    }
}
