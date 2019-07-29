using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part5 {
    class Class_String {

        public void ShowCompareResult(string str1, string str2, bool ignorecase = true) {
            Console.WriteLine("---- Show Compare Methode Result ----");
            if (String.Compare(str1, str2, ignoreCase: ignorecase) == 0)
                Console.WriteLine("같다.");
            else
                Console.WriteLine("다르다.");
        }

        public void ShowStartWithResult(string msg, string str) {
            Console.WriteLine("---- Show StartWith Methode Result ----");
            if (str.StartsWith(str))
                Console.WriteLine(str + "로 시작합니다");
        }

        public void ShowContainsResult(string msg, string str) {
                        Console.WriteLine("---- Show Contains Methode Result ----");
            if (str.Contains(str))
                Console.WriteLine(str + "를 포함합니다.");
        }

        public void ShowAnyResult(string msg, char str) {
            Console.WriteLine("---- Show Any Methode Result ----");
            var isExists = msg.Any(c => Char.IsLower(str));
            Console.WriteLine(isExists);
        }
    }
}
