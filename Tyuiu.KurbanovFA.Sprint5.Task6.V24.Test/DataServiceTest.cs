using Tyuiu.KurbanovFA.Sprint5.Task6.V24.Lib;

namespace Tyuiu.KurbanovFA.Sprint5.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Cruise\AppData\Local\Temp\InPutDataFileTask6V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}