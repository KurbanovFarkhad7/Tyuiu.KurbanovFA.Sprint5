using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = $"{Directory.GetCurrentDirectory()}OutPutFileTask0.txt";
            double z = Math.Round((Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3), 3);
            z = Math.Round(z, 3);
            string tempFilePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            using (StreamWriter writer = File.CreateText(tempFilePath))
            {
                writer.WriteLine(z);
            }
            File.WriteAllText(path, Convert.ToString(z));
            return path.ToString();
        }
    }
}
