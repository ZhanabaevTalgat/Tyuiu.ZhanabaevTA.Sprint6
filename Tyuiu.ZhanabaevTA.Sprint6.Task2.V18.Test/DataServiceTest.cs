using Tyuiu.ZhanabaevTA.Sprint6.Task2.V18.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = -1;
            int stopValue = 1;
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(startValue, stopValue);

            double[] expected = new double[3];
            expected[0] = 1.8;
            expected[1] = -8.0;
            expected[2] = -5.7;

            CollectionAssert.AreEqual(expected, res);
        }
    }
}