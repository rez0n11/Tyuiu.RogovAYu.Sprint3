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
            Assert.AreEqual([-11.22, -8.65, -4.76, -6.47, -2.98, 1.0, 1.82, 3.55, 6.99, 7.74, 9.03], ds.GetMassFunction(-5, 5));
        }
    }
}