using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task1.V1.Lib
{
    public class DataService : ISprint6Task1V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round(Math.Cos(2*x) + (Math.Sin(x)/(x + 2.5)) + 2*x, 2);
                    count++;
                }
            }

            return res;
        }
    }
}
