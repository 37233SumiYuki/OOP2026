namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("整数文字列:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number)) {
             
                Console.WriteLine($"{number:#,0}");
            } else {
                Console.WriteLine("int型ではありません。");
            }


        }
    }
}
