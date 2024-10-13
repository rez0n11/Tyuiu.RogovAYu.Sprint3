using Tyuiu.RogovAYu.Sprint3.Task0.V9.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task0.V9.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(0.43, ds.GetSumSeries(0.5,1,15));
        }
    }
}