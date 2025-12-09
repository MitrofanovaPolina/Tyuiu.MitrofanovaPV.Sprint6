using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task4.V4.Lib
{
    public class Class1 : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resultArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = ((2*x + 6) /(Math.Cos(x) + x)) - 3;
                resultArray[count] = Math.Round(result, 2);
                count++;
            }
            return resultArray;
        }
    }
}
