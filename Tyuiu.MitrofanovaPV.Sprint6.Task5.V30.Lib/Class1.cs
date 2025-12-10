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

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            ;
            int index = 0;
            double[] res = new double[len];
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    res[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            res = res.Where(var => ((var >= 2) && (var <= 7))).ToArray();
            return res;

        }
    }
}
