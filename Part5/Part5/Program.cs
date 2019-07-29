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

            var str4 = "1234124124699";
            cs.ShowAllDigitResult(str4);

            var str5 = "Novelist=김만중;BestWork=구운몽";
            cs.ShowIndexOfResult(str5, "BestWork=");

            cs.ShowSubStringResult(str5, "BestWork=");

            var str6 = "Novelist=김만중;BestWork=구운몽;Born=1666";
            cs.ShowSubString2Result(str6, "BestWork=");

            var str7 = " non-whitespace characters ";
            cs.ShowTrimResult(str7);

            var str8 = "01234ABCD56789";
            cs.ShowRemoveResult(str8, 5, 3);

            var str9 = "01234";
            cs.ShowInsertResult(str9, 2, "abc");

            var str10 = "I hope you could come with us";
            cs.ShowReplaceResult(str10, "hope", "wish");
        }
    }
}
