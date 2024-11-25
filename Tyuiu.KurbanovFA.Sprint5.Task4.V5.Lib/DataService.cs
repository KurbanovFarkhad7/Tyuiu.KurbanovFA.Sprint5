using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            double x = 0;
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден: " + path);
                return 2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2;
            }
            try
            {
                x = double.Parse(File.ReadAllText(path));
                return 2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                return 0;
            }
        }
    }
}
