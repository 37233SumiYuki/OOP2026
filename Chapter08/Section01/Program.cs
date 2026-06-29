using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace Section01 {
    internal class Program {

        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {

            Console.WriteLine("県庁所在地の登録【入力終了:Ctrl+Z】");

            while (true) {
                Console.Write("都道府県:");
                string? pref = Console.ReadLine();
                if (pref == null) break;

                Console.Write("県庁所在地:");
                string? prefCapitalLocation = Console.ReadLine();
                if (prefCapitalLocation == null) break;

                // 既に登録されている場合
                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.Write("上書きしますか？(Y/N):");
                    string? overwrite = Console.ReadLine();

                    if (overwrite?.ToUpper() != "Y") {
                        continue; // 上書きしない
                    }
                }

                prefOfficeDict[pref] = prefCapitalLocation;
            }

            // メニュー処理
            while (true) {
                int menu = menuDisp();

                switch (menu) {
                    case 1:
                        allDisp();
                        break;
                    case 2:
                        searchPrefCapitalLocation();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("正しく入力してください");
                        break;
                }
            }
        }

        // メニュー表示
        private static int menuDisp() {
            Console.WriteLine("\n***メニュー***");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("9:終了");
            Console.Write(">");

            int.TryParse(Console.ReadLine(), out int menu);
            return menu;
        }

        // 一覧表示
        private static void allDisp() {
            Console.WriteLine("\n登録一覧:");

            foreach (var item in prefOfficeDict) {
                Console.WriteLine($"{item.Key}の県庁所在地は {item.Value}");
            }
        }

        // 検索
        private static void searchPrefCapitalLocation() {
            Console.Write("都道府県:");
            string? searchPref = Console.ReadLine();

            if (searchPref == null) return;

            if (prefOfficeDict.TryGetValue(searchPref, out string? capital)) {
                Console.WriteLine($"{searchPref}の県庁所在地は {capital}");
            } else {
                Console.WriteLine("登録されていません");
            }
        }
    }
}
