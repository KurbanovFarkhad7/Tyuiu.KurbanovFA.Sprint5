using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            double result = 2 * Math.Pow(double.Parse(x), 3) + 0.5 * Math.Pow(double.Parse(x), 2) - 3.5 * double.Parse(x) + 2;
            return result;
        }
    }
}
