using System;
using System.Linq;
using System.Collections.Generic;

namespace Optional_Dictionary_
{
    class Actions
    {
        public static void CodeGroup(Dictionary<string, List<Student>> dict)
        {
            var listOfGroup = new List<Student>();
            Console.WriteLine("Enter code group. Or enter 'exit' to exit");
            var input = Console.ReadLine();
            while (input != "exit")
            {
                if (dict.ContainsKey(input))
                {
                    dict.TryGetValue(input, out listOfGroup);
                    foreach (var value in listOfGroup)
                    {
                        Console.WriteLine($"{value.Surname}:{value.Date} ");
                    }
                }
                else
                {
                    Console.WriteLine("There is no group with this code. Do you want added it (y/n)");
                    var answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        dict[input] = new List<Student>();
                        while (true)
                        {
                            Console.WriteLine("Enter students in format: Surname1:Birthday1, Surname2:Bithday2");
                            var data = Console.ReadLine();
                            try
                            {
                                var students = data.Split(',');
                                foreach (var student in students)
                                {
                                    var dataOfStud = student.Trim().Split(':');
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
