using Tyuiu.BatogovRK.Sprint4.Task5.V12.Lib;

namespace Tyuiu.BatogovRK.Sprint4.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] ms = { {-1, 5, 6 },
                          {6, 5, -2} };
            int res = ds.Calculate(ms);
            Assert.AreEqual(2, res);
        }
    }
}
