namespace Bubble_Sort
{
    internal class BubbleSort
    {
        /// <summary>
        /// Main function to sort a given array (in ascending order) 
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) // i is a simple iterator
            {
                for (int j = 0; j < array.Length - 1 - i; j++) // j is an iterator throughout a given array
                    if (array[j] > array[j + 1])
                        Swap(ref array[j], ref array[j + 1]);
            }
        }

        /// <summary>
        /// Swap two elements
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        /// <summary>
        /// Print an array
        /// </summary>
        /// <param name="array"></param>
        public void PrintArray(int[] array)
        {
            foreach (int i in array)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] myUnsortedArray = { 34, 3, 89, 99, 1, 0, 4, -5, 67, 66 };

            BubbleSort mySort = new();
            Console.WriteLine("The initial unsorted array:"); mySort.PrintArray(myUnsortedArray);
            mySort.Sort(myUnsortedArray);
            Console.WriteLine("The sorted array:"); mySort.PrintArray(myUnsortedArray);
            Console.ReadLine();
        }
    }
}