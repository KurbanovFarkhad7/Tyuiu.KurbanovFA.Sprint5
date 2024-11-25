using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KurbanovFA.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathTransfer = File.ReadAllText(path);
            string stringValues = pathTransfer;

            string result = "";

            foreach (char c in stringValues)
            {
                // Проверяем, является ли символ русской буквой
                if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я'))
                {
                    // Заменяем русскую букву на '#'
                    result += '#';
                }
                else
                {
                    // Если символ не русская буква, оставляем его как есть
                    result += c;
                }
            }
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V4");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(result);
            }
            return outputFile;
        }
    }
}
