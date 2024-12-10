namespace Tyuiu.OsadetsAA.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_OAA = new Panel();
            buttonReference_OAA = new Button();
            buttonFile_OAA = new Button();
            buttonDone_OAA = new Button();
            groupBoxTask_OAA = new GroupBox();
            textBox1 = new TextBox();
            panelLeft_OAA = new Panel();
            groupBoxResult_OAA = new GroupBox();
            dataGridViewNums_OAA = new DataGridView();
            panelFill_OAA = new Panel();
            splitterLeft_OAA = new Splitter();
            chartResult_OAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_OAA.SuspendLayout();
            groupBoxTask_OAA.SuspendLayout();
            panelLeft_OAA.SuspendLayout();
            groupBoxResult_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_OAA).BeginInit();
            panelFill_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_OAA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_OAA
            // 
            panelTop_OAA.Controls.Add(buttonReference_OAA);
            panelTop_OAA.Controls.Add(buttonFile_OAA);
            panelTop_OAA.Controls.Add(buttonDone_OAA);
            panelTop_OAA.Controls.Add(groupBoxTask_OAA);
            panelTop_OAA.Dock = DockStyle.Top;
            panelTop_OAA.Location = new Point(0, 0);
            panelTop_OAA.Name = "panelTop_OAA";
            panelTop_OAA.Size = new Size(879, 125);
            panelTop_OAA.TabIndex = 0;
            // 
            // buttonReference_OAA
            // 
            buttonReference_OAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReference_OAA.BackColor = Color.DeepSkyBlue;
            buttonReference_OAA.Location = new Point(773, 26);
            buttonReference_OAA.Name = "buttonReference_OAA";
            buttonReference_OAA.Size = new Size(94, 76);
            buttonReference_OAA.TabIndex = 3;
            buttonReference_OAA.Text = "Справка";
            buttonReference_OAA.UseVisualStyleBackColor = false;
            buttonReference_OAA.Click += buttonReference_OAA_Click;
            // 
            // buttonFile_OAA
            // 
            buttonFile_OAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFile_OAA.BackColor = Color.BlueViolet;
            buttonFile_OAA.Location = new Point(673, 26);
            buttonFile_OAA.Name = "buttonFile_OAA";
            buttonFile_OAA.Size = new Size(94, 76);
            buttonFile_OAA.TabIndex = 2;
            buttonFile_OAA.Text = "Открыть файл";
            buttonFile_OAA.UseVisualStyleBackColor = false;
            buttonFile_OAA.Click += buttonFile_OAA_Click;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_OAA.BackColor = Color.Green;
            buttonDone_OAA.Location = new Point(542, 26);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(125, 76);
            buttonDone_OAA.TabIndex = 1;
            buttonDone_OAA.Text = "Выполнить";
            buttonDone_OAA.UseVisualStyleBackColor = false;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // groupBoxTask_OAA
            // 
            groupBoxTask_OAA.Controls.Add(textBox1);
            groupBoxTask_OAA.Dock = DockStyle.Fill;
            groupBoxTask_OAA.Location = new Point(0, 0);
            groupBoxTask_OAA.Name = "groupBoxTask_OAA";
            groupBoxTask_OAA.Size = new Size(879, 125);
            groupBoxTask_OAA.TabIndex = 0;
            groupBoxTask_OAA.TabStop = false;
            groupBoxTask_OAA.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(495, 93);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла InPutDataFileTask5V4.txt. Вывести в dataGridView целые значения и построить диаграмму по этим значениям.";
            // 
            // panelLeft_OAA
            // 
            panelLeft_OAA.BackColor = SystemColors.Control;
            panelLeft_OAA.Controls.Add(groupBoxResult_OAA);
            panelLeft_OAA.Dock = DockStyle.Left;
            panelLeft_OAA.Location = new Point(0, 125);
            panelLeft_OAA.Name = "panelLeft_OAA";
            panelLeft_OAA.Size = new Size(250, 435);
            panelLeft_OAA.TabIndex = 1;
            // 
            // groupBoxResult_OAA
            // 
            groupBoxResult_OAA.Controls.Add(dataGridViewNums_OAA);
            groupBoxResult_OAA.Dock = DockStyle.Fill;
            groupBoxResult_OAA.Location = new Point(0, 0);
            groupBoxResult_OAA.Name = "groupBoxResult_OAA";
            groupBoxResult_OAA.Size = new Size(250, 435);
            groupBoxResult_OAA.TabIndex = 0;
            groupBoxResult_OAA.TabStop = false;
            groupBoxResult_OAA.Text = "Вывод:";
            // 
            // dataGridViewNums_OAA
            // 
            dataGridViewNums_OAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_OAA.Dock = DockStyle.Fill;
            dataGridViewNums_OAA.Location = new Point(3, 23);
            dataGridViewNums_OAA.Name = "dataGridViewNums_OAA";
            dataGridViewNums_OAA.RowHeadersVisible = false;
            dataGridViewNums_OAA.RowHeadersWidth = 51;
            dataGridViewNums_OAA.Size = new Size(244, 409);
            dataGridViewNums_OAA.TabIndex = 0;
            // 
            // panelFill_OAA
            // 
            panelFill_OAA.BackColor = Color.White;
            panelFill_OAA.Controls.Add(splitterLeft_OAA);
            panelFill_OAA.Controls.Add(chartResult_OAA);
            panelFill_OAA.Dock = DockStyle.Fill;
            panelFill_OAA.Location = new Point(250, 125);
            panelFill_OAA.Name = "panelFill_OAA";
            panelFill_OAA.Size = new Size(629, 435);
            panelFill_OAA.TabIndex = 2;
            // 
            // splitterLeft_OAA
            // 
            splitterLeft_OAA.Location = new Point(0, 0);
            splitterLeft_OAA.Name = "splitterLeft_OAA";
            splitterLeft_OAA.Size = new Size(4, 435);
            splitterLeft_OAA.TabIndex = 2;
            splitterLeft_OAA.TabStop = false;
            // 
            // chartResult_OAA
            // 
            chartResult_OAA.BackColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartResult_OAA.ChartAreas.Add(chartArea1);
            chartResult_OAA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartResult_OAA.Legends.Add(legend1);
            chartResult_OAA.Location = new Point(0, 0);
            chartResult_OAA.Name = "chartResult_OAA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_OAA.Series.Add(series1);
            chartResult_OAA.Size = new Size(629, 435);
            chartResult_OAA.TabIndex = 1;
            chartResult_OAA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 560);
            Controls.Add(panelFill_OAA);
            Controls.Add(panelLeft_OAA);
            Controls.Add(panelTop_OAA);
            MinimumSize = new Size(897, 607);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 4 | Осадец АА";
            panelTop_OAA.ResumeLayout(false);
            groupBoxTask_OAA.ResumeLayout(false);
            groupBoxTask_OAA.PerformLayout();
            panelLeft_OAA.ResumeLayout(false);
            groupBoxResult_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_OAA).EndInit();
            panelFill_OAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_OAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_OAA;
        private Panel panelLeft_OAA;
        private Panel panelFill_OAA;
        private Button buttonDone_OAA;
        private GroupBox groupBoxTask_OAA;
        private TextBox textBox1;
        private Button buttonReference_OAA;
        private Button buttonFile_OAA;
        private GroupBox groupBoxResult_OAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_OAA;
        private DataGridView dataGridViewNums_OAA;
        private Splitter splitterLeft_OAA;
    }
}
