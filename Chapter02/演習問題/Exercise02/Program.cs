namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintinchToMeterList(1, 10);
        }
        private static void PrintinchToMeterList(int start, int end) {
            for(int feet = start; feet <= end; feet++) {
                double meter = InchConberter.ToMeter(feet);
                Console.WriteLine($"{feet}inch ={meter:0.0000}m");
            }
                }
            }

        }