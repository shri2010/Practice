using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inputs = Console.ReadLine().Split(' ');

            var elementToFind = Convert.ToInt32(Console.ReadLine());

            List<int> data = new List<int>();

            foreach (var input in inputs)
            {
                data.Add(Convert.ToInt32(input));
            }

            var output = FindAnElement(data, elementToFind);
            if (output == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"Found at {output}");
            }
            output = -1;
            output = FindAnElementUsingBinarySearch(data, elementToFind);
            if (output == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"Found at {output}");
            }

            Console.ReadLine();
        }

        private static int FindAnElement(List<int> data, int elementToFind)
        {

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == elementToFind)
                {

                    return i;
                }
            }
            return -1;

        }

        private static int FindAnElementUsingBinarySearch(List<int> data, int elementToFind)
        {

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == elementToFind)
                {

                    return i;
                }
            }
            return -1;

        }

        private static int BinarySearch(List<int> data, int key)
        {
            int low = 0;

            int high = data.Count;

            while (low <= high)
            {

                int mid = (low + high) / 2;

                if (key == data[mid])
                {
                    return mid;
                }
                else if (key < data[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;

        }
    }
}
