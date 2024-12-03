using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double action1 = 2 + Math.Cos(x);
                double action2 = 2 * x - 2;
                if (action2 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round(4 - 2 * x + (action1/action2), 2);
                    count++;
                }
            }

            return res;
        }
    }
}
