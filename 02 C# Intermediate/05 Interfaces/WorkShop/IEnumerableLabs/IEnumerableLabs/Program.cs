﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 1, 2, 3 };
            DisplayItems(collection);
        }

        static void DisplayItems(IEnumerable<int> items)
        {
            IList
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
