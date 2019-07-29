﻿using System;
using System.Collections.Generic;

namespace Practice_Csharp_Part_3 {
    class Program {
        static void Main(string[] args) {
            
            // City list
            var list = new List<string> {
                "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Canberra", "Hong kong",
            };

            // Exists
            var exists1 = list.Exists(s => s[0] == 'A');
            var exists2 = list.Exists(s => s.Contains('a'));
            Console.WriteLine(exists1);
            Console.WriteLine(exists2);
            Console.WriteLine("--------------------");

            // Find
            var name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);
            Console.WriteLine("--------------------");

            // FindIndex
            var index = list.FindIndex(s => s == "London");
            Console.WriteLine(index);
            Console.WriteLine("--------------------");

            // FindAll
            var names = list.FindAll(s => s.Length >= 3);
            foreach (var n in names) {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------");

            // RemoveAll
            var removedCount = list.RemoveAll(s => s.Contains("on"));
            Console.WriteLine(removedCount);
            Console.WriteLine("--------------------");

            // ForEach
            list.ForEach(s => Console.WriteLine(s));
            //list.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");

            // ConvertAll
            var lowerList = list.ConvertAll(s => s.ToLower());
            lowerList.ForEach(Console.WriteLine);

            var upperList = list.ConvertAll(s => s.ToUpper());
            upperList.ForEach(Console.WriteLine);
            Console.WriteLine("--------------------");
        }
    }
}
