using Tyuiu.MitrofanovaPV.Sprint6.Task2.V4.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task2.V4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            double[] wait = new double[11];
            wait[0] = 3.30;
            wait[1] = -12.37;
            wait[2] = -14.02;
            wait[3] = -5.57;
            wait[4] = 0.65;
            wait[5] = 0;
            wait[6] = -0.65;
            wait[7] = 5.57;
            wait[8] = 14.02;
            wait[9] = 12.37;
            wait[10] = -3.30;
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
        }
    }
}
