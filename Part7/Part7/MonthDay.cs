using System;
using System.Collections.Generic;
using System.Text;

namespace Part7 {
    public class MonthDay {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public MonthDay(int month, int day) {
            this.Month = month;
            this.Day = day;
        }

        public override bool Equals(object obj) {
            var other = obj as MonthDay;
            if (other == null)
                throw new ArgumentException();
            return this.Day == other.Day && this.Month == other.Month;
        }

        public override int GetHashCode() {
            return Month.GetHashCode() * 31 + Day.GetHashCode();
        }
    }
}
