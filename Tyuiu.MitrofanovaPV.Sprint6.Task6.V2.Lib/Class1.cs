using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MitrofanovaPV.Sprint6.Task6.V2.Lib
{
    public class Class1 : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            var resultWords = new List<string>();

            if (!File.Exists(path))
                return string.Empty;

            try
            {
                var lines = File.ReadAllLines(path);

                foreach (var line in lines)
                {
                    var words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (words.Length >= 2)
                    {
                        resultWords.Add(words[1]);
                    }
                }

                return string.Join(" ", resultWords);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
