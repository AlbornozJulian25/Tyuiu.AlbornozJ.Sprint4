
using Tyuiu.AlbornozJ.Sprint4.Task0.V8.Lib;

namespace Tyuiu.AlbornozJ.Sprint4.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int wait = 6 * 4 * 2 * 8;
            Assert.AreEqual(wait, res);
        }
    }
}
