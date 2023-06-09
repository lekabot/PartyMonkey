namespace PartyMonkey.Forms
{
    partial class LoginAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAs));
            this.choose = new System.Windows.Forms.Label();
            this.Organizers = new System.Windows.Forms.Button();
            this.Moderators = new System.Windows.Forms.Button();
            this.Participants = new System.Windows.Forms.Button();
            this.Jury = new System.Windows.Forms.Button();
            this.Anonymous = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(0, 0);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(100, 23);
            this.choose.TabIndex = 0;
            // 
            // Organizers
            // 
            this.Organizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Organizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Organizers.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Organizers.ForeColor = System.Drawing.Color.White;
            this.Organizers.Location = new System.Drawing.Point(322, 246);
            this.Organizers.Name = "Organizers";
            this.Organizers.Size = new System.Drawing.Size(150, 60);
            this.Organizers.TabIndex = 19;
            this.Organizers.Text = "Organizer";
            this.Organizers.UseVisualStyleBackColor = false;
            this.Organizers.Click += new System.EventHandler(this.button_Click);
            // 
            // Moderators
            // 
            this.Moderators.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Moderators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moderators.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Moderators.ForeColor = System.Drawing.Color.White;
            this.Moderators.Location = new System.Drawing.Point(322, 180);
            this.Moderators.Name = "Moderators";
            this.Moderators.Size = new System.Drawing.Size(150, 60);
            this.Moderators.TabIndex = 18;
            this.Moderators.Text = "Moderator";
            this.Moderators.UseVisualStyleBackColor = false;
            this.Moderators.Click += new System.EventHandler(this.button_Click);
            // 
            // Participants
            // 
            this.Participants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Participants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Participants.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Participants.ForeColor = System.Drawing.Color.White;
            this.Participants.Location = new System.Drawing.Point(322, 312);
            this.Participants.Name = "Participants";
            this.Participants.Size = new System.Drawing.Size(150, 60);
            this.Participants.TabIndex = 21;
            this.Participants.Text = "Participant";
            this.Participants.UseVisualStyleBackColor = false;
            this.Participants.Click += new System.EventHandler(this.button_Click);
            // 
            // Jury
            // 
            this.Jury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Jury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jury.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Jury.ForeColor = System.Drawing.Color.White;
            this.Jury.Location = new System.Drawing.Point(322, 114);
            this.Jury.Name = "Jury";
            this.Jury.Size = new System.Drawing.Size(150, 60);
            this.Jury.TabIndex = 20;
            this.Jury.Text = "Jury";
            this.Jury.UseVisualStyleBackColor = false;
            this.Jury.Click += new System.EventHandler(this.button_Click);
            // 
            // Anonymous
            // 
            this.Anonymous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Anonymous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anonymous.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Anonymous.ForeColor = System.Drawing.Color.White;
            this.Anonymous.Location = new System.Drawing.Point(322, 378);
            this.Anonymous.Name = "Anonymous";
            this.Anonymous.Size = new System.Drawing.Size(150, 60);
            this.Anonymous.TabIndex = 23;
            this.Anonymous.Text = "Anonymous";
            this.Anonymous.UseVisualStyleBackColor = false;
            this.Anonymous.Click += new System.EventHandler(this.button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(219, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 51);
            this.label2.TabIndex = 24;
            this.label2.Text = "Choose your fighter";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(697, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 27);
            this.back.TabIndex = 25;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // LoginAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Anonymous);
            this.Controls.Add(this.Participants);
            this.Controls.Add(this.Jury);
            this.Controls.Add(this.Organizers);
            this.Controls.Add(this.Moderators);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginAs";
            this.Text = "LoginAs";
            this.Load += new System.EventHandler(this.Loader);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choose;
        private System.Windows.Forms.Button Organizers;
        private System.Windows.Forms.Button Moderators;
        private System.Windows.Forms.Button Participants;
        private System.Windows.Forms.Button Jury;
        private System.Windows.Forms.Button Anonymous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
    }
}