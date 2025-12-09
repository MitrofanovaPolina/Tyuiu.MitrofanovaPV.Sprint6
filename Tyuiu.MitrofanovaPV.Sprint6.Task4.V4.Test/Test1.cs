using Tyuiu.MitrofanovaPV.Sprint6.Task4.V4.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task4.V4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = {
                13.96, 9.35, 5.72, 3.07, 1.4,
                0.54, 0.46, 1.07, 2.28, 3.99, 6.04
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
