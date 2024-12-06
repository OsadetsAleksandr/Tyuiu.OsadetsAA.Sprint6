namespace Tyuiu.OsadetsAA.Sprint6.Task1.V26
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
            textBoxTask = new TextBox();
            groupBoxVarStartStop = new GroupBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            textBox1 = new TextBox();
            buttonQuestion = new Button();
            buttonDone = new Button();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBoxVarStartStop.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(527, 285);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(515, 253);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Произвести табулирование функции на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на 0. Округлить до двух знаков после запятой.";
            // 
            // groupBoxVarStartStop
            // 
            groupBoxVarStartStop.Controls.Add(textBoxStop);
            groupBoxVarStartStop.Controls.Add(textBoxStart);
            groupBoxVarStartStop.Controls.Add(textBox1);
            groupBoxVarStartStop.Location = new Point(18, 303);
            groupBoxVarStartStop.Name = "groupBoxVarStartStop";
            groupBoxVarStartStop.Size = new Size(280, 125);
            groupBoxVarStartStop.TabIndex = 1;
            groupBoxVarStartStop.TabStop = false;
            groupBoxVarStartStop.Text = "Ввод данных:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(137, 78);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 3;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 78);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(268, 68);
            textBox1.TabIndex = 0;
            textBox1.Text = "Старт шага:            Конец шага:";
            // 
            // buttonQuestion
            // 
            buttonQuestion.BackColor = Color.LightSkyBlue;
            buttonQuestion.Location = new Point(315, 314);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(105, 108);
            buttonQuestion.TabIndex = 4;
            buttonQuestion.Text = "Справка";
            buttonQuestion.UseVisualStyleBackColor = false;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Red;
            buttonDone.Location = new Point(426, 314);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(113, 108);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(545, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(250, 400);
            groupBoxResult.TabIndex = 6;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(238, 360);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonDone);
            Controls.Add(buttonQuestion);
            Controls.Add(groupBoxVarStartStop);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Осадец АА";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxVarStartStop.ResumeLayout(false);
            groupBoxVarStartStop.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxVarStartStop;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBox1;
        private Button buttonQuestion;
        private Button buttonDone;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
    }
}
