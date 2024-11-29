using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double action1 = 3 * Math.Cos(x);
                double action2 = 4 * x - 0.5;
                if (action2 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round((action1/action2) + Math.Sin(x) - 5 * x - 2, 2);
                    count++;
                }
            }

            return res;
        }
    }
}
