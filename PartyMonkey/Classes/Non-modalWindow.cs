using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PartyMonkey.Forms;

namespace PartyMonkey.Classes
{
    internal class NonModalWindow : Form
    {
        private Form nonModalWindow = new Form();
        private Label label = new Label();
        public void CreateWindow()
        {
            nonModalWindow.Text = $"Non-modal window";
            nonModalWindow.StartPosition = FormStartPosition.CenterScreen;
            nonModalWindow.Size = new Size(545, 340);
            nonModalWindow.BackColor = Color.White;

            label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            label.Location = new System.Drawing.Point(10, 100);
            label.Name = "label1";
            label.Size = new System.Drawing.Size(115, 51);
            label.TabIndex = 30;
            label.Text = "The task table is fucked up";
            nonModalWindow.Controls.Add(label);
            nonModalWindow.Show();
        }
    }
}
