
using Tyuiu.AlbornozJ.Sprint4.Task5.V4.Lib;

namespace Tyuiu.AlbornozJ.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -4, -3, -2, -1,  0 },
                                          { 1, 2, 3, 4, 5 },
                                          { -1, -2, 6, -3, -4 },
                                          { 0, 1, 2, 3, 4 },
                                          { -4, -3, 5, 6, -2 } };

            int res = ds.Calculate(mas2);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
