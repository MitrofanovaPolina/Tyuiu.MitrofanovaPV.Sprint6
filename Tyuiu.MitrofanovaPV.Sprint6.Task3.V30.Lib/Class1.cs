using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task3.V30.Lib
{
    public class Class1 : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] res = (int[,])matrix.Clone();

            int rowIndex = 4;
            for (int j = 0; j < columns; j++)
            {
                if (res[rowIndex, j] % 2 == 0)
                {
                    res[rowIndex, j] = 0;
                }
            }
            return res;
        }
    }
}
