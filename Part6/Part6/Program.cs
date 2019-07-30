using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Part6 {
    class Program {
        static void Main(string[] args) {

            var books = new List<Book> {
                new Book { Title = "태평천하", Price = 400, Pages = 378 },
                new Book { Title = "운수 좋은 날", Price = 281, Pages = 212 },
                new Book { Title = "만세전", Price = 389, Pages = 201 },
                new Book { Title = "삼대", Price = 637, Pages = 464 },
                new Book { Title = "상록수", Price = 411, Pages = 276 },
                new Book { Title = "혈의 누", Price = 961, Pages = 666 },
                new Book { Title = "금수회의록", Price = 514, Pages = 268 },
            };

            //6.2.1 배열 또는 List<T>를 동일한 값으로 채운다
            var numbers = Enumerable.Repeat(-1, 20)
                                    .ToList();

            foreach (var item in numbers) {
                Console.WriteLine(item);
            }

            //6.2.2 배열 또는 List<T>에 연속된 값을 설정한다.
            var array = Enumerable.Range(1, 20)
                                  .ToArray();

            foreach(var item in array) {
                Console.WriteLine(item);
            }

            //6.3 컬렉션 집계
            //6.3.1 vudrbs
            var numberArray = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            var numberAverage = numberArray.Average();
            var bookAverage = books.Average(x => x.Price);

            Console.WriteLine(numberAverage);
            Console.WriteLine(bookAverage);

            var sum = books.Where(x => x.Pages >= 300)
                           .Sum(x => x.Pages);

            Console.WriteLine(sum);

            //6.3.2 최소, 최대

            var max = books.Max(x => x.Price);
            var min = books.Min(x => x.Price);

            Console.WriteLine(max);
            Console.WriteLine(min);

            //6.3.3 일치요소 수 카운팅
            var count = numberArray.Count(x => x == 4);

            Console.WriteLine(count);

            var bookcontain = books.Count(x => x.Title.Contains("운수"));

            Console.WriteLine(bookcontain);

            //6.4 컬렉션 판정
            //6.4.1 조건 일치 요소 조사
            var numbers2 = new List<int> { 19, 17, 15, 24, 12, 25, 15, 20, 11, 30, 24 };

            bool isExists = numbers2.Any(x => x % 7 == 0);
            Console.WriteLine(isExists);

            //6.4.2 조건 만족 조사
            var isAllPositive = numbers.All(x => x > 3);
            Console.WriteLine(isAllPositive);

            //6.4.3 같은 컬렉션 조사
            var numlist1 = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };
            var numlist2 = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };

            var equal = numlist1.SequenceEqual(numlist2);
            Console.WriteLine(equal);

            //6.5 단일 요소 구하기
            //6.5.1 조건일치 첫/마지막 요소 구하기
            var text = "The quick brown fox jumps over the lazy dog";
            var words = text.Split(' ');
            var firstWord = words.FirstOrDefault(x => x.Length == 4);
            var lastWord = words.LastOrDefault(x => x.Length == 4);

            Console.WriteLine(firstWord);
            Console.WriteLine(lastWord);


        }
    }
}
