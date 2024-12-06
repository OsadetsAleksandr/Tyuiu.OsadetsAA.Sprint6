using Tyuiu.OsadetsAA.Sprint6.Task4.V5.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task4.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_OAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_OAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_OAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_OAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_OAA.Text = "";

                chartFunction_OAA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_OAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_OAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_OAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Path.GetTempPath()}OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_OAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartStep_OAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxData_OAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_OAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonQuestion_OAA_Click(object sender, EventArgs e)
        {

        }
    }
}
