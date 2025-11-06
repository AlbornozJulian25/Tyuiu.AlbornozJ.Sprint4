
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AlbornozJ.Sprint4.Task6.V7.Lib
{
    public class DataService : ISprint4Task6V7
    {
        public int Calculate(string[] arrayStrings)
        {
            string[] mas = Array.FindAll(arrayStrings, subject => subject.Length > 8);
            return mas.Length;
        }
    }
}