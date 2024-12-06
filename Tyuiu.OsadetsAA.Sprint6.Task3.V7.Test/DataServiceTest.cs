using Tyuiu.OsadetsAA.Sprint6.Task3.V7.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            // 31  25 -18  12   9

            //  6  34 - 2   2 - 18

            // - 5   4  27   4 - 1

            // 4  15  34 - 6 - 10

            // 0   8   5  14 - 17
            DataService ds = new DataService();
            int[,] mrtx = {
                { 31, 25, -18, 12, 9 },
                { 6, 34, -2, 2, -18 },
                { -5, 4, 27, 4, -1 },
                { 4, 15, 34, -6, -10 },
                { 0, 8, 5, 14, -17 }
            };

            int[,] expectedmrtx = {
                { 31, 25, -18, -6, 9 },
                { 6, 34, -2, 2, -18 },
                { -5, 4, 27, 4, -1 },
                { 4, 15, 34, 12, -10 },
                { 0, 8, 5, 14, -17 }
            };
            var res = ds.Calculate(mrtx);
            CollectionAssert.AreEqual(expectedmrtx, res);
        }
    }
}