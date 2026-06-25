using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();
        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了:Ctrl+'Z'】");

            while (true) {
                //都道府県の入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) break;//無限ループを抜ける


                //県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();

                if (prefCaptalLocation == null) break;
                prefOfficeDict[pref] = prefCaptalLocation;





                //県庁所在地登録処理

                Console.WriteLine(pref + "の県庁所在地は" + prefCaptalLocation + "です");
            }
            Console.WriteLine("***メニュー*** \r\n1:一覧表示\r\n2:検索 \r\n9:終了\r\n");
            Console.WriteLine("選択:");
            var num = Console.ReadLine();
            string text = num switch {
                "1" => allDisp
                "2" => "2です",
                "9" => "9です",
                _ => "正しく入力してください"
            }

            Console.WriteLine(text);
        }
        public void allDisp() {
            Console.WriteLine("\n登録一覧:");
            foreach (var item in prefOfficeDict) {
                Console.WriteLine($"{item.Key}の県庁所在地は {item.Value}");

            }

        }
        }
    }
