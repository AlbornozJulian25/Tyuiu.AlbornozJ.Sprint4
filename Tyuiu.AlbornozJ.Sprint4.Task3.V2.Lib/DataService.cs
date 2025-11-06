
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AlbornozJ.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int maxElement = matrix[0, 0];
                        
            for (int j = 0; j < columns; j++)
            {
                if (matrix[0, j] > maxElement)
                {
                    maxElement = matrix[0, j];
                }
            }
            return maxElement;
        }
    }
}
