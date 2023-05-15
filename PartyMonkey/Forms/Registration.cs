using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyMonkey.Forms
{
    public partial class Registration : Form
    {
        DBFunctions functions = new DBFunctions();
        DataBase database = new DataBase();
        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_first_name.MaxLength = 50;
            textBox_last_name.MaxLength = 50;
            textBox_email.MaxLength = 50;
            textBox_password.MaxLength = 50;
            textBox_address.MaxLength = 50;
            textBox_city.MaxLength = 50;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var first_name = textBox_first_name.Text;
            var last_name = textBox_last_name.Text;
            var email = textBox_email.Text;
            var phone_number = textBox_phone_number.Text;
            var username = textBox_username.Text;
            var password = textBox_password.Text;
            var address = textBox_address.Text;
            var city = textBox_city.Text;

            if (new[] { textBox_first_name.Text, textBox_last_name.Text, textBox_email.Text, textBox_phone_number.Text, textBox_username.Text, textBox_password.Text, textBox_address.Text, textBox_city.Text }
                    .All(x => string.IsNullOrWhiteSpace(x)))
            {
                MessageBox.Show("You didn't specify a field", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (functions.CheckAccauntInExistDB(username, email) == true)
                {
                    MessageBox.Show("Such E-mail or Username is already registered", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    database.openConnection();

                    string querystring = $"INSERT INTO customers (first_name, last_name, email, phone, username, [password], [address], city) VALUES ('{first_name}', '{last_name}', '{email}', '{phone_number}', '{username}', '{password}', '{address}', '{city}');";

                    SqlCommand command = new SqlCommand(querystring);
                    command.Connection = database.GetConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("You have created an account", "Account added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Information information = new Information();
                        //information.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something's wrong", "Account not created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    database.closeConnection();
                }
            }
        }
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authorization log = new Authorization();
            log.Show();
            this.Hide();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            form1.Show();
            this.Hide();
        }
    }
}
