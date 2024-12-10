using Tyuiu.OsadetsAA.Sprint6.Task3.V7.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mrtx = new int[5, 5] { { 31, 25, -18, 12, 9 },
                                      { 6, 34, -2, 2, -18 },
                                      { -5, 4, 27, 4, -1 },
                                      { 4, 15, 34, -6, -10 },
                                      { 0, 8, 5, 14, -17 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mrtx.GetUpperBound(0) + 1;
            int columns = mrtx.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mrtx[i, j]);
                }
            }
        }

        private void textBoxMatrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Осадец Александр Александрович", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] martx = ds.Calculate(mrtx);
            for (int i = 0; i < martx.GetLength(0); i++)
            {
                for (int j = 0; j < martx.GetLength(1); j++)
                {
                    textBoxResult.AppendText(Convert.ToString(martx[i, j]) + "   ");
                }
                textBoxResult.AppendText(Environment.NewLine);
            }
        }
    }
}
