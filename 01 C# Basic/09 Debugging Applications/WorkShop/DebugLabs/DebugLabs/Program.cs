﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugLabs
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list), $"{nameof(list)} should not be null");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count),
                    $"{nameof(count)} should be between 1 and the number of the list");

            var tempList = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(tempList);
                smallests.Add(min);
                tempList.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
           
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }

    }
}
