namespace PartyMonkey.Forms
{
    partial class Capcha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capcha));
            this.CapchaBox = new System.Windows.Forms.PictureBox();
            this.сheckButton = new System.Windows.Forms.Button();
            this.сhangeButton = new System.Windows.Forms.Button();
            this.CheckTextBox = new System.Windows.Forms.TextBox();
            this.EnterCapcha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CapchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CapchaBox
            // 
            this.CapchaBox.Location = new System.Drawing.Point(320, 12);
            this.CapchaBox.Name = "CapchaBox";
            this.CapchaBox.Size = new System.Drawing.Size(254, 171);
            this.CapchaBox.TabIndex = 3;
            this.CapchaBox.TabStop = false;
            // 
            // сheckButton
            // 
            this.сheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.сheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.сheckButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сheckButton.ForeColor = System.Drawing.Color.White;
            this.сheckButton.Location = new System.Drawing.Point(71, 198);
            this.сheckButton.Name = "сheckButton";
            this.сheckButton.Size = new System.Drawing.Size(125, 35);
            this.сheckButton.TabIndex = 22;
            this.сheckButton.Text = "Check";
            this.сheckButton.UseVisualStyleBackColor = false;
            this.сheckButton.Click += new System.EventHandler(this.сheckButton_Click);
            // 
            // сhangeButton
            // 
            this.сhangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.сhangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.сhangeButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сhangeButton.ForeColor = System.Drawing.Color.White;
            this.сhangeButton.Location = new System.Drawing.Point(381, 198);
            this.сhangeButton.Name = "сhangeButton";
            this.сhangeButton.Size = new System.Drawing.Size(125, 35);
            this.сhangeButton.TabIndex = 23;
            this.сhangeButton.Text = "Change";
            this.сhangeButton.UseVisualStyleBackColor = false;
            this.сhangeButton.Click += new System.EventHandler(this.сhangeButton_Click);
            // 
            // CheckTextBox
            // 
            this.CheckTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CheckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckTextBox.ForeColor = System.Drawing.Color.Black;
            this.CheckTextBox.Location = new System.Drawing.Point(23, 124);
            this.CheckTextBox.Name = "CheckTextBox";
            this.CheckTextBox.Size = new System.Drawing.Size(233, 41);
            this.CheckTextBox.TabIndex = 24;
            // 
            // EnterCapcha
            // 
            this.EnterCapcha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterCapcha.AutoSize = true;
            this.EnterCapcha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterCapcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.EnterCapcha.Location = new System.Drawing.Point(40, 63);
            this.EnterCapcha.Name = "EnterCapcha";
            this.EnterCapcha.Size = new System.Drawing.Size(178, 30);
            this.EnterCapcha.TabIndex = 25;
            this.EnterCapcha.Text = "Enter a captcha";
            // 
            // Capcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 261);
            this.Controls.Add(this.EnterCapcha);
            this.Controls.Add(this.CheckTextBox);
            this.Controls.Add(this.сhangeButton);
            this.Controls.Add(this.сheckButton);
            this.Controls.Add(this.CapchaBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Capcha";
            this.Text = "Capcha";
            this.Load += new System.EventHandler(this.Capcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CapchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CapchaBox;
        private System.Windows.Forms.Button сheckButton;
        private System.Windows.Forms.Button сhangeButton;
        private System.Windows.Forms.TextBox CheckTextBox;
        private System.Windows.Forms.Label EnterCapcha;
    }
}