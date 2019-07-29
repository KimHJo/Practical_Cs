using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace SalesCalculator { 
    class Entry {
        static void Main(string[] arg) {
            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));

            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();

            foreach(var obj in amountPerStore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
        // Sales.scv 파일 로드
        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };

                sales.Add(sale);
            }
            return sales;
        }
    }


}