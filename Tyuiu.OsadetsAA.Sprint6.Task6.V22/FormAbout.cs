using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.OsadetsAA.Sprint6.Task6.V22
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormAbout));
            labelInfo_OAA = new Label();
            buttonOK_OAA = new Button();
            pictureBoxAvatar_OAA = new PictureBox();
            ((ISupportInitialize)pictureBoxAvatar_OAA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_OAA
            // 
            labelInfo_OAA.AutoSize = true;
            labelInfo_OAA.Location = new Point(197, 12);
            labelInfo_OAA.Name = "labelInfo_OAA";
            labelInfo_OAA.Size = new Size(387, 200);
            labelInfo_OAA.TabIndex = 1;
            labelInfo_OAA.Text = resources.GetString("labelInfo_OAA.Text");
            // 
            // buttonOK_OAA
            // 
            buttonOK_OAA.BackColor = SystemColors.Control;
            buttonOK_OAA.Location = new Point(481, 225);
            buttonOK_OAA.Name = "buttonOK_OAA";
            buttonOK_OAA.Size = new Size(120, 29);
            buttonOK_OAA.TabIndex = 2;
            buttonOK_OAA.Text = "Ок";
            buttonOK_OAA.UseVisualStyleBackColor = false;
            buttonOK_OAA.Click += buttonOK_OAA_Click;
            // 
            // pictureBoxAvatar_OAA
            // 
            pictureBoxAvatar_OAA.Image = (Image)resources.GetObject("pictureBoxAvatar_OAA.Image");
            pictureBoxAvatar_OAA.Location = new Point(12, 12);
            pictureBoxAvatar_OAA.Name = "pictureBoxAvatar_OAA";
            pictureBoxAvatar_OAA.Size = new Size(179, 228);
            pictureBoxAvatar_OAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_OAA.TabIndex = 0;
            pictureBoxAvatar_OAA.TabStop = false;
            // 
            // FormAbout
            // 
            ClientSize = new Size(608, 260);
            Controls.Add(buttonOK_OAA);
            Controls.Add(labelInfo_OAA);
            Controls.Add(pictureBoxAvatar_OAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(626, 307);
            MinimizeBox = false;
            MinimumSize = new Size(626, 307);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((ISupportInitialize)pictureBoxAvatar_OAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonOK_OAA;
        private PictureBox pictureBoxAvatar_OAA;
        private Label labelInfo_OAA;

        private void buttonOK_OAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
