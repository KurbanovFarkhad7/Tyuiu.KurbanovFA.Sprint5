using Tyuiu.KurbanovFA.Sprint5.Task1.V7.Lib;

namespace Tyuiu.KurbanovFA.Sprint5.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string path = @"C:\Users\Cruise\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}