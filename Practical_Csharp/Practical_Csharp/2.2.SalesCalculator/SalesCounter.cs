using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SalesCalculator {
    class SalesCounter {
        private List<Sale> _sales;

        public SalesCounter(List<Sale> sales) {
            _sales = sales;
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

        // 점포별 매출 구하기
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var sale in _sales) {
                if (dictionary.ContainsKey(sale.ShopName))
                    dictionary[sale.ShopName] += sale.Amount;
                else
                    dictionary[sale.ShopName] -= sale.Amount;
            }
            return dictionary;
        }
    }
}