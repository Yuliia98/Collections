using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_Dictionary_
{
    class ActionsWithDictionary
    {
        public static Dictionary<string, int> ReadDictionary()
        {
            var input = " ";
            var group = new Dictionary<string, int>();
            Console.WriteLine("Please enter students and their marks (enter 'stop' to finish)");
            input = Console.ReadLine();
            while (input != "stop")
            {
                try
                {

                    string[] words = input.Split(':');
                    var mark = int.Parse(words[1] ?? throw new InvalidOperationException());
                    if (mark > 0 && mark < 6)
                    {
                        group.Add(words[0], mark);
                    }
                    else
                    {
                        Console.WriteLine("Mark should be from 1 to 5. Desired format: Surname:Mark");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Incorrect input: {ex.Message}" + "Desired format: Surname:Mark ");
                }
                input = Console.ReadLine();
            };
            return group;
        }

        public static void OutputDictionary(Dictionary<string, int> valuePairs)
        {

            var search = "";
            var value = 0;
            do
            {
                Console.WriteLine("Enter surname to see student's mark or mark to see all students with this mark");
                Console.WriteLine("Or enter 'exit' to exit");
                search = Console.ReadLine();
                try
                {
                    if (valuePairs.ContainsKey(search) == true)
                    {
                        valuePairs.TryGetValue(search, out value);
                        Console.WriteLine($"Student {search} has mark {value} ");
                    }
                    else if (valuePairs.ContainsValue(int.Parse(search)) == true)
                    {
                        var keysValues = valuePairs.Where(p => p.Value == int.Parse(search)).Select(p => p.Key);
                        Console.WriteLine($"Students with mark {search}: ");
                        foreach (var key in keysValues)
                            Console.WriteLine(key);
                    }
                }
                catch
                {
                    Console.WriteLine("There is no student or mark in this dictionary");
                }

            } while (search != "exit");

        }
    }
}
