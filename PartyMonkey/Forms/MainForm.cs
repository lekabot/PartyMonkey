﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;
using System.IO;

namespace PartyMonkey.Forms
{
    public partial class MainForm : Form
    {
        DataBase database = new DataBase();
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Image image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "logo.png"));
            logoPictureBox.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginAs loginAs = new LoginAs();
            loginAs.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
