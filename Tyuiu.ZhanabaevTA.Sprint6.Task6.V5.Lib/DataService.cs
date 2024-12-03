using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            string str = "l";
            string resStr = "";

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] s = line.Split(" ");
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i].Contains(str))
                        {
                            resStr = resStr + " " + s[i];
                        }
                    }
                }
            }

            return resStr;
        }
    }
}