using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("1文字目:");
            var str1 = Console.ReadLine();
            Console.Write("2文字目:");
            var str2 = Console.ReadLine();

            var cultureInfo = new CultureInfo("ja-JP");

            if (String.Compare(str1, str2, cultureInfo,
                CompareOptions.IgnoreWidth |
                CompareOptions.IgnoreKanaType) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
