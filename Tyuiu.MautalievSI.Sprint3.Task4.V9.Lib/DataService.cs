using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MautalievSI.Sprint3.Task4.V9.Lib
{
    public class DataService : ISprint3Task4V9
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;

                double y = x / (Math.Cos(x) - x);
                result *= y;
            }

            return Math.Round(result, 3);
        }
    }
}