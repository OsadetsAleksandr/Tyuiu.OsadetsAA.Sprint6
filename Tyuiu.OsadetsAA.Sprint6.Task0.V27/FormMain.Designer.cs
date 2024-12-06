namespace Tyuiu.OsadetsAA.Sprint6.Task0.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVarX = new GroupBox();
            textBoxVarX = new TextBox();
            groupBoxResult = new GroupBox();
            buttonQuestion = new Button();
            buttonOk = new Button();
            textBoxResult = new TextBox();
            pictureBoxFormula = new PictureBox();
            groupBoxTask.SuspendLayout();
            groupBoxVarX.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 253);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(0, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(406, 227);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Вычислить по формуле";
            // 
            // groupBoxVarX
            // 
            groupBoxVarX.Controls.Add(textBoxVarX);
            groupBoxVarX.Location = new Point(12, 291);
            groupBoxVarX.Name = "groupBoxVarX";
            groupBoxVarX.Size = new Size(482, 125);
            groupBoxVarX.TabIndex = 0;
            groupBoxVarX.TabStop = false;
            groupBoxVarX.Text = "Ввод данных:";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(16, 39);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(125, 27);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(buttonQuestion);
            groupBoxResult.Controls.Add(buttonOk);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(500, 291);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(278, 125);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(58, 72);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(94, 29);
            buttonQuestion.TabIndex = 5;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(158, 72);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(100, 29);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Выполнить";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(58, 39);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 3;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(424, 38);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(354, 227);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxFormula);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxVarX);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 27 | Осадец АА";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxVarX.ResumeLayout(false);
            groupBoxVarX.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxVarX;
        private GroupBox groupBoxResult;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxVarX;
        private Button buttonQuestion;
        private Button buttonOk;
        private TextBox textBoxResult;
    }
}
