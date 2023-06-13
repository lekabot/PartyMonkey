namespace PartyMonkey.Forms
{
    partial class OrganizerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizerWindow));
            this.nameTextBox = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureOrganaizer = new System.Windows.Forms.PictureBox();
            this.myProfileBT = new System.Windows.Forms.Button();
            this.jutyBT = new System.Windows.Forms.Button();
            this.participantsBT = new System.Windows.Forms.Button();
            this.eventVT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrganaizer)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.nameTextBox.Location = new System.Drawing.Point(243, 188);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(371, 30);
            this.nameTextBox.TabIndex = 30;
            this.nameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.timeTextBox.Location = new System.Drawing.Point(243, 186);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(371, 30);
            this.timeTextBox.TabIndex = 29;
            this.timeTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(266, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 51);
            this.label1.TabIndex = 28;
            this.label1.Text = "Organizer window";
            // 
            // pictureOrganaizer
            // 
            this.pictureOrganaizer.Location = new System.Drawing.Point(41, 118);
            this.pictureOrganaizer.Name = "pictureOrganaizer";
            this.pictureOrganaizer.Size = new System.Drawing.Size(181, 250);
            this.pictureOrganaizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOrganaizer.TabIndex = 31;
            this.pictureOrganaizer.TabStop = false;
            // 
            // myProfileBT
            // 
            this.myProfileBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.myProfileBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileBT.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myProfileBT.ForeColor = System.Drawing.Color.White;
            this.myProfileBT.Location = new System.Drawing.Point(58, 399);
            this.myProfileBT.Name = "myProfileBT";
            this.myProfileBT.Size = new System.Drawing.Size(150, 60);
            this.myProfileBT.TabIndex = 32;
            this.myProfileBT.Text = "My profile";
            this.myProfileBT.UseVisualStyleBackColor = false;
            this.myProfileBT.Click += new System.EventHandler(this.myProfileBT_Click);
            // 
            // jutyBT
            // 
            this.jutyBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.jutyBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jutyBT.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jutyBT.ForeColor = System.Drawing.Color.White;
            this.jutyBT.Location = new System.Drawing.Point(250, 374);
            this.jutyBT.Name = "jutyBT";
            this.jutyBT.Size = new System.Drawing.Size(362, 86);
            this.jutyBT.TabIndex = 35;
            this.jutyBT.Text = "Jury";
            this.jutyBT.UseVisualStyleBackColor = false;
            this.jutyBT.Click += new System.EventHandler(this.jutyBT_Click);
            // 
            // participantsBT
            // 
            this.participantsBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.participantsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.participantsBT.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.participantsBT.ForeColor = System.Drawing.Color.White;
            this.participantsBT.Location = new System.Drawing.Point(250, 282);
            this.participantsBT.Name = "participantsBT";
            this.participantsBT.Size = new System.Drawing.Size(362, 86);
            this.participantsBT.TabIndex = 36;
            this.participantsBT.Text = "Participants";
            this.participantsBT.UseVisualStyleBackColor = false;
            this.participantsBT.Click += new System.EventHandler(this.participantsBT_Click);
            // 
            // eventVT
            // 
            this.eventVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.eventVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventVT.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventVT.ForeColor = System.Drawing.Color.White;
            this.eventVT.Location = new System.Drawing.Point(250, 190);
            this.eventVT.Name = "eventVT";
            this.eventVT.Size = new System.Drawing.Size(362, 86);
            this.eventVT.TabIndex = 37;
            this.eventVT.Text = "Events";
            this.eventVT.UseVisualStyleBackColor = false;
            this.eventVT.Click += new System.EventHandler(this.eventVT_Click);
            // 
            // OrganizerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.eventVT);
            this.Controls.Add(this.participantsBT);
            this.Controls.Add(this.jutyBT);
            this.Controls.Add(this.myProfileBT);
            this.Controls.Add(this.pictureOrganaizer);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizerWindow";
            this.Text = "OrganizerWindow";
            this.Load += new System.EventHandler(this.OrganizerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrganaizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameTextBox;
        private System.Windows.Forms.Label timeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureOrganaizer;
        private System.Windows.Forms.Button myProfileBT;
        private System.Windows.Forms.Button jutyBT;
        private System.Windows.Forms.Button participantsBT;
        private System.Windows.Forms.Button eventVT;
    }
}