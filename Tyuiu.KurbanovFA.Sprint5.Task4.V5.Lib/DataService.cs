using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string tempDirectory = Path.GetTempPath();
            path = Path.Combine("/app/data/AssesmentData/C#/Sprint5Task4/InPutDataFileTask4V5.txt");
            string pathTransfer = File.ReadAllText(path);
            double x = double.Parse(pathTransfer);
            return Math.Round((4.26 * x) / (Math.Sin(x)), 3);
        }
    }
}
