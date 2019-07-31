using System;
using System.Collections.Generic;
using System.Text;

namespace Part7 {
    public class Employee {
        public int Number { get; set; }
        public string Name { get; set; }

        public Employee(int number, string name) {
            this.Number = number;
            this.Name = name;
        }
    }
}
