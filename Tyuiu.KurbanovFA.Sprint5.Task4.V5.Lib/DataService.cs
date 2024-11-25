using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string pathTransfer = File.ReadAllText(path);
            pathTransfer.Replace(".", ",");
            double x = double.Parse(pathTransfer);
            return Math.Round((4.26 * x) / (Math.Sin(x)), 3);
        }
    }
}
