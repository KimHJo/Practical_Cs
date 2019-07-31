using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;

namespace Part7 {
    class Program {
        static void Main(string[] args) {
            // 연습문제 7.1
            // Cozy lummox gives smart squid who asks for job pen의 알파벳 문자가 몇 번씩 나타나는지 세는 프로그램 작성
            // 반드시 딕셔너리 사용
            var str = "Cozy lummox gives smart squid who asks for job pen";

            var alphabetDict = new Dictionary<char, int>();

            var splitStr = str.Split(' ');
            int count;

            foreach(var item in splitStr) {
                count = 0;
                for(int i = 0; i < 'a'-'z'; i++) {
                    foreach(var c in item) {
                        if (item.Contains((char)i))
                            alphabetDict[(char)i] = count;
                        else
                            alphabetDict.Add((char)i, count);
                    }
                }
            }

            foreach (var item in alphabetDict) {
                Console.WriteLine("'{0}' : {1}", item.Key, item.Value);
            }


            /*
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
            var datesDict = new Dictionary<MonthDay, string> {
                { new MonthDay(6, 6), "현충일" },
                {new MonthDay(8, 15), "광복절" },
            };

            var md = new MonthDay(8, 15);
            var s = datesDict[md];
            Console.WriteLine(s);

            // 키의 중복 문제 허용
            var sameKeyValueDict = new Dictionary<string, List<string>>() {
                {"PC", new List<string>{"개인 컴퓨터", "프로그램 카운터", } },
                {"CD", new List<string>{"컴팩트 디스크", "캐시 디스팬서" } },
            };

            var ke = "EC";
            var kv = "전자상거래";
            if (sameKeyValueDict.ContainsKey(ke))
                sameKeyValueDict[ke].Add(kv);
            else
                sameKeyValueDict[ke] = new List<string> { kv, };

            foreach (var item in sameKeyValueDict) {
                foreach (var term in item.Value) {
                    Console.WriteLine("{0} : {1}", item.Key, term);
                }
            }


            var abbrs = new Abbreviations();

            abbrs.Add("IOC", "국제 올림픽 위원회");
            abbrs.Add("NPT", "핵 확산 방지조약");

            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names) {
                var fullName = abbrs[name];
                if (fullName == null)
                    Console.WriteLine("{0}을/를 찾을 수 없습니다.", name);
                else
                    Console.WriteLine("{0} = {1}", name, fullName);
            }

            var korean = "동남아시아 국가 연합";
            var abbreviation = abbrs.ToAbbreviation(korean);

            if (abbreviation == null)
                Console.WriteLine("{0}을/를 찾을 수 없습니다.", korean);
            else
                Console.WriteLine("{0} = {1}입니다.", korean, abbreviation);
            Console.WriteLine();

            foreach (var item in abbrs.FindAll("국제")) {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }*/
        }
    }
}