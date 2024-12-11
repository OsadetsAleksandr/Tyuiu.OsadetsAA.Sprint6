using System.Windows.Forms;
using Tyuiu.OsadetsAA.Sprint6.Task7.V24.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_OAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_OAA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;
        public int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);


            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            return arrayValues;

        }

        private void buttonLoadFile_OAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_OAA.ShowDialog();
            openFilePath = openFileDialogTask_OAA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);


            dataGridViewInPutFile_OAA.ColumnCount = columns;
            dataGridViewInPutFile_OAA.RowCount = rows;
            dataGridViewResult_OAA.ColumnCount = columns;
            dataGridViewResult_OAA.RowCount = rows;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_OAA.Columns[i].Width = 35;
                dataGridViewInPutFile_OAA.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPutFile_OAA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }


            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_OAA.Enabled = true;
        }

        private void buttonHelp_OAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_OAA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_OAA.Enabled = true;
        }

        private void buttonSave_OAA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_OAA.FileName = "OutPutFileTask7V24.csv";
            saveFileDialogTask_OAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_OAA.ShowDialog();

            string path = saveFileDialogTask_OAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_OAA.RowCount;
            int columns = dataGridViewResult_OAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewResult_OAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewResult_OAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonLoadFile_OAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_OAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_OAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_OAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_OAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_OAA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_OAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipHelp_OAA.ToolTipTitle = "Справка";
        }
    }
}
