using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task1.V25.Lib
{
    public class Class1 : ISprint6Task1V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valarr;
            int len = (stopValue - startValue) + 1;
            valarr = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((5*x + 2.5)/(Math.Sin(x) -2)) + 2;
                valarr[count] = y;

                count++;
            }
            return valarr;
        }
    }
}
