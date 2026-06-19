namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];


            Console.WriteLine("\n7.1.1");
            Exercise1(numbers);

            Console.WriteLine("\n7.1.2");
            Exercise2(numbers);

            Console.WriteLine("\n7.1.3");
            Exercise3(numbers);

            Console.WriteLine("\n7.1.4");
            Exercise4(numbers);

            Console.WriteLine("\n7.1.5");
            Exercise5(numbers);

        }

        private static void Exercise1(int[] numbers) {
            var maxNum = numbers.Max(x => x);
            Console.WriteLine(maxNum);
        }

        private static void Exercise2(int[] numbers) {

        }

        private static void Exercise3(int[] numbers) {
            //P173
        }

        private static void Exercise4(int[] numbers) {
            //P175
        }

        private static void Exercise5(int[] numbers) {
            //P174
        }
    }
}
