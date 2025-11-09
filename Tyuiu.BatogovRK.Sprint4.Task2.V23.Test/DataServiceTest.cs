using Tyuiu.BatogovRK.Sprint4.Task2.V23.Lib;

namespace Tyuiu.BatogovRK.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5 };

            int wait = 14;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
