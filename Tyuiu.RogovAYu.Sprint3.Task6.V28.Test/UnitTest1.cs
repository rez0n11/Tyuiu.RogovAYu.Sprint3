using Tyuiu.RogovAYu.Sprint3.Task6.V28.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(16, ds.GetSumTheDivisors(13,19));
        }
    }
}