using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class InchConberter{
        private static readonly double ratio = 0.0254; //定数
        //フィートからインチを求める
        public static double FromMeter(double mater) {
            return mater / ratio;
        }
        //インチからメートルを求める
        public static double ToFeet(double inch) {
            return inch * ratio;
        }
    }
}
