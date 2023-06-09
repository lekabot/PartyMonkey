namespace PartyMonkey.Forms
{
    partial class EventWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.Beginning = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Event = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.City = new System.Windows.Forms.ComboBox();
            this.timeActivity1 = new System.Windows.Forms.ComboBox();
            this.timeActivity2 = new System.Windows.Forms.ComboBox();
            this.timeActivity3 = new System.Windows.Forms.ComboBox();
            this.juryAct1 = new System.Windows.Forms.ComboBox();
            this.juryAct2 = new System.Windows.Forms.ComboBox();
            this.juryAct3 = new System.Windows.Forms.ComboBox();
            this.myProfileBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Board_button = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Ending = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Act1 = new System.Windows.Forms.ComboBox();
            this.Act2 = new System.Windows.Forms.ComboBox();
            this.Act3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(295, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 51);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add an event";
            // 
            // Beginning
            // 
            this.Beginning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Beginning.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Beginning.Location = new System.Drawing.Point(126, 129);
            this.Beginning.Mask = "00/00/0000";
            this.Beginning.Name = "Beginning";
            this.Beginning.Size = new System.Drawing.Size(100, 30);
            this.Beginning.TabIndex = 30;
            this.Beginning.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Beginning ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(10, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Event";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(10, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Direction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(10, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(10, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Activities";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label8.Location = new System.Drawing.Point(222, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(437, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 29);
            this.label9.TabIndex = 45;
            this.label9.Text = "Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(641, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 29);
            this.label10.TabIndex = 46;
            this.label10.Text = "Jury";
            // 
            // Event
            // 
            this.Event.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Event.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Event.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Event.FormattingEnabled = true;
            this.Event.Location = new System.Drawing.Point(126, 201);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(262, 31);
            this.Event.TabIndex = 47;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(262, 31);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.Text = "This is not exist";
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.City.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(126, 274);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(262, 31);
            this.City.TabIndex = 49;
            // 
            // timeActivity1
            // 
            this.timeActivity1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeActivity1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.timeActivity1.FormattingEnabled = true;
            this.timeActivity1.Location = new System.Drawing.Point(397, 344);
            this.timeActivity1.Name = "timeActivity1";
            this.timeActivity1.Size = new System.Drawing.Size(145, 31);
            this.timeActivity1.TabIndex = 50;
            // 
            // timeActivity2
            // 
            this.timeActivity2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeActivity2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.timeActivity2.FormattingEnabled = true;
            this.timeActivity2.Location = new System.Drawing.Point(397, 381);
            this.timeActivity2.Name = "timeActivity2";
            this.timeActivity2.Size = new System.Drawing.Size(145, 31);
            this.timeActivity2.TabIndex = 51;
            // 
            // timeActivity3
            // 
            this.timeActivity3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.timeActivity3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.timeActivity3.FormattingEnabled = true;
            this.timeActivity3.Location = new System.Drawing.Point(397, 418);
            this.timeActivity3.Name = "timeActivity3";
            this.timeActivity3.Size = new System.Drawing.Size(145, 31);
            this.timeActivity3.TabIndex = 52;
            // 
            // juryAct1
            // 
            this.juryAct1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.juryAct1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.juryAct1.FormattingEnabled = true;
            this.juryAct1.Location = new System.Drawing.Point(565, 345);
            this.juryAct1.Name = "juryAct1";
            this.juryAct1.Size = new System.Drawing.Size(220, 31);
            this.juryAct1.TabIndex = 53;
            // 
            // juryAct2
            // 
            this.juryAct2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.juryAct2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.juryAct2.FormattingEnabled = true;
            this.juryAct2.Location = new System.Drawing.Point(565, 382);
            this.juryAct2.Name = "juryAct2";
            this.juryAct2.Size = new System.Drawing.Size(220, 31);
            this.juryAct2.TabIndex = 54;
            // 
            // juryAct3
            // 
            this.juryAct3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.juryAct3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.juryAct3.FormattingEnabled = true;
            this.juryAct3.Location = new System.Drawing.Point(565, 419);
            this.juryAct3.Name = "juryAct3";
            this.juryAct3.Size = new System.Drawing.Size(220, 31);
            this.juryAct3.TabIndex = 55;
            // 
            // myProfileBT
            // 
            this.myProfileBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.myProfileBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileBT.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myProfileBT.ForeColor = System.Drawing.Color.White;
            this.myProfileBT.Location = new System.Drawing.Point(107, 456);
            this.myProfileBT.Name = "myProfileBT";
            this.myProfileBT.Size = new System.Drawing.Size(40, 40);
            this.myProfileBT.TabIndex = 56;
            this.myProfileBT.Text = "+";
            this.myProfileBT.UseVisualStyleBackColor = false;
            this.myProfileBT.Click += new System.EventHandler(this.myProfileBT_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(476, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 57;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(670, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 40);
            this.button2.TabIndex = 58;
            this.button2.Text = "csv";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Board_button
            // 
            this.Board_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Board_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Board_button.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Board_button.ForeColor = System.Drawing.Color.White;
            this.Board_button.Location = new System.Drawing.Point(670, 203);
            this.Board_button.Name = "Board_button";
            this.Board_button.Size = new System.Drawing.Size(115, 40);
            this.Board_button.TabIndex = 59;
            this.Board_button.Text = "Board";
            this.Board_button.UseVisualStyleBackColor = false;
            this.Board_button.Click += new System.EventHandler(this.Board_button_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maskedTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.Location = new System.Drawing.Point(597, 110);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(188, 30);
            this.maskedTextBox1.TabIndex = 60;
            // 
            // Ending
            // 
            this.Ending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Ending.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Ending.Location = new System.Drawing.Point(126, 165);
            this.Ending.Mask = "00/00/0000";
            this.Ending.Name = "Ending";
            this.Ending.Size = new System.Drawing.Size(100, 30);
            this.Ending.TabIndex = 32;
            this.Ending.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(10, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ending";
            // 
            // Act1
            // 
            this.Act1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Act1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Act1.FormattingEnabled = true;
            this.Act1.Location = new System.Drawing.Point(133, 344);
            this.Act1.Name = "Act1";
            this.Act1.Size = new System.Drawing.Size(247, 31);
            this.Act1.TabIndex = 61;
            // 
            // Act2
            // 
            this.Act2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Act2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Act2.FormattingEnabled = true;
            this.Act2.Location = new System.Drawing.Point(133, 382);
            this.Act2.Name = "Act2";
            this.Act2.Size = new System.Drawing.Size(247, 31);
            this.Act2.TabIndex = 62;
            // 
            // Act3
            // 
            this.Act3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Act3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Act3.FormattingEnabled = true;
            this.Act3.Location = new System.Drawing.Point(133, 419);
            this.Act3.Name = "Act3";
            this.Act3.Size = new System.Drawing.Size(247, 31);
            this.Act3.TabIndex = 63;
            // 
            // EventWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.Act3);
            this.Controls.Add(this.Act2);
            this.Controls.Add(this.Act1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Board_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myProfileBT);
            this.Controls.Add(this.juryAct3);
            this.Controls.Add(this.juryAct2);
            this.Controls.Add(this.juryAct1);
            this.Controls.Add(this.timeActivity3);
            this.Controls.Add(this.timeActivity2);
            this.Controls.Add(this.timeActivity1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Beginning);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventWindow";
            this.Text = "Add an event";
            this.Load += new System.EventHandler(this.createEventWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Beginning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Event;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.ComboBox timeActivity1;
        private System.Windows.Forms.ComboBox timeActivity2;
        private System.Windows.Forms.ComboBox timeActivity3;
        private System.Windows.Forms.ComboBox juryAct1;
        private System.Windows.Forms.ComboBox juryAct2;
        private System.Windows.Forms.ComboBox juryAct3;
        private System.Windows.Forms.Button myProfileBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Board_button;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox Ending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Act1;
        private System.Windows.Forms.ComboBox Act2;
        private System.Windows.Forms.ComboBox Act3;
    }
}