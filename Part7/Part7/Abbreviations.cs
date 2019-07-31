﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Part7 {
    class Abbreviations {
        private Dictionary<string, string> _dict = new Dictionary<string, string>();

        public Abbreviations() {
            var lines = File.ReadAllLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('='))
                         .ToDictionary(x => x[0], x => x[1]);
        }

        public void Add(string abbr, string korean) {
            _dict[abbr] = korean;
        }

        public string this[string abbr] {
            get {
                return _dict.ContainsKey(abbr) ? _dict[abbr] : null;
            }
        }

        public string ToAbbreviation(string korean) {
            return _dict.FirstOrDefault(x => x.Value == korean).Key;
        }

        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring) {
            foreach (var item in _dict)
                if (item.Value.Contains(substring))
                    yield return item;
        }

    }
}
