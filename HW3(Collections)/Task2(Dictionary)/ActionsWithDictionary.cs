using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_Dictionary_
{
    class ActionsWithDictionary
    {
        public static Dictionary<string, int> ReadDictionary()
        {
            var group = new Dictionary<string, int>();
            Console.WriteLine("Please enter students and their marks (enter 'stop' to finish).\n" +
                              "Format is: Surname (one word): Mark (one digtit from 0 to 5) and ':' is a separator here\n" +
                              "ie. Ivan:5");
            string input;
            do
            {
                input = Console.ReadLine();
                if (input != "stop")
                {
                    try
                    {
                        var words = input?.Trim().Split(':');
                        int.TryParse(words[1], out var mark);
                        if (mark > 0 && mark < 6)
                        {
                            group.Add(words[0], mark);
                        }
                        else
                        {
                            Console.WriteLine("Mark should be from 1 to 5. Desired format: Surname:Mark");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrect input - desired format: Surname:Mark. Or input 'stop' to to finish!");
                    }
                }
            } while (input != "stop");
            return group;
        }

        public static void OutputDictionary(Dictionary<string, int> valuePairs)
        {
            Console.WriteLine("Enter surname to see student's mark or mark to see all students with this mark");
            Console.WriteLine("Or enter 'exit' to exit");
            string search;
            do
            {
                search = Console.ReadLine();
                try
                {
                    if (valuePairs.ContainsKey(search ?? throw new InvalidOperationException()))
                    {
                        valuePairs.TryGetValue(search, out var value);
                        Console.WriteLine($"Student {search} has mark {value} ");
                    }
                    else
                    {
                        var value = int.Parse(search);
                        if (valuePairs.ContainsValue(value))
                        {
                            var keysValues = valuePairs.Where(p => p.Value == value).Select(p => p.Key);
                            Console.WriteLine($"Students with mark {search}: ");
                            foreach (var key in keysValues)
                                Console.WriteLine(key);
                        }
                        else
                        {
                            Console.WriteLine($"There is no student or mark in this dictionary with mark {value}");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine($"There is no student or mark in this dictionary with '{search}' parameter\n"
                        + "Desired format is Surname (one word) or Mark (one digit)!");
                }
            } while (search != "exit");
        }
    }
}