﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = ActionsWithDictionary.ReadDictionary();
            ActionsWithDictionary.OutputDictionary(group);

        }
    }
}
