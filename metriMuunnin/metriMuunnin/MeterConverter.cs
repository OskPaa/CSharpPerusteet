using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metriMuunnin
{
    class MeterConverter
    {
        public static double toCentiMeter(double value)
        {
            return value * 100;
        }
        public static double toDesiMeter(double value)
        {
            return value * 10;
        }
        public static double toKiloMeter(double value)
        {
            return value / 1000;
        }
        public static double toInch(double value)
        {
            return value * 39.370;
        }
        public static double toYard(double value)
        {
            return value * 1.0936;
        }
        public static double toFeet(double value)
        {
            return value * 3.28;
        }
    }
}
