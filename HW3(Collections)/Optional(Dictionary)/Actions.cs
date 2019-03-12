using System;
using System.Collections.Generic;

namespace Optional_Dictionary_
{
    class Actions
    {
        public static void CodeGroup(Dictionary<string, List<Student>> dict)
        {
            var input = "";
            var answer = "";
            var data = "";

            var listOfGroup = new List<Student>();
            Console.WriteLine("Enter code group. Or enter 'exit' to exit");
            input = Console.ReadLine();
            while (input != "exit")
            {

                if (dict.ContainsKey(input) == true)
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
                    answer = Console.ReadLine();
                    dict[input] = new List<Student>();
                    if (answer == "y")
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter enter students in format: Surname1:Birthday1, Surname2:Bithday2");
                            data = Console.ReadLine();
                            try
                            {
                                string[] students = data.Split(',');
                                for (int i = 0; i < students.Length; i++)
                                {
                                    string[] dataOfStud = students[i].Split(':');
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

            };
        }
    }
}
