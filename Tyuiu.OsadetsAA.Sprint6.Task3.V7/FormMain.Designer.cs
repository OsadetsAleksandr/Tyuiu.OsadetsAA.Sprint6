namespace Tyuiu.OsadetsAA.Sprint6.Task3.V7
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
            groupBoxTask = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonQuestion = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewMatrix);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(518, 255);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(268, 26);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(236, 209);
            dataGridViewMatrix.TabIndex = 7;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(262, 209);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(536, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(216, 196);
            groupBoxResult.TabIndex = 7;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(201, 161);
            textBoxResult.TabIndex = 9;
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(542, 234);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(33, 29);
            buttonQuestion.TabIndex = 0;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(581, 234);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(106, 29);
            buttonDone.TabIndex = 8;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 275);
            Controls.Add(buttonDone);
            Controls.Add(buttonQuestion);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 7 | Осадец АА";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private TextBox textBoxMatrix;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonQuestion;
        private Button buttonDone;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
