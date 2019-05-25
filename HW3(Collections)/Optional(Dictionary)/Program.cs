using System;
using System.Collections.Generic;

namespace Optional_Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Dictionary<string, List<Student>>();
            group.Add("TV01", new List<Student> { new Student("Shishman", 1998), new Student("Dvornik", 1997) });
            group.Add("TV02", new List<Student> { new Student("Goroshko", 1995), new Student("Zubrich", 1998), new Student("Soloma", 1996) });
            group.Add("TV03", new List<Student> { new Student("Novichenko", 1994), new Student("Zhmurckevich", 1997), new Student("Aslamova", 1993) });
            Actions.CodeGroup(group);
        }
    }
}
