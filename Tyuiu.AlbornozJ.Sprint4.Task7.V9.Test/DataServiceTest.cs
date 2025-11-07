
using Tyuiu.AlbornozJ.Sprint4.Task7.V9.Lib;

namespace Tyuiu.AlbornozJ.Sprint4.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 3;
            int columns = 3;
            int[,] matrix = new int[rows, columns];
            string str = "864299753";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
