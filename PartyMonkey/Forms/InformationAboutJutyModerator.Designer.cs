namespace PartyMonkey.Forms
{
    partial class InformationAboutJutyModerator
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
            this.infoGrid = new System.Windows.Forms.DataGridView();
            this.eventList = new System.Windows.Forms.ComboBox();
            this.lastName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterCapcha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.SearchbyLastName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.Board_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // infoGrid
            // 
            this.infoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.infoGrid.Location = new System.Drawing.Point(18, 256);
            this.infoGrid.Name = "infoGrid";
            this.infoGrid.Size = new System.Drawing.Size(758, 205);
            this.infoGrid.TabIndex = 38;
            // 
            // eventList
            // 
            this.eventList.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.eventList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(142, 193);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(370, 38);
            this.eventList.TabIndex = 37;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.lastName.FormattingEnabled = true;
            this.lastName.Location = new System.Drawing.Point(142, 140);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(370, 38);
            this.lastName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(67, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Event";
            // 
            // EnterCapcha
            // 
            this.EnterCapcha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterCapcha.AutoSize = true;
            this.EnterCapcha.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterCapcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.EnterCapcha.Location = new System.Drawing.Point(13, 143);
            this.EnterCapcha.Name = "EnterCapcha";
            this.EnterCapcha.Size = new System.Drawing.Size(123, 30);
            this.EnterCapcha.TabIndex = 34;
            this.EnterCapcha.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(223, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 51);
            this.label1.TabIndex = 33;
            this.label1.Text = "Jury/Moderators";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(548, 193);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(242, 38);
            this.Search.TabIndex = 39;
            this.Search.Text = "Event Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchbyLastName
            // 
            this.SearchbyLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.SearchbyLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchbyLastName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchbyLastName.ForeColor = System.Drawing.Color.White;
            this.SearchbyLastName.Location = new System.Drawing.Point(548, 140);
            this.SearchbyLastName.Name = "SearchbyLastName";
            this.SearchbyLastName.Size = new System.Drawing.Size(242, 38);
            this.SearchbyLastName.TabIndex = 40;
            this.SearchbyLastName.Text = "Search by Last Name";
            this.SearchbyLastName.UseVisualStyleBackColor = false;
            this.SearchbyLastName.Click += new System.EventHandler(this.SearchbyLastName_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(13, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quantity:";
            // 
            // quantity
            // 
            this.quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.quantity.Location = new System.Drawing.Point(122, 467);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(0, 30);
            this.quantity.TabIndex = 42;
            // 
            // Board_button
            // 
            this.Board_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.Board_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Board_button.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Board_button.ForeColor = System.Drawing.Color.White;
            this.Board_button.Location = new System.Drawing.Point(310, 15);
            this.Board_button.Name = "Board_button";
            this.Board_button.Size = new System.Drawing.Size(184, 40);
            this.Board_button.TabIndex = 60;
            this.Board_button.Text = "Registration";
            this.Board_button.UseVisualStyleBackColor = false;
            this.Board_button.Click += new System.EventHandler(this.Board_button_Click);
            // 
            // InformationAboutJutyModerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.Board_button);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchbyLastName);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.infoGrid);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterCapcha);
            this.Controls.Add(this.label1);
            this.Name = "InformationAboutJutyModerator";
            this.Text = "InformationAboutJutyModerator";
            this.Load += new System.EventHandler(this.InformationAboutJutyModerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoGrid;
        private System.Windows.Forms.ComboBox eventList;
        private System.Windows.Forms.ComboBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label EnterCapcha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button SearchbyLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Button Board_button;
    }
}