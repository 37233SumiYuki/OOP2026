using System.ComponentModel.Design;

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else if (args.Length >= 1 && args[0] == "-tof") {
                PrintMeterToFeetList(1, 10);
            }
            else
            {
                Console.WriteLine("引数エラー");
            
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meters = start; meters <= stop; meters++)
            {
                double feet = MeterToFeet(meters);
                Console.WriteLine($"{meters}m = {feet:0.0000} ft");
            }
        }

        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meters = FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meters:0.0000} m");
            }

        }

        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
        static double MeterToFeet(int meters)
        {
            return meters / 0.3048;
        }
    }
}
