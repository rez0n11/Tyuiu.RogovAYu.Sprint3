using Tyuiu.RogovAYu.Sprint3.Task3.V24.Lib;
namespace Tyuiu.RogovAYu.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual("*ft h**t nt*", ds.ReplaceCharInString("gft hggt ntg", 'g', '*'));
        }
    }
}