using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task5.V30.Lib
{
    public class Class1 : ISprint6Task5V30
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;

                }

            }
            double[] numsar = new double[len];
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    numsar[index] = Convert.ToDouble(line);
                    index++;

                }
            }
            numsar = numsar.Where(x => x > 2 && x< 7).ToArray();
            return numsar;
        }
    }
}
