using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MautalievSI.Sprint3.Task7.V20.Lib
{
    public class DataService : ISprint3Task7V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 3 * x - 1;
                double y;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) - 2 * x) / denominator + Math.Sin(x) - 3 * x + 2;
                }

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}