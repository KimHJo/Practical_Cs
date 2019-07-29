using System;
using System.Collections.Generic;
using System.Text;

namespace Part5 {
    class Class_String {

        public void Showresult() {
            var str1 = "Windows";
            var str2 = "WINDOWS";

            if (String.Compare(str1, str2, ignoreCase: true) == 0)
                Console.WriteLine("같다.");
            else
                Console.WriteLine("다르다.");
        }
    }
}
