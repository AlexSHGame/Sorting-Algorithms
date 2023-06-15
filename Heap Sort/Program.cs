namespace Heap_Sort
{
    internal class HeapSort
    {
        /*Methods*/
        // 1 - Main function to sort a given array
        public void Sort(int[] array)
        {
            int arrayLength = array.Length;
            // Build an initial array
            for (int i = (arrayLength/ 2) - 1; i >= 0; i--)
            {
                MaxHeapify(array, i, arrayLength);
            }
            
            // Exchange max (= first) element and place it at the top of the array
            for (int i = arrayLength - 1; i > 0; i--)
            {
                Swap(ref array[0], ref array[i]);
                MaxHeapify(array, 0, i);
            }
        }

        // 2 - Utility functions
        // 2.1 - Swap two elements
        public void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        // 2.2 - Print an array
        public void PrintArray(int[] array)
        {
            foreach (int i in array)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }
        // 2.3 - Heapify an array in ascending order
        public void MaxHeapify(int[] array, int i, int length)
        {
            /* Fields */
            int largestIndex = i;
            int leftChildIndex = (i * 2) + 1;
            int rightChildIndex = (i * 2) + 2;

            if (leftChildIndex < length && array[leftChildIndex] > array[largestIndex])
                largestIndex = leftChildIndex;
            if (rightChildIndex < length && array[rightChildIndex] > array[largestIndex])
                largestIndex = rightChildIndex;
            if (largestIndex != i)
            {
                Swap(ref array[i], ref array[largestIndex]);
                MaxHeapify(array, largestIndex, length);
            }
        }

        static void Main(string[] args)
        {
            int[] myUnsortedArray = { 34, 3, 89, 99, 1, 0, 4, -5, 67, 66};

            HeapSort myHeap = new();
            Console.WriteLine("The initial unsorted array:"); myHeap.PrintArray(myUnsortedArray);
            myHeap.Sort(myUnsortedArray);
            Console.WriteLine("The sorted array:"); myHeap.PrintArray(myUnsortedArray);
            Console.ReadLine();
        }
    }
}