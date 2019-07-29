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

        public void ShowAllDigitResult(string msg) {
            Console.WriteLine("---- Show All+Digit Methode Result ----");
            var isAllDigit = msg.All(c => Char.IsDigit(c));
            if (isAllDigit)
                Console.WriteLine(isAllDigit);
        }

        public void ShowIndexOfResult(string str, string msg) {
            Console.WriteLine("---- Show IndexOf Methode Result ----");
            var target = str.IndexOf(msg);
            Console.WriteLine(target);
        }

        public void ShowSubStringResult(string str, string msg) {
            Console.WriteLine("---- Show SubString Methode Result ----");
            var target = str.Substring(str.IndexOf(msg) + msg.Length);
            Console.WriteLine(target);
        }

        public void ShowSubString2Result(string str, string msg) {
            Console.WriteLine("---- Show SubString(start-end) Methode Result ----");

            var startIndex = str.IndexOf(msg) + msg.Length;
            var endIndex = str.IndexOf(";", startIndex);
            var target = str.Substring(startIndex, endIndex - startIndex);
            Console.WriteLine(target);
        }

        public void ShowTrimResult(string str) {
            Console.WriteLine("---- Show Trim(start, end) Methode Result ----");
            var trim = str.Trim();
            var startTrim = str.TrimStart();
            var endTrim = str.TrimEnd();

            Console.WriteLine(trim);
            Console.WriteLine(startTrim);
            Console.WriteLine(endTrim);
        }

        public void ShowRemoveResult(string str, int start, int end) {
            Console.WriteLine("---- Show Remove Methode Result ----");
            var target = str.Remove(start, end);
            Console.WriteLine(target);
        }
        public void ShowInsertResult(string str, int index, string text) {
            Console.WriteLine("---- Show Insert Methode Result ----");
            var target = str.Insert(index, text);
            Console.WriteLine(target);
        }

        public void ShowReplaceResult(string str, string targetText, string text) {
            Console.WriteLine("---- Show Replace Methode Result ----");
            var target = str.Replace(targetText, text);
            Console.WriteLine(target);
        }
    }
}
