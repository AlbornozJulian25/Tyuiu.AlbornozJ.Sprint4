
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AlbornozJ.Sprint4.Task0.V8.Lib
{
    public class DataService : ISprint4Task0V8
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int mult = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    mult *= array[i];
                }
            }
            return mult;
        }
    }
}
