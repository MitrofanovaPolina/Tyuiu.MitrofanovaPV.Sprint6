using Tyuiu.MitrofanovaPV.Sprint6.Task0.V25.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task0.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void var_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                result.Text = Convert.ToString(ds.Calculate(3));
            }
            catch
            {

            }
        }
    }
}
