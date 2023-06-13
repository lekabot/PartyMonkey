namespace PartyMonkey.Forms
{
    partial class RegistrationParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationParticipant));
            this.label11 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.visiblePassword = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordRepeate = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.pictureOrganaizer = new System.Windows.Forms.PictureBox();
            this.e = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.ComboBox();
            this.bd = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.ComboBox();
            this.p = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.idNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gender1 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrganaizer)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label11.Location = new System.Drawing.Point(67, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 111;
            this.label11.Text = "Phone:";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phone.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.phone.Location = new System.Drawing.Point(137, 408);
            this.phone.Mask = "+7(000)-00-0000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(250, 30);
            this.phone.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(51, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 106;
            this.label6.Text = "Country:";
            // 
            // visiblePassword
            // 
            this.visiblePassword.AutoSize = true;
            this.visiblePassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.visiblePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.visiblePassword.Location = new System.Drawing.Point(593, 522);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(156, 27);
            this.visiblePassword.TabIndex = 104;
            this.visiblePassword.Text = "Visible Password";
            this.visiblePassword.UseVisualStyleBackColor = true;
            this.visiblePassword.CheckedChanged += new System.EventHandler(this.visiblePassword_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(545, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 103;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signin.ForeColor = System.Drawing.Color.White;
            this.signin.Location = new System.Drawing.Point(665, 567);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(114, 41);
            this.signin.TabIndex = 102;
            this.signin.Text = "Cancel";
            this.signin.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(471, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 23);
            this.label10.TabIndex = 101;
            this.label10.Text = "Repeat password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(531, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 100;
            this.label9.Text = "Password:";
            // 
            // passwordRepeate
            // 
            this.passwordRepeate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.passwordRepeate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordRepeate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.passwordRepeate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.passwordRepeate.Location = new System.Drawing.Point(625, 486);
            this.passwordRepeate.Name = "passwordRepeate";
            this.passwordRepeate.Size = new System.Drawing.Size(154, 30);
            this.passwordRepeate.TabIndex = 99;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.password.Location = new System.Drawing.Point(624, 446);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(154, 30);
            this.password.TabIndex = 98;
            // 
            // pictureOrganaizer
            // 
            this.pictureOrganaizer.Location = new System.Drawing.Point(444, 158);
            this.pictureOrganaizer.Name = "pictureOrganaizer";
            this.pictureOrganaizer.Size = new System.Drawing.Size(336, 254);
            this.pictureOrganaizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOrganaizer.TabIndex = 97;
            this.pictureOrganaizer.TabStop = false;
            this.pictureOrganaizer.Click += new System.EventHandler(this.pictureOrganaizer_Click);
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.e.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e.ForeColor = System.Drawing.Color.Black;
            this.e.Location = new System.Drawing.Point(137, 372);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(250, 30);
            this.e.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(61, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 95;
            this.label5.Text = "E-mail:";
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.c.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.c.FormattingEnabled = true;
            this.c.Location = new System.Drawing.Point(137, 447);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(250, 31);
            this.c.TabIndex = 94;
            // 
            // bd
            // 
            this.bd.AutoSize = true;
            this.bd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.bd.Location = new System.Drawing.Point(44, 338);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(83, 23);
            this.bd.TabIndex = 93;
            this.bd.Text = "Birth day";
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.g.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.g.FormattingEnabled = true;
            this.g.Location = new System.Drawing.Point(137, 298);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(250, 31);
            this.g.TabIndex = 92;
            this.g.SelectedIndexChanged += new System.EventHandler(this.g_SelectedIndexChanged);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p.ForeColor = System.Drawing.Color.Black;
            this.p.Location = new System.Drawing.Point(137, 262);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(250, 30);
            this.p.TabIndex = 91;
            // 
            // fn
            // 
            this.fn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fn.ForeColor = System.Drawing.Color.Black;
            this.fn.Location = new System.Drawing.Point(137, 226);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(250, 30);
            this.fn.TabIndex = 90;
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ln.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ln.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ln.ForeColor = System.Drawing.Color.Black;
            this.ln.Location = new System.Drawing.Point(137, 190);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(250, 30);
            this.ln.TabIndex = 89;
            // 
            // idNumber
            // 
            this.idNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.idNumber.Location = new System.Drawing.Point(133, 158);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(291, 23);
            this.idNumber.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 87;
            this.label4.Text = "ID Number:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(190, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 51);
            this.label2.TabIndex = 86;
            this.label2.Text = "Participant Registration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(27, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "Patronymic:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(31, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "Last name:";
            // 
            // gender1
            // 
            this.gender1.AutoSize = true;
            this.gender1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.gender1.Location = new System.Drawing.Point(56, 301);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(71, 23);
            this.gender1.TabIndex = 83;
            this.gender1.Text = "Gender:";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.fio.Location = new System.Drawing.Point(27, 228);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(100, 23);
            this.fio.TabIndex = 82;
            this.fio.Text = "First name:";
            // 
            // birthday
            // 
            this.birthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.birthday.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.birthday.Location = new System.Drawing.Point(137, 335);
            this.birthday.Mask = "00/00/0000";
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(250, 30);
            this.birthday.TabIndex = 112;
            this.birthday.ValidatingType = typeof(System.DateTime);
            // 
            // RegistrationParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.visiblePassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passwordRepeate);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pictureOrganaizer);
            this.Controls.Add(this.e);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.g);
            this.Controls.Add(this.p);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.fio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationParticipant";
            this.Text = "RegistrationParticipant";
            this.Load += new System.EventHandler(this.RegistrationParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrganaizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox visiblePassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordRepeate;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureOrganaizer;
        private System.Windows.Forms.TextBox e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox c;
        private System.Windows.Forms.Label bd;
        private System.Windows.Forms.ComboBox g;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.Label idNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gender1;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.MaskedTextBox birthday;
    }
}