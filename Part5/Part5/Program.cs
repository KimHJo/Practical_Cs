using System;

namespace Part5 {
    class Program {
        static void Main(string[] args) {
            var cs = new Class_String();


            cs.ShowCompareResult("Window", "WINDOW");

            var str = "Visual Basic C#";
            cs.ShowStartWithResult(str, "Visual");

            var str2 = "C# Program is funny!";
            cs.ShowContainsResult(str2, "Program");

            var str3 = "The quick brown fox jumps over the lazy dog";
            cs.ShowAnyResult(str3, 't');
        }
    }
}
