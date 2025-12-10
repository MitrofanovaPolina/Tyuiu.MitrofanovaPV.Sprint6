using Tyuiu.MitrofanovaPV.Sprint6.Task6.V2.Lib;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task6.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;
        Class1 ds = new Class1();

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для обработки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxIn.Text = openFileDialog.FileName;

                    // Обработка файла и вывод результата
                    string result = TextProcessor.ExtractSecondWords(openFileDialog.FileName);
                    textBoxOut.Text = result;
                }
            }
        }
    }
}

