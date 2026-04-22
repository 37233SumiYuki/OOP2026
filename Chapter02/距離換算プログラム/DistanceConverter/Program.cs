using System.ComponentModel.Design;

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           if (args.Length == 3
                && int,TryParse(args[1], out var start) && int.TryParse(args[2], out var stop)){
                if (args[0] == "-tom")
                {   PrintMeterToFeetList(start, end);
                    
                }else if (args[0] == )
                {
                    
                }
                else if (args[0] == "-tof")
                {
                }
            }
            {

                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
                Console.WriteLine(args + ":変換成功");
            }
            else if (args.Length >= 1 && args[0] == "-tof")
            {
                PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
            }
            Console.WriteLine("引数エラー");
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
