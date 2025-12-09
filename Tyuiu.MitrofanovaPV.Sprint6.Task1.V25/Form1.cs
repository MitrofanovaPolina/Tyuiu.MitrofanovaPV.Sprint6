using Tyuiu.MitrofanovaPV.Sprint6.Task1.V25.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task1.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        private void knopka_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(boxstart.Text);
                int stopStep = Convert.ToInt32(boxstop.Text);

                string str;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] res = ds.GetMassFunction(startStep, stopStep);
                result.Text = "";
                result.AppendText("+-----------+-----------+" + Environment.NewLine);
                result.AppendText("|      x    |      y    |" + Environment.NewLine);
                result.AppendText("+-----------+-----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,7:d}    | {1, 9:f2} |", startStep, res[i]);
                    result.AppendText(str + Environment.NewLine);
                    startStep++;
                }
                result.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {

            }
        }
    }
}
