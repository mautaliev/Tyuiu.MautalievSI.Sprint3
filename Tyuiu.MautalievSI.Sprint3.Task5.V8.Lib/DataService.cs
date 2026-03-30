using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MautalievSI.Sprint3.Task5.V8.Lib
{
    public class DataService : ISprint3Task5V8
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0.0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += 1 / Math.Sin(k);
                }
            }

            double result = sum + 3;

            return Math.Round(result, 3);
        }
    }
}