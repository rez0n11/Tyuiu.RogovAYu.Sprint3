using Tyuiu.RogovAYu.Sprint3.Task4.V10.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(0.014, ds.Calculate(-5, 5));
        }
    }
}