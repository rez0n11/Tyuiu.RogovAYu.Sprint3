using Tyuiu.RogovAYu.Sprint3.Task5.V11.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task5.V11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(79.234,ds.GetSumSumSeries(5,1,1,3,10));
        }
    }
}