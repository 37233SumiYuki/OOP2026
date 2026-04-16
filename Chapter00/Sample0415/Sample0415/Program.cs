using System.Globalization;
using System.Security;

namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            //格納
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "] =");
                array[i] = int.Parse(Console.ReadLine());
            }
            {
                //集計
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];

                }

                Console.WriteLine();
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("arrya[" + i + "]:");

                    astOut(array[i]);

                }
                Console.WriteLine("合計値:" + array.Where(n=>n%2 ==0).Sum());
            }
            void astOut(int num)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }Console.WriteLine();
            }
            
        }
    }
}