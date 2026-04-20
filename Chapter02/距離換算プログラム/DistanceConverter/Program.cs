using System.ComponentModel.Design;

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length >= 1 && args[0] == "-tom")
            {
                for (int feet = 1; feet <= 10; feet++)
                {
                    double meters = FeetToMeter(feet);
                    Console.WriteLine($"{feet}ft = {meters:0.0000} m");
                }
            }
            else
            {
                for (int meters = 1; meters <= 10; meters++)
                {
                    double feet = MeterToFeet(meters);
                    Console.WriteLine($"{meters}m = {feet:0.0000} ft");
                }
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
