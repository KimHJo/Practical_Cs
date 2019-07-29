using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practice_Csharp_Part_3 {
    class LINQtoObj {

        public void ShowResult() {
            var list = new List<string> {
                "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Canberra", "Hong kong",
            };

            Console.WriteLine("---- WHERE & SELECT ----");
            var query = list.Where(l => l.Length >= 5)
                            .Select(l => l.ToLower());
            foreach (var q in query) {
                Console.WriteLine(q);
            }
            Console.WriteLine();

            Console.WriteLine("---- 지연실행 ----");
            query = list.Where(s => s.Length >= 5);
            foreach (var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine("---- change name Seoul to Busan ----");
            list[0] = "Busan";
            foreach(var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            Console.WriteLine("---- ConvertAll ToUpper ----");
            list = list.ConvertAll(s => s.ToUpper());
            list.ForEach(Console.WriteLine);

        }
    }
}
