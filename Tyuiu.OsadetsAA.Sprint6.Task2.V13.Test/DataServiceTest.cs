using Tyuiu.OsadetsAA.Sprint6.Task2.V13.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = [3.30, -12.37, -14.02, -5.57, 0.65, 0, -0.65, 5.57, 14.02, 12.37, -3.30];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}