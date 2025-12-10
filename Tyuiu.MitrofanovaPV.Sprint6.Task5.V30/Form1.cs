using Tyuiu.MitrofanovaPV.Sprint6.Task5.V30.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task5.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            dg.ColumnCount = 2;
            dg.Columns[0].Width = 20;
            dg.Columns[1].Width = 50;
            double[] numass = new double[ds.len];
            numass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numass.Length; i++)
            {
                dg.Rows.Add(Convert.ToString(i), Convert.ToString(numass[i]));

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }



}
