using Tyuiu.MitrofanovaPV.Sprint6.Task3.V30.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task3.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 ds = new Class1();
        int[,] matrix = new int[5, 5]
        {
            {-9, -4,17,-1,-20 },
            {-19,18,-4,2,14 },
            {-12,16,-2,7,18 },
            {-16,15,4,-12,-13},
            {-15, -4 ,-16,1,-14 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            dg.ColumnCount = cols;
            dg.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dg.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dg.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matrix = ds.Calculate(matrix);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            res.ColumnCount = cols;
            res.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                res.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    res.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



