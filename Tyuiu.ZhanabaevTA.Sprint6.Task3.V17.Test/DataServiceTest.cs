using Tyuiu.ZhanabaevTA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                {1,2,3,4,4},
                {2,3,4,1,4},
                {3,2,4,4,4},
                {3,2,1,5,4},
                {2,3,1,1,1}
             };

            int[,] wait = new int[5, 5] {
                {1,2,3,1,4},
                {2,3,4,1,4},
                {3,2,4,4,4},
                {3,2,1,4,4},
                {2,3,1,5,1}

             };

            int[,] res = ds.Calculate(matrix);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}