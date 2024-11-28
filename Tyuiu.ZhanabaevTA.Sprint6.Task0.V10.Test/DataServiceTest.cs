using Tyuiu.ZhanabaevTA.Sprint6.Task0.V10.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            double wait = 37.56;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
