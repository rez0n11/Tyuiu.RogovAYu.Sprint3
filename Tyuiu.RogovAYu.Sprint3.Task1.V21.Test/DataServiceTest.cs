using Tyuiu.RogovAYu.Sprint3.Task1.V21.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(16947800000, ds.GetMultiplySeries(1,1,12) );
        }
    }
}