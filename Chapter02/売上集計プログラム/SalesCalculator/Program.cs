namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            var sales = ReadSales(@"data\sales.csv");
        }

        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>(); //リスト
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
