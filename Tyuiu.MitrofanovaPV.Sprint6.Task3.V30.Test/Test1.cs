using Tyuiu.MitrofanovaPV.Sprint6.Task3.V30.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task3.V30.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();

            int[,] waitMatrix = new int[5, 5]
            {
                {-14, 17, -19, 3, 2 },
                {-4, -14, -19, -9, -1 },
                {1, 0, 13, 14, 8 },
                {13, 7, 8, -3, -15 },
                {2, -20, 12, -14, 4 }
            };

            int[,] resMatrix = new int[5, 5];

            int rows = waitMatrix.GetLength(0);
            int cols = waitMatrix.GetLength(1);

            int[] values = [-14, 17, -19, 3, 2, -4, -14, -19, -9, -1, 1, 0, 13, 14, 8, 13, 7, 8, -3, -15, 2, -20, 12, -14, 4];

            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resMatrix[i, j] = values[index++];
                }
            }

            resMatrix = ds.Calculate(resMatrix);

            waitMatrix[4, 0] = 0;
            waitMatrix[4, 1] = 0;
            waitMatrix[4, 2] = 0;
            waitMatrix[4, 3] = 0;
            waitMatrix[4, 4] = 0;

            CollectionAssert.AreEqual(resMatrix, waitMatrix);
        }
    }
}
