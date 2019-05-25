using System;

namespace Task1_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = ActionsWithList.ReadList();
            ActionsWithList.OutputList(numbers);
            ActionsWithList.OutputDescendingList(numbers);
            ActionsWithList.OutputShortList(numbers);
            
        }
    }
}
