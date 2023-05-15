namespace PartyMonkey.Forms
{
    partial class ModeratorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeratorWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.Label();
            this.EnterCapcha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathToActivity = new System.Windows.Forms.ComboBox();
            this.eventList = new System.Windows.Forms.ComboBox();
            this.activityGrid = new System.Windows.Forms.DataGridView();
            this.сheckButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Moderator\'s window";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.timeTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.timeTextBox.Location = new System.Drawing.Point(216, 60);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(371, 30);
            this.timeTextBox.TabIndex = 26;
            this.timeTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.nameTextBox.Location = new System.Drawing.Point(216, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(371, 30);
            this.nameTextBox.TabIndex = 27;
            this.nameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterCapcha
            // 
            this.EnterCapcha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterCapcha.AutoSize = true;
            this.EnterCapcha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterCapcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.EnterCapcha.Location = new System.Drawing.Point(12, 133);
            this.EnterCapcha.Name = "EnterCapcha";
            this.EnterCapcha.Size = new System.Drawing.Size(105, 30);
            this.EnterCapcha.TabIndex = 28;
            this.EnterCapcha.Text = "Direction";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(48, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Event";
            // 
            // pathToActivity
            // 
            this.pathToActivity.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.pathToActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.pathToActivity.FormattingEnabled = true;
            this.pathToActivity.Location = new System.Drawing.Point(123, 130);
            this.pathToActivity.Name = "pathToActivity";
            this.pathToActivity.Size = new System.Drawing.Size(558, 38);
            this.pathToActivity.TabIndex = 30;
            this.pathToActivity.SelectedIndexChanged += new System.EventHandler(this.pathToActivity_SelectedIndexChanged);
            // 
            // eventList
            // 
            this.eventList.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.eventList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(123, 183);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(558, 38);
            this.eventList.TabIndex = 31;
            this.eventList.SelectedIndexChanged += new System.EventHandler(this.eventList_SelectedIndexChanged);
            // 
            // activityGrid
            // 
            this.activityGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activityGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.activityGrid.Location = new System.Drawing.Point(7, 229);
            this.activityGrid.Name = "activityGrid";
            this.activityGrid.Size = new System.Drawing.Size(758, 164);
            this.activityGrid.TabIndex = 32;
            // 
            // сheckButton
            // 
            this.сheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.сheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.сheckButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сheckButton.ForeColor = System.Drawing.Color.White;
            this.сheckButton.Location = new System.Drawing.Point(524, 403);
            this.сheckButton.Name = "сheckButton";
            this.сheckButton.Size = new System.Drawing.Size(241, 35);
            this.сheckButton.TabIndex = 33;
            this.сheckButton.Text = "Submit an application";
            this.сheckButton.UseVisualStyleBackColor = false;
            this.сheckButton.Click += new System.EventHandler(this.сheckButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(663, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 34;
            this.button1.Text = "My events";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ModeratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.сheckButton);
            this.Controls.Add(this.activityGrid);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.pathToActivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterCapcha);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModeratorWindow";
            this.Text = "ModeratorWindow";
            this.Load += new System.EventHandler(this.ModeratorWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeTextBox;
        private System.Windows.Forms.Label nameTextBox;
        private System.Windows.Forms.Label EnterCapcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pathToActivity;
        private System.Windows.Forms.ComboBox eventList;
        private System.Windows.Forms.DataGridView activityGrid;
        private System.Windows.Forms.Button сheckButton;
        private System.Windows.Forms.Button button1;
    }
}