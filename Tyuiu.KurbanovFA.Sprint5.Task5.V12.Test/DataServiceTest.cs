using Tyuiu.KurbanovFA.Sprint5.Task5.V12.Lib;

namespace Tyuiu.KurbanovFA.Sprint5.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Cruise\AppData\Local\Temp\OutPutFileTask5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}