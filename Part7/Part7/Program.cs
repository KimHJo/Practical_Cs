using System;
using System.Collections.Generic;
using System.Linq;

namespace Part7 {
    class Program {
        static void Main(string[] args) {
            var flowerDict = new Dictionary<string, int>() {
                //["sunflower"] = 400,
                { "pansy", 300 },
                {"sumflower", 400 },
                {"tulip", 500 },
                //[key] = value...
            };

            // 딕셔너리 생성
            var employeeDict = new Dictionary<int, Employee>() {
                { 100, new Employee(100,"이몽룡") },
                //{ key, user class },
            };

            // 딕셔너리에 추가
            flowerDict["violet"] = 600;
            employeeDict[101] = new Employee(101, "김향단");

            flowerDict.Add("rose", 200);
            employeeDict.Add(102, new Employee(102, "춘향이"));

            // 값 읽기
            var flowerPrice = flowerDict["violet"];
            var employeeNumber = employeeDict[102].Number;

            // 딕셔너리에 키가 존재하는지 체크
            var key = "rose";
            if (flowerDict.ContainsKey(key)) {
                var price = flowerDict[key];
            }

            // 딕셔너리에서 제거 , 리턴값은 true , false
            var result = flowerDict.Remove("rose");

            //  딕셔너리의 전체 값 읽기
            //foreach( var item in flowerDict)
            foreach (KeyValuePair<string, int> item in flowerDict)
                Console.WriteLine("{0} = {1}", item.Key, item.Value);

            // 딕셔너리와 LINQ 사용
            var average = flowerDict.Average(x => x.Value);
            var sum = flowerDict.Sum(x => x.Value);
            var items = flowerDict.Where(x => x.Key.Length <= 6);

            // 키값 읽기
            foreach (var k in flowerDict.Keys)
                Console.WriteLine(k);

            // 리스트를 딕셔너리로, 딕셔너리를 리스트로
            var employees = new List<Employee>();
            var employeeDict2 = employees.ToDictionary(emp => emp.Number);

            // 딕셔너리를 새로운 딕셔너리로
            var newFlowerDict = flowerDict.Where(x => x.Value >= 300)
                                          .ToDictionary(flower => flower.Key, flower => flower.Value);

            // 사용자 지정 클래스를 키로 이용 

        }
    }

    public class MonthDay {
    }

    public class Employee {
        public int Number { get; set; }
        public string Name { get; set; }

        public Employee(int number, string name) {
            this.Number = number;
            this.Name = name;
        }
    }
}
