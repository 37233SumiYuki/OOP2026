namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("整数文字列:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number)) {
                var s1 = $"{number:#,0}";
                Console.WriteLine(s1);
            } else {
                Console.WriteLine("int型ではありません。");
            }


        }
    }
}
