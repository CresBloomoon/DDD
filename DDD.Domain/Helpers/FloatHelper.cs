using System;

namespace DDD.Domain.Helpers
{
    public static class FloatHelper
    {
        public static string RoundString(this float value, int decimalPoint)
        {
            var temp = Convert.ToSingle(Math.Round(value, decimalPoint));
            return temp.ToString("F" + decimalPoint);
        }
    }
}
