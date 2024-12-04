using Newtonsoft.Json.Linq;
using Tyuiu.ZhanabaevTA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask7V25.csv";

            int[,] matrix = ds.GetMatrix(path);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("   " + matrix[i, j]);
                }
                Console.WriteLine();
            }

            int[,] wait = new int[,]
            {
                {-17, -17, 16, -19, 10, -15, 2, 4, 18, 19},
                {-13, -19, -4, 17, 13, -11, -16, -1, 6, 10},
                {-19, -19, -6, 7, 3, 11, 8, -16, -9, -8},
                {-13, -13, 11, -4, 7, -20, 2, 0, -6, 7},
                {-3, 20, -15, 19, 3, -4, 13, -12, -18, 18},
                {-19, 18, -18, -3, 11, 3, 9, -13, 13, 15},
                {-19, 18, -4, -6, 15, 14, 12, 5, 18, 0},
                {-14, -9, -14, 2, 0, -9, -1, -10, 14, -9},
                {20, -4, -14, 6, 20, 12, 11, 9, -20, -15},
                {-20, -8, 15, -5, 0, 4, 2, 18, -20, 11},
            };

            CollectionAssert.AreEqual(matrix, wait);
        }
    }
}