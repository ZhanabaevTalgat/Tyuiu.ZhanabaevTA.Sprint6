using Tyuiu.ZhanabaevTA.Sprint6.Task6.V5.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V5.txt";
            string str = "l";

            DataService ds = new DataService();
            
            string res = ds.CollectTextFromFile(str, path);
            string wait = " ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            Assert.AreEqual(wait, res);
        }
    }
}