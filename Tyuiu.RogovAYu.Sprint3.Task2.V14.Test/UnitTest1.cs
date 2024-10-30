using Tyuiu.RogovAYu.Sprint3.Task2.V14.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task2.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(ds.GetMultiplySeries(5,1,6), 10220.275);
        }
    }
}