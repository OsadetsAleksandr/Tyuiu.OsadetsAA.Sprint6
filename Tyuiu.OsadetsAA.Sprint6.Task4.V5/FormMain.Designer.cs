namespace Tyuiu.OsadetsAA.Sprint6.Task4.V5
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_OAA = new GroupBox();
            groupBoxData_OAA = new GroupBox();
            textBoxStartStep_OAA = new TextBox();
            buttonQuestion_OAA = new Button();
            buttonSave_OAA = new Button();
            buttonDone_OAA = new Button();
            textBoxStopStep_OAA = new TextBox();
            textBoxData_OAA = new TextBox();
            textBox1 = new TextBox();
            groupBoxResult_OAA = new GroupBox();
            textBoxResult_OAA = new TextBox();
            chartFunction_OAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            splitter1 = new Splitter();
            button1 = new Button();
            groupBoxTask_OAA.SuspendLayout();
            groupBoxData_OAA.SuspendLayout();
            groupBoxResult_OAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_OAA).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_OAA
            // 
            groupBoxTask_OAA.Controls.Add(groupBoxData_OAA);
            groupBoxTask_OAA.Controls.Add(textBox1);
            groupBoxTask_OAA.Dock = DockStyle.Fill;
            groupBoxTask_OAA.Location = new Point(0, 0);
            groupBoxTask_OAA.Name = "groupBoxTask_OAA";
            groupBoxTask_OAA.Size = new Size(1189, 110);
            groupBoxTask_OAA.TabIndex = 0;
            groupBoxTask_OAA.TabStop = false;
            groupBoxTask_OAA.Text = "Условие:";
            // 
            // groupBoxData_OAA
            // 
            groupBoxData_OAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxData_OAA.Controls.Add(button1);
            groupBoxData_OAA.Controls.Add(textBoxStartStep_OAA);
            groupBoxData_OAA.Controls.Add(buttonQuestion_OAA);
            groupBoxData_OAA.Controls.Add(buttonSave_OAA);
            groupBoxData_OAA.Controls.Add(buttonDone_OAA);
            groupBoxData_OAA.Controls.Add(textBoxStopStep_OAA);
            groupBoxData_OAA.Controls.Add(textBoxData_OAA);
            groupBoxData_OAA.Location = new Point(564, 0);
            groupBoxData_OAA.Name = "groupBoxData_OAA";
            groupBoxData_OAA.Size = new Size(613, 110);
            groupBoxData_OAA.TabIndex = 1;
            groupBoxData_OAA.TabStop = false;
            groupBoxData_OAA.Text = "Ввод данных:";
            // 
            // textBoxStartStep_OAA
            // 
            textBoxStartStep_OAA.Location = new Point(16, 54);
            textBoxStartStep_OAA.Name = "textBoxStartStep_OAA";
            textBoxStartStep_OAA.Size = new Size(125, 27);
            textBoxStartStep_OAA.TabIndex = 1;
            textBoxStartStep_OAA.TextChanged += textBoxStartStep_OAA_TextChanged;
            // 
            // buttonQuestion_OAA
            // 
            buttonQuestion_OAA.BackColor = Color.DodgerBlue;
            buttonQuestion_OAA.Location = new Point(485, 25);
            buttonQuestion_OAA.Name = "buttonQuestion_OAA";
            buttonQuestion_OAA.Size = new Size(94, 65);
            buttonQuestion_OAA.TabIndex = 3;
            buttonQuestion_OAA.Text = "Справка";
            buttonQuestion_OAA.UseVisualStyleBackColor = false;
            buttonQuestion_OAA.Click += buttonQuestion_OAA_Click;
            // 
            // buttonSave_OAA
            // 
            buttonSave_OAA.BackColor = Color.MediumPurple;
            buttonSave_OAA.Location = new Point(385, 25);
            buttonSave_OAA.Name = "buttonSave_OAA";
            buttonSave_OAA.Size = new Size(94, 66);
            buttonSave_OAA.TabIndex = 5;
            buttonSave_OAA.Text = "Сохранить";
            buttonSave_OAA.UseVisualStyleBackColor = false;
            buttonSave_OAA.Click += buttonSave_OAA_Click;
            // 
            // buttonDone_OAA
            // 
            buttonDone_OAA.BackColor = Color.Green;
            buttonDone_OAA.Location = new Point(278, 26);
            buttonDone_OAA.Name = "buttonDone_OAA";
            buttonDone_OAA.Size = new Size(101, 65);
            buttonDone_OAA.TabIndex = 4;
            buttonDone_OAA.Text = "Выполнить";
            buttonDone_OAA.UseVisualStyleBackColor = false;
            buttonDone_OAA.Click += buttonDone_OAA_Click;
            // 
            // textBoxStopStep_OAA
            // 
            textBoxStopStep_OAA.Location = new Point(147, 54);
            textBoxStopStep_OAA.Name = "textBoxStopStep_OAA";
            textBoxStopStep_OAA.Size = new Size(125, 27);
            textBoxStopStep_OAA.TabIndex = 2;
            // 
            // textBoxData_OAA
            // 
            textBoxData_OAA.Location = new Point(9, 25);
            textBoxData_OAA.Multiline = true;
            textBoxData_OAA.Name = "textBoxData_OAA";
            textBoxData_OAA.ReadOnly = true;
            textBoxData_OAA.Size = new Size(263, 65);
            textBoxData_OAA.TabIndex = 0;
            textBoxData_OAA.Text = " Старт шага:             Конец шага:";
            textBoxData_OAA.TextChanged += textBoxData_OAA_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(552, 65);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапазоне [-5, 5]. Результат вывести в textBox, построить график функции и сохранить в текстовый файл OutPutFileTask4.txt по нажатию кнопки.";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxResult_OAA
            // 
            groupBoxResult_OAA.Controls.Add(textBoxResult_OAA);
            groupBoxResult_OAA.Dock = DockStyle.Fill;
            groupBoxResult_OAA.Location = new Point(0, 0);
            groupBoxResult_OAA.Name = "groupBoxResult_OAA";
            groupBoxResult_OAA.Size = new Size(271, 493);
            groupBoxResult_OAA.TabIndex = 2;
            groupBoxResult_OAA.TabStop = false;
            groupBoxResult_OAA.Text = "Вывод:";
            // 
            // textBoxResult_OAA
            // 
            textBoxResult_OAA.Dock = DockStyle.Fill;
            textBoxResult_OAA.Location = new Point(3, 23);
            textBoxResult_OAA.Multiline = true;
            textBoxResult_OAA.Name = "textBoxResult_OAA";
            textBoxResult_OAA.ReadOnly = true;
            textBoxResult_OAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_OAA.Size = new Size(265, 467);
            textBoxResult_OAA.TabIndex = 0;
            textBoxResult_OAA.TextChanged += textBoxResult_OAA_TextChanged;
            // 
            // chartFunction_OAA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_OAA.ChartAreas.Add(chartArea1);
            chartFunction_OAA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_OAA.Legends.Add(legend1);
            chartFunction_OAA.Location = new Point(0, 0);
            chartFunction_OAA.Name = "chartFunction_OAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_OAA.Series.Add(series1);
            chartFunction_OAA.Size = new Size(918, 493);
            chartFunction_OAA.TabIndex = 3;
            chartFunction_OAA.Text = "График";
            title1.Font = new Font("Microsoft Sans Serif", 16F);
            title1.ForeColor = Color.Blue;
            title1.Name = "График функции";
            title1.Text = "График функции";
            chartFunction_OAA.Titles.Add(title1);
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask_OAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 110);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxResult_OAA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 493);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chartFunction_OAA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(271, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 493);
            panel3.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Padding = new Padding(5);
            splitter1.Size = new Size(4, 493);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(364, 80);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 603);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1207, 650);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 5 | Осадец АА";
            groupBoxTask_OAA.ResumeLayout(false);
            groupBoxTask_OAA.PerformLayout();
            groupBoxData_OAA.ResumeLayout(false);
            groupBoxData_OAA.PerformLayout();
            groupBoxResult_OAA.ResumeLayout(false);
            groupBoxResult_OAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_OAA).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_OAA;
        private TextBox textBox1;
        private GroupBox groupBoxData_OAA;
        private TextBox textBoxData_OAA;
        private Button buttonSave_OAA;
        private Button buttonDone_OAA;
        private Button buttonQuestion_OAA;
        private TextBox textBoxStopStep_OAA;
        private TextBox textBoxStartStep_OAA;
        private GroupBox groupBoxResult_OAA;
        private TextBox textBoxResult_OAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_OAA;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Button button1;
    }
}
