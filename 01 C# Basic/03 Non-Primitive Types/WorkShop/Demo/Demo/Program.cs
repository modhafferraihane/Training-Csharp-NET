﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
			
            var person = new Person { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }
        public static void Increment(int value)
        {
            value += 10;
            //Console.WriteLine(number);
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
