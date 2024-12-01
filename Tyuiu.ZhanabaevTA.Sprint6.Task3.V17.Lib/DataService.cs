using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZhanabaevTA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // количество строк
            int columns = matrix.Length / rows; // количество столбцов

            int[] sort = new int[columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 3)
                    {
                        sort[i] = matrix[i, j];
                    }
                }
            }

            Array.Sort(sort);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = sort[i];
            }

            return matrix;
        }
    }
}
