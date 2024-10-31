using Tyuiu.RogovAYu.Sprint3.Task7.V28.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual([11], ds.GetMassFunction(-5, 5));
        }
    }
}