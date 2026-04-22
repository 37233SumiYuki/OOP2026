using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter
{
    public class FeetConverter
    {
        //フィートからメートルを求める
        static double fromMeter(double mater)
        {
            return mater / 0.3048;
        }
        //メートルからフィートを求める
        public double ToFeet(double feet)
        {
            return feet * 0.3048;
        }
    }
}
