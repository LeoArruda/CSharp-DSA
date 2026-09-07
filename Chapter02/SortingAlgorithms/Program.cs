namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] selectionValues = { -11, 12, -42, 1, 0, 90, 68, 6, -9, 18, -4, 2, 10 };
            SelectionSort.Sort(selectionValues);
            Console.WriteLine("Selection Sorted array: " + string.Join(", ", selectionValues));

            int[] insertionValues = { -11, 12, -42, 1, 0, 90, 68, 6, -9, 18, -4, 2, 10 };
            InsertionSort.Sort(insertionValues);
            Console.WriteLine("Insertion Sorted array: " + string.Join(", ", insertionValues));

            int[] BubbleValues = { -11, 12, -42, 1, 0, 90, 68, 6, -9, 18, -4, 2, 10 };
            BubbleSort.Sort(BubbleValues);
            Console.WriteLine("Bubble Sorted array:    " + string.Join(", ", BubbleValues));

            int[] QuickValues = { -11, 12, -42, 1, 0, 90, 68, 6, -9, 18, -4, 2, 10 };
            QuickSort.Sort(QuickValues);
            Console.WriteLine("Quick Sorted array:     " + string.Join(", ", QuickValues));
        }
    }
}
