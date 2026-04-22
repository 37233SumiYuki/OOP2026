namespace DistanceConveter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3
                && int.TryParse(args[1], out int start) && int.TryParse(args[2], out int end))
            {


                if (args[0] == "-tom")
                {
                    PrintFeettoMeterList(start, end);
                }
                else if (args[0] == "-tof")
                    PrintMeterToFeetList(start, end);
                else
                {
                    Console.WriteLine("引数数式エラー");
                }
            }
            else
            {
                Console.WriteLine("引数エラー");
            }
            //フィートからメートルへの対応表を出力
            static void PrintFeettoMeterList(int start, int stop)
            {
                for (int feet = 1; feet <= 10; feet++)
                {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine($"{feet}ft ={meter:0.0000}m");
                }
            }
            static void PrintMeterToFeetList(int start, int stop)
            {
                //メートルからフィートへの対応表を出力
                for (int meter = 1; meter <= 10; meter++)
                {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine($"{meter}m ={feet:0.0000}ft");
                }
            }
            //フィートからメートルを求める
            static double FeetToMeter(int feet)
            {
                return feet * 0.3048;
            }
            //メートルからフィートを求める
            static double MeterToFeet(int meter)
            {
                return meter / 0.3048;
            }
        }
    }
}

