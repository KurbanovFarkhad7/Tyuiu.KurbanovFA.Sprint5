using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            double result = 0;
            if (File.Exists(path))
            {
                try
                {
                    string pathTransfer = File.ReadAllText(path);
                    double x = double.Parse(pathTransfer);
                    result = Math.Round((4.26 * x) / (Math.Sin(x)), 3);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при обработке файла или вычислениях: {ex.Message}");
                }
            }
            return result;
        }
    }
}
