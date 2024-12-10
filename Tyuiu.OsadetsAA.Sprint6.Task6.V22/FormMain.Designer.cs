namespace Tyuiu.OsadetsAA.Sprint6.Task6.V22
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
            panelTop_OAA = new Panel();
            groupBoxTaskCondition_OAA = new GroupBox();
            textBoxTask_OAA = new TextBox();
            groupBoxButtons_OAA = new GroupBox();
            buttonReference_OAA = new Button();
            buttonDone_OAA = new Button();
            buttonLoadFile_OAA = new Button();
            panelLeft_OAA = new Panel();
            groupBoxInPut_OAA = new GroupBox();
            textBoxLoadFromFile_OAA = new TextBox();
            panelRight_OAA = new Panel();
            groupBoxOutPut_OAA = new GroupBox();
            textBoxResult_OAA = new TextBox();
            openFileDialogTask_OAA = new OpenFileDialog();
            toolTip_OAA = new ToolTip(components);
            panelTop_OAA.SuspendLayout();
            groupBoxTaskCondition_OAA.SuspendLayout();
            groupBoxButtons_OAA.SuspendLayout();
            panelLeft_OAA.SuspendLayout();
            groupBoxInPut_OAA.SuspendLayout();
            panelRight_OAA.SuspendLayout();
            groupBoxOutPut_OAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_OAA
            // 
            panelTop_OAA.Controls.Add(groupBoxTaskCondition_OAA);
            panelTop_OAA.Controls.Add(groupBoxButtons_OAA);
            panelTop_OAA.Dock = DockStyle.Top;
            panelTop_OAA.Location = new Point(0, 0);
            panelTop_OAA.Name = "panelTop_OAA";
            panelTop_OAA.Size = new Size(1035, 166);
            panelTop_OAA.TabIndex = 0;
            // 
            // groupBoxTaskCondition_OAA
            // 
            groupBoxTaskCondition_OAA.Controls.Add(textBoxTask_OAA);
            groupBoxTaskCondition_OAA.Dock = DockStyle.Top;
            groupBoxTaskCondition_OAA.Location = new Point(0, 82);
            groupBoxTaskCondition_OAA.Name = "groupBoxTaskCondition_OAA";
            groupBoxTaskCondition_OAA.Size = new Size(1035, 106);
            groupBoxTaskCondition_OAA.TabIndex = 1;
            groupBoxTaskCondition_OAA.TabStop = false;
            groupBoxTaskCondition_OAA.Text = "Условие:";
            // 
            // textBoxTask_OAA
            // 
            textBoxTask_OAA.Dock = DockStyle.Top;
            textBoxTask_OAA.Location = new Point(3, 23);
            textBoxTask_OAA.Multiline = true;
            textBoxTask_OAA.Name = "textBoxTask_OAA";
            textBoxTask_OAA.ReadOnly = true;
            textBoxTask_OAA.Size = new Size(1029, 77);
            textBoxTask_OAA.TabIndex = 0;
            textBoxTask_OAA.Text = resources.GetString("textBoxTask_OAA.Text");
            // 
            // groupBoxButtons_OAA
            // 
            groupBoxButtons_OAA.Controls.Add(buttonReference_OAA);
            groupBoxButtons_OAA.Controls.Add(buttonDone_OAA);
            groupBoxButtons_OAA.Controls.Add(buttonLoadFile_OAA);
            groupBoxButtons_OAA.Dock = DockStyle.Top;
            groupBoxButtons_OAA.Location = new Point(0, 0);
            groupBoxButtons_OAA.Name = "groupBoxButtons_OAA";
            groupBoxButtons_OAA.Size = new Size(1035, 82);
            groupBoxButtons_OAA.TabIndex = 0;
            groupBoxButtons_OAA.TabStop = false;
            // 
            // buttonReference_OAA
            // 
            buttonReference_OAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReference_OAA.Image = (Image)resources.GetObject("buttonReference_OAA.Image");
            buttonReference_OAA.Location = new Point(929, 12);
            buttonReference_OAA.Name = "buttonReference_OAA";
            buttonReference_OAA.Size = new Size(94, 64);
            buttonReference_OAA.TabIndex = 2;
            toolTip_OAA.SetToolTip(buttonReference_OAA, "Сведение о программе");
            buttonReference_OAA.UseVisualStyleBackColor = true;
            buttonReference_OAA.Click += buttonReference_OAA_Click;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.Image = (Image)resources.GetObject("buttonDone_OAA.Image");
            buttonDone_OAA.Location = new Point(106, 12);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(94, 64);
            buttonDone_OAA.TabIndex = 1;
            toolTip_OAA.SetToolTip(buttonDone_OAA, "Выводит первое слово каждой строки \r\nв результирующею строку\r\n");
            buttonDone_OAA.UseVisualStyleBackColor = true;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // buttonLoadFile_OAA
            // 
            buttonLoadFile_OAA.Image = (Image)resources.GetObject("buttonLoadFile_OAA.Image");
            buttonLoadFile_OAA.Location = new Point(6, 12);
            buttonLoadFile_OAA.Name = "buttonLoadFile_OAA";
            buttonLoadFile_OAA.Size = new Size(94, 64);
            buttonLoadFile_OAA.TabIndex = 0;
            toolTip_OAA.SetToolTip(buttonLoadFile_OAA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonLoadFile_OAA.UseVisualStyleBackColor = true;
            buttonLoadFile_OAA.Click += buttonLoadFile_OAA_Click;
            // 
            // panelLeft_OAA
            // 
            panelLeft_OAA.Controls.Add(groupBoxInPut_OAA);
            panelLeft_OAA.Dock = DockStyle.Left;
            panelLeft_OAA.Location = new Point(0, 166);
            panelLeft_OAA.Name = "panelLeft_OAA";
            panelLeft_OAA.Size = new Size(474, 416);
            panelLeft_OAA.TabIndex = 1;
            // 
            // groupBoxInPut_OAA
            // 
            groupBoxInPut_OAA.Controls.Add(textBoxLoadFromFile_OAA);
            groupBoxInPut_OAA.Dock = DockStyle.Fill;
            groupBoxInPut_OAA.Location = new Point(0, 0);
            groupBoxInPut_OAA.Name = "groupBoxInPut_OAA";
            groupBoxInPut_OAA.Size = new Size(474, 416);
            groupBoxInPut_OAA.TabIndex = 0;
            groupBoxInPut_OAA.TabStop = false;
            groupBoxInPut_OAA.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_OAA
            // 
            textBoxLoadFromFile_OAA.Dock = DockStyle.Fill;
            textBoxLoadFromFile_OAA.Location = new Point(3, 23);
            textBoxLoadFromFile_OAA.Multiline = true;
            textBoxLoadFromFile_OAA.Name = "textBoxLoadFromFile_OAA";
            textBoxLoadFromFile_OAA.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_OAA.Size = new Size(468, 390);
            textBoxLoadFromFile_OAA.TabIndex = 0;
            // 
            // panelRight_OAA
            // 
            panelRight_OAA.Controls.Add(groupBoxOutPut_OAA);
            panelRight_OAA.Dock = DockStyle.Fill;
            panelRight_OAA.Location = new Point(474, 166);
            panelRight_OAA.Name = "panelRight_OAA";
            panelRight_OAA.Size = new Size(561, 416);
            panelRight_OAA.TabIndex = 2;
            // 
            // groupBoxOutPut_OAA
            // 
            groupBoxOutPut_OAA.Controls.Add(textBoxResult_OAA);
            groupBoxOutPut_OAA.Dock = DockStyle.Fill;
            groupBoxOutPut_OAA.Location = new Point(0, 0);
            groupBoxOutPut_OAA.Name = "groupBoxOutPut_OAA";
            groupBoxOutPut_OAA.Size = new Size(561, 416);
            groupBoxOutPut_OAA.TabIndex = 0;
            groupBoxOutPut_OAA.TabStop = false;
            groupBoxOutPut_OAA.Text = "Вывод:";
            // 
            // textBoxResult_OAA
            // 
            textBoxResult_OAA.Dock = DockStyle.Fill;
            textBoxResult_OAA.Location = new Point(3, 23);
            textBoxResult_OAA.Multiline = true;
            textBoxResult_OAA.Name = "textBoxResult_OAA";
            textBoxResult_OAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_OAA.Size = new Size(555, 390);
            textBoxResult_OAA.TabIndex = 0;
            // 
            // openFileDialogTask_OAA
            // 
            openFileDialogTask_OAA.FileName = "openFileDialogTask";
            // 
            // toolTip_OAA
            // 
            toolTip_OAA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_OAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 582);
            Controls.Add(panelRight_OAA);
            Controls.Add(panelLeft_OAA);
            Controls.Add(panelTop_OAA);
            MinimumSize = new Size(1053, 629);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Осадец А. А.";
            panelTop_OAA.ResumeLayout(false);
            groupBoxTaskCondition_OAA.ResumeLayout(false);
            groupBoxTaskCondition_OAA.PerformLayout();
            groupBoxButtons_OAA.ResumeLayout(false);
            panelLeft_OAA.ResumeLayout(false);
            groupBoxInPut_OAA.ResumeLayout(false);
            groupBoxInPut_OAA.PerformLayout();
            panelRight_OAA.ResumeLayout(false);
            groupBoxOutPut_OAA.ResumeLayout(false);
            groupBoxOutPut_OAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_OAA;
        private GroupBox groupBoxTaskCondition_OAA;
        private GroupBox groupBoxButtons_OAA;
        private Panel panelLeft_OAA;
        private Panel panelRight_OAA;
        private TextBox textBoxTask_OAA;
        private GroupBox groupBoxInPut_OAA;
        private Button buttonReference_OAA;
        private Button buttonDone_OAA;
        private Button buttonLoadFile_OAA;
        private GroupBox groupBoxOutPut_OAA;
        private TextBox textBoxResult_OAA;
        private ToolTip toolTip_OAA;
        private OpenFileDialog openFileDialogTask_OAA;
        private TextBox textBoxLoadFromFile_OAA;
    }
}
