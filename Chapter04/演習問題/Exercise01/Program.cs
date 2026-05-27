
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            //foreach文
            Console.WriteLine("\nforeach文で出力");
            foreach (String lan in langs) {
                if (lan.Contains("S")) {
                 Console.WriteLine(lan);
                }    
              }
            }

        private static void Exercise2(List<string> langs) {
            //for文
            Console.WriteLine("\nfor文で出力");
            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains("S")) {
                    Console.WriteLine(langs[i]);
                }
            }
        }

        private static void Exercise3(List<string> langs) {
            //while文
            Console.WriteLine("\nwhile文で出力");
            while (true) ;

        }
    }
}
