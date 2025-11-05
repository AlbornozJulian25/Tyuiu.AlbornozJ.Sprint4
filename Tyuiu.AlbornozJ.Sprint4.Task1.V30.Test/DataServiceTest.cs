
using Tyuiu.AlbornozJ.Sprint4.Task1.V30.Lib;

namespace Tyuiu.AlbornozJ.Sprint4.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 6 * 8 * 6 * 6 * 8;
            Assert.AreEqual(wait, res);
        }
    }
}
