using Tyuiu.OsadetsAA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        { //C:\Users\Mecht\source\repos\Tyuiu.OsadetsAA.Sprint6\Tyuiu.OsadetsAA.Sprint6.Task5.V4.Lib\bin\Debug
            string[] paths = { @"C:\Users", "Mecht", "source", "repos", "Tyuiu.OsadetsAA.Sprint6", "Tyuiu.OsadetsAA.Sprint6.Task5.V4.Lib", "bin", "Debug", "InPutDataFileTask5V4.txt" };
            string fullPath = Path.Combine(paths);


            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}