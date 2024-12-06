using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.OsadetsAA.Sprint6.Task3.V7.Lib
{
    public class DataService : ISprint6Task3V7
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            // Извлекаем четвертый столбец
            int[] fourthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fourthColumn[i] = matrix[i, 3];
            }

            // Сортируем четвертый столбец
            Array.Sort(fourthColumn);

            // Записываем отсортированный столбец обратно в массив
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = fourthColumn[i];
            }

            return matrix;
        }
    }
}
