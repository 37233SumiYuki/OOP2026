using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConveter{
    public class FeetConverter{
        private static readonly double ratio = 0.3048; //定数
        //フィートからメートルを求める
        public static double FromMeter(double mater)
        {
            return mater / ratio;
        }
        //メートルからフィートを求める
        public static double ToFeet(double feet)
        {
            return feet * ratio;
        }
    }
}


