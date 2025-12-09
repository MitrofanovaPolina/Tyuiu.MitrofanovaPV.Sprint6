using Tyuiu.MitrofanovaPV.Sprint6.Task0.V25.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task0.V25.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds =new DataService();
            double res = ds.Calculate(1);
            double wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}
