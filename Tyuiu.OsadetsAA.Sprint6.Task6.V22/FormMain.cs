using Tyuiu.OsadetsAA.Sprint6.Task6.V22.Lib;
namespace Tyuiu.OsadetsAA.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonLoadFile_OAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_OAA.ShowDialog();
            openFilePath = openFileDialogTask_OAA.FileName;
            textBoxLoadFromFile_OAA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_OAA.Text = groupBoxOutPut_OAA.Text + " " + openFileDialogTask_OAA.FileName;
            buttonDone_OAA.Enabled = true;
        }
        private void buttonDone_OAA_Click(object sender, EventArgs e)
        {
            textBoxResult_OAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonReference_OAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
