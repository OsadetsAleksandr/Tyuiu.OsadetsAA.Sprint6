using Tyuiu.OsadetsAA.Sprint6.Task7.V24.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix()
        {
            string[] paths = { @"C:\Users", "Mecht", "source", "repos", "Tyuiu.OsadetsAA.Sprint6", "Tyuiu.OsadetsAA.Sprint6.Task7.V24.Lib", "bin", "Debug", "InPutDataFileTask7V24.csv" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}