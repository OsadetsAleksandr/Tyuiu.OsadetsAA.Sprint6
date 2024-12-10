using System.Resources;
using Tyuiu.OsadetsAA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\Mecht\source\repos\Tyuiu.OsadetsAA.Sprint6\Tyuiu.OsadetsAA.Sprint6.Task5.V4.Lib\bin\Debug\InPutDataFileTask5V4.txt";
        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_OAA.ColumnCount = 2;
            dataGridViewNums_OAA.Columns[0].Width = 40;
            dataGridViewNums_OAA.Columns[1].Width = 50;

            this.chartResult_OAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_OAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_OAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_OAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_OAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonFile_OAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonReference_OAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Осадец Александр Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
