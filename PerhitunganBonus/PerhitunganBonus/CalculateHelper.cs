using System;

namespace PerhitunganBonus
{
    internal class CalculateHelper
    {
        internal static double CalcularePTY(double value)
        {
            if (value <= 97)
                return 0.5;

            if (value > 97 && value < 100)
                return 1;

            return 1.2;
        }

        internal static double CalculatePA(double value)
        {
            if (value <= 98)
                return 0.5;

            if (value > 98 && value < 101)
                return 1;

            return 1.2;
        }

        internal static double CalculateAP(double value)
        {
            if (value < 97)
                return 0;

            if (value >= 97 && value < 100)
                return 0.1;

            if (value >= 100 && value < 101)
                return 0.5;

            if (value >= 101 && value < 102)
                return 1;

            if (value >= 102 && value <= 105)
                return 1.2;
            return 1.3;
        }

        internal static double CalculateFI(FIType value)
        {
            if (value == FIType.LTI)
                return 0;
            if (value == FIType.TIFRMoreThen2)
                return 0.5;
            if (value == FIType.TIFRLestThen2)
                return 1;
            return 1.2;
        }
    }
}