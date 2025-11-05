
using Tyuiu.AlbornozJ.Sprint4.Task2.V24.Lib;

namespace Tyuiu.AlbornozJ.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }
    }
}
