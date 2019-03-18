using System;
using System.Collections.Generic;

namespace Optional_Dictionary_
{
    class Actions
    {
        public static void CodeGroup(Dictionary<string, List<Student>> dict)
        {
            Console.WriteLine("Enter code group. Or enter 'exit' to exit");
            var input = Console.ReadLine();
            while (input != "exit")
            {
                if (dict.ContainsKey(input ?? throw new InvalidOperationException()))
                {
                    dict.TryGetValue(input, out var listOfGroup);
                    if (listOfGroup != null)
                        foreach (var value in listOfGroup)
                        {
                            Console.WriteLine($"{value.Surname}:{value.Date} ");
                        }
                }
                else
                {
                    Console.WriteLine("There is no group with this code. Do you want added it (y/n)");
                    var answer = Console.ReadLine();
                    dict[input] = new List<Student>();
                    if (answer == "y")
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter enter students in format: Surname1:Birthday1, Surname2:Bithday2");
                            var data = Console.ReadLine();
                            try
                            {
                                var students = data?.Split(',');
                                foreach (var student in students)
                                {
                                    var dataOfStud = student.Split(':');
                                    dict[input].Add(new Student(dataOfStud[0], int.Parse(dataOfStud[1])));
                                }
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
                Console.WriteLine("Enter code group. Or enter 'exit' to exit");
                input = Console.ReadLine();
            }
        }
    }
}