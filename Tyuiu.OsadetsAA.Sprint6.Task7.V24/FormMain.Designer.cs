namespace Tyuiu.OsadetsAA.Sprint6.Task7.V24
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_OAA = new Button();
            buttonSave_OAA = new Button();
            buttonDone_OAA = new Button();
            buttonLoadFile_OAA = new Button();
            groupBoxTaskCondition_OAA = new GroupBox();
            textBoxCondition_OAA = new TextBox();
            panelLeft_OAA = new Panel();
            groupBoxInPut_OAA = new GroupBox();
            dataGridViewInPutFile_OAA = new DataGridView();
            dataGridViewResult_OAA = new DataGridView();
            panel3 = new Panel();
            groupBoxOutPut_OAA = new GroupBox();
            openFileDialogTask_OAA = new OpenFileDialog();
            toolTipHelp_OAA = new ToolTip(components);
            saveFileDialogTask_OAA = new SaveFileDialog();
            panel1.SuspendLayout();
            groupBoxTaskCondition_OAA.SuspendLayout();
            panelLeft_OAA.SuspendLayout();
            groupBoxInPut_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutFile_OAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_OAA).BeginInit();
            panel3.SuspendLayout();
            groupBoxOutPut_OAA.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonHelp_OAA);
            panel1.Controls.Add(buttonSave_OAA);
            panel1.Controls.Add(buttonDone_OAA);
            panel1.Controls.Add(buttonLoadFile_OAA);
            panel1.Controls.Add(groupBoxTaskCondition_OAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 186);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_OAA
            // 
            buttonHelp_OAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_OAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_OAA.Image = (Image)resources.GetObject("buttonHelp_OAA.Image");
            buttonHelp_OAA.Location = new Point(1106, 12);
            buttonHelp_OAA.Name = "buttonHelp_OAA";
            buttonHelp_OAA.Size = new Size(94, 72);
            buttonHelp_OAA.TabIndex = 4;
            toolTipHelp_OAA.SetToolTip(buttonHelp_OAA, "Сведение о программе");
            buttonHelp_OAA.UseVisualStyleBackColor = true;
            buttonHelp_OAA.Click += buttonHelp_OAA_Click;
            buttonHelp_OAA.MouseEnter += buttonHelp_OAA_MouseEnter;
            // 
            // buttonSave_OAA
            // 
            buttonSave_OAA.Enabled = false;
            buttonSave_OAA.FlatStyle = FlatStyle.Flat;
            buttonSave_OAA.Image = (Image)resources.GetObject("buttonSave_OAA.Image");
            buttonSave_OAA.Location = new Point(212, 12);
            buttonSave_OAA.Name = "buttonSave_OAA";
            buttonSave_OAA.Size = new Size(94, 72);
            buttonSave_OAA.TabIndex = 3;
            toolTipHelp_OAA.SetToolTip(buttonSave_OAA, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_OAA.UseVisualStyleBackColor = true;
            buttonSave_OAA.Click += buttonSave_OAA_Click;
            buttonSave_OAA.MouseEnter += buttonSave_OAA_MouseEnter;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.Enabled = false;
            buttonDone_OAA.FlatStyle = FlatStyle.Flat;
            buttonDone_OAA.Image = (Image)resources.GetObject("buttonDone_OAA.Image");
            buttonDone_OAA.Location = new Point(112, 12);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(94, 72);
            buttonDone_OAA.TabIndex = 2;
            toolTipHelp_OAA.SetToolTip(buttonDone_OAA, "Выполнить обработку данных");
            buttonDone_OAA.UseVisualStyleBackColor = true;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            buttonDone_OAA.MouseEnter += buttonDone_OAA_MouseEnter;
            // 
            // buttonLoadFile_OAA
            // 
            buttonLoadFile_OAA.FlatStyle = FlatStyle.Flat;
            buttonLoadFile_OAA.Image = (Image)resources.GetObject("buttonLoadFile_OAA.Image");
            buttonLoadFile_OAA.Location = new Point(12, 12);
            buttonLoadFile_OAA.Name = "buttonLoadFile_OAA";
            buttonLoadFile_OAA.Size = new Size(94, 72);
            buttonLoadFile_OAA.TabIndex = 1;
            toolTipHelp_OAA.SetToolTip(buttonLoadFile_OAA, "Открыть файл для обработки данных в формате CSV");
            buttonLoadFile_OAA.UseVisualStyleBackColor = true;
            buttonLoadFile_OAA.Click += buttonLoadFile_OAA_Click;
            buttonLoadFile_OAA.MouseEnter += buttonLoadFile_OAA_MouseEnter;
            // 
            // groupBoxTaskCondition_OAA
            // 
            groupBoxTaskCondition_OAA.Controls.Add(textBoxCondition_OAA);
            groupBoxTaskCondition_OAA.Dock = DockStyle.Bottom;
            groupBoxTaskCondition_OAA.Location = new Point(0, 83);
            groupBoxTaskCondition_OAA.Name = "groupBoxTaskCondition_OAA";
            groupBoxTaskCondition_OAA.Size = new Size(1212, 103);
            groupBoxTaskCondition_OAA.TabIndex = 0;
            groupBoxTaskCondition_OAA.TabStop = false;
            groupBoxTaskCondition_OAA.Text = "Условие:";
            // 
            // textBoxCondition_OAA
            // 
            textBoxCondition_OAA.Dock = DockStyle.Fill;
            textBoxCondition_OAA.Location = new Point(3, 23);
            textBoxCondition_OAA.Multiline = true;
            textBoxCondition_OAA.Name = "textBoxCondition_OAA";
            textBoxCondition_OAA.ReadOnly = true;
            textBoxCondition_OAA.Size = new Size(1206, 77);
            textBoxCondition_OAA.TabIndex = 0;
            textBoxCondition_OAA.Text = resources.GetString("textBoxCondition_OAA.Text");
            // 
            // panelLeft_OAA
            // 
            panelLeft_OAA.BackColor = SystemColors.Control;
            panelLeft_OAA.Controls.Add(groupBoxInPut_OAA);
            panelLeft_OAA.Dock = DockStyle.Left;
            panelLeft_OAA.Location = new Point(0, 186);
            panelLeft_OAA.Name = "panelLeft_OAA";
            panelLeft_OAA.Size = new Size(916, 388);
            panelLeft_OAA.TabIndex = 1;
            // 
            // groupBoxInPut_OAA
            // 
            groupBoxInPut_OAA.Controls.Add(dataGridViewInPutFile_OAA);
            groupBoxInPut_OAA.Dock = DockStyle.Fill;
            groupBoxInPut_OAA.Location = new Point(0, 0);
            groupBoxInPut_OAA.Name = "groupBoxInPut_OAA";
            groupBoxInPut_OAA.Size = new Size(916, 388);
            groupBoxInPut_OAA.TabIndex = 0;
            groupBoxInPut_OAA.TabStop = false;
            groupBoxInPut_OAA.Text = "Ввод:";
            // 
            // dataGridViewInPutFile_OAA
            // 
            dataGridViewInPutFile_OAA.AllowUserToAddRows = false;
            dataGridViewInPutFile_OAA.AllowUserToDeleteRows = false;
            dataGridViewInPutFile_OAA.AllowUserToResizeColumns = false;
            dataGridViewInPutFile_OAA.AllowUserToResizeRows = false;
            dataGridViewInPutFile_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPutFile_OAA.ColumnHeadersVisible = false;
            dataGridViewInPutFile_OAA.Dock = DockStyle.Fill;
            dataGridViewInPutFile_OAA.Location = new Point(3, 23);
            dataGridViewInPutFile_OAA.Name = "dataGridViewInPutFile_OAA";
            dataGridViewInPutFile_OAA.RowHeadersVisible = false;
            dataGridViewInPutFile_OAA.RowHeadersWidth = 51;
            dataGridViewInPutFile_OAA.Size = new Size(910, 362);
            dataGridViewInPutFile_OAA.TabIndex = 0;
            // 
            // dataGridViewResult_OAA
            // 
            dataGridViewResult_OAA.AllowUserToAddRows = false;
            dataGridViewResult_OAA.AllowUserToDeleteRows = false;
            dataGridViewResult_OAA.AllowUserToResizeColumns = false;
            dataGridViewResult_OAA.AllowUserToResizeRows = false;
            dataGridViewResult_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_OAA.ColumnHeadersVisible = false;
            dataGridViewResult_OAA.Dock = DockStyle.Fill;
            dataGridViewResult_OAA.Location = new Point(3, 23);
            dataGridViewResult_OAA.Name = "dataGridViewResult_OAA";
            dataGridViewResult_OAA.RowHeadersVisible = false;
            dataGridViewResult_OAA.RowHeadersWidth = 51;
            dataGridViewResult_OAA.Size = new Size(290, 362);
            dataGridViewResult_OAA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBoxOutPut_OAA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(916, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 388);
            panel3.TabIndex = 2;
            // 
            // groupBoxOutPut_OAA
            // 
            groupBoxOutPut_OAA.Controls.Add(dataGridViewResult_OAA);
            groupBoxOutPut_OAA.Dock = DockStyle.Fill;
            groupBoxOutPut_OAA.Location = new Point(0, 0);
            groupBoxOutPut_OAA.Name = "groupBoxOutPut_OAA";
            groupBoxOutPut_OAA.Size = new Size(296, 388);
            groupBoxOutPut_OAA.TabIndex = 0;
            groupBoxOutPut_OAA.TabStop = false;
            groupBoxOutPut_OAA.Text = "Вывод:";
            // 
            // toolTipHelp_OAA
            // 
            toolTipHelp_OAA.ForeColor = SystemColors.Highlight;
            toolTipHelp_OAA.IsBalloon = true;
            toolTipHelp_OAA.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_OAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 574);
            Controls.Add(panel3);
            Controls.Add(panelLeft_OAA);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 24 | Осадец А.А.";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            groupBoxTaskCondition_OAA.ResumeLayout(false);
            groupBoxTaskCondition_OAA.PerformLayout();
            panelLeft_OAA.ResumeLayout(false);
            groupBoxInPut_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutFile_OAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_OAA).EndInit();
            panel3.ResumeLayout(false);
            groupBoxOutPut_OAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelLeft_OAA;
        private Panel panel3;
        private GroupBox groupBoxTaskCondition_OAA;
        private TextBox textBoxCondition_OAA;
        private Button buttonHelp_OAA;
        private Button buttonSave_OAA;
        private Button buttonDone_OAA;
        private Button buttonLoadFile_OAA;
        private GroupBox groupBoxInPut_OAA;
        private GroupBox groupBoxOutPut_OAA;
        private DataGridView dataGridViewInPutFile_OAA;
        private DataGridView dataGridViewResult_OAA;
        private OpenFileDialog openFileDialogTask_OAA;
        private ToolTip toolTipHelp_OAA;
        private SaveFileDialog saveFileDialogTask_OAA;
    }
}
