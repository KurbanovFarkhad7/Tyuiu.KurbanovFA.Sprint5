using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.Write(2 * Math.Pow(x, 3) + 0.5 * Math.Pow(x, 2) - 3.5 * x + 2);

            }
            return outputFile;
        }
    }
}
