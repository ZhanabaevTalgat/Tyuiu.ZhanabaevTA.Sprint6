using Tyuiu.ZhanabaevTA.Sprint6.Task1.V1.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = -1; int end = 1;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(start, end);
            double[] await = new double[3];

            await[0] = -2.98;
            await[1] = 1;
            await[2] = 1.82;

            CollectionAssert.AreEqual(await, res);
        }
    }
}