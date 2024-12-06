using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.OsadetsAA.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Преобразуем массив в список строк для сортировки
            var sortedRows = Enumerable.Range(0, rows)
                                       .Select(row => Enumerable.Range(0, cols)
                                                                .Select(col => matrix[row, col])
                                                                .ToArray())
                                       .OrderBy(row => row[3]) // Сортировка по четвертому столбцу
                                       .ToArray();

            // Заполняем результатирующий массив
            int[,] sortedArray = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sortedArray[i, j] = sortedRows[i][j];
                }
            }

            return sortedArray;
        }
    }
}
