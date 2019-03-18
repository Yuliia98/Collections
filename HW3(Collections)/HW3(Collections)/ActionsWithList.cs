using System;
using System.Collections.Generic;

namespace Task1_List_
{
    class ActionsWithList
    {
        public static List<int> ReadList()
        {

            var numbers = new List<int>();
            Console.WriteLine("Please enter int numbers to the list (enter 'stop' to finish)");
            var input = Console.ReadLine();
            while (input != "stop")
            {
                try
                {
                    numbers.Add(int.Parse(input ?? throw new InvalidOperationException()));

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Incorrect input: {ex.Message}");
                }
                input = Console.ReadLine();
            }
            return numbers;
        }

        public static void OutputList(List<int> array)
        {
            Console.WriteLine("Your list is:");
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }

        public static void OutputDescendingList(List<int> array)
        {
            array.Sort();
            array.Reverse();
            Console.WriteLine("\nYour descending list is:");
            foreach (var value in array)
            {
                Console.Write($"{value} ");
            }
        }

        public static void OutputShortList(List<int> array)
        {
            if (array.Count > 2)
            {
                array.RemoveRange(1, array.Count - 2);
                Console.WriteLine("\nYour short list is:");
                foreach (var value in array)
                {
                    Console.Write($"{value} ");
                }
            }
            else
            {
                Console.WriteLine("\nUnfortunately, size of your list is less than 2");
            }
        }
    }
}
