using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            int rows = 0; 
            int columns = 0;

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    columns = line.Split(";").Length;
                    rows++;
                }
            }

            int[,] matrix = new int[rows, columns];

            using (StreamReader streamReader = new StreamReader(path))
            {
                int count = 0;
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] s = line.Split(";");
                    for (int i = 0; i < columns; i++)
                    {
                        matrix[count, i] = Convert.ToInt32(s[i]);

                        if (i == 6 && matrix[count, i] % 5 == 0)
                        {
                            matrix[count, i] = 2;
                        }
                    }

                    count++;
                }
            }

            return matrix;
        }
    }
}
