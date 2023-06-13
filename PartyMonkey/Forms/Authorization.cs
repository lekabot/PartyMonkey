using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PartyMonkey.Forms;
using PartyMonkey.Classes;

namespace PartyMonkey.Forms
{
    public partial class Authorization : Form, IBackForm
    {
        DataBank dataBank = new DataBank();
        DBFunctions functions = new DBFunctions();
        private int loginAttempts;

        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_in_Load(object sender, EventArgs e)
        {

            PasswordTextBox.PasswordChar = '*';
            EmailTextBox.MaxLength = 150;
            EmailTextBox.MaxLength = 150;
            BackForm();
        }

        public void BackForm()
        {
            Button LogOut = new Button();
            LogOut = Buttons.CreateButtonBack();
            LogOut.Click += new System.EventHandler(this.LogOutEvent);
            LogOut.BringToFront();
            this.Controls.Add(LogOut);
        }

        private void LogOutEvent(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void signin_Click_1(object sender, EventArgs e)
        {
            
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("You have not entered the login of password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (functions.sqlSelect($"select [e-mail], [password] from [{DataBank.tableName}] where [e-mail] = '{email}' AND [password] = '{password}'").Rows.Count > 0)
                {
                    DataBank.userEmail = email;
                    MessageBox.Show("You have successfully logged in!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DataBank.tableName == "Moderators")
                    {
                        DataTable dataTable= new DataTable();
                        dataTable = functions.sqlSelect($"SELECT id FROM [dbo].[Moderators] WHERE [e-mail] = '{email}'");
                        DataBank.userID = Convert.ToInt32(dataTable.Rows[0][0]);
                        ModeratorWindow moderatorForm = new ModeratorWindow();
                        this.Hide();
                        moderatorForm.Show();
                    }
                    if (DataBank.tableName == "Organizers")
                    {
                        DataTable dataTable = new DataTable();
                        dataTable = functions.sqlSelect($"SELECT id FROM [dbo].[Organizers] WHERE [e-mail] = '{email}'");
                        DataBank.userID = Convert.ToInt32(dataTable.Rows[0][0]);
                        OrganizerWindow organizerFrom = new OrganizerWindow();
                        this.Hide();
                        organizerFrom.Show();
                    }
                }
                else
                {
                    MessageBox.Show("There is no such account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    loginAttempts++;

                    if (loginAttempts == 3)
                    {
                        Capcha capcha = new Capcha();
                        capcha.Show();
                        this.Hide();
                        signin.Enabled = false;
                        Timer timer = new Timer();
                        timer.Interval = 250000;
                        timer.Tick += new EventHandler(timer_Tick);
                        timer.Start();

                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            signin.Enabled = true;
            Timer timer = (Timer)sender;
            timer.Stop();
            timer.Dispose();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            LoginAs loginAs = new LoginAs();
            loginAs.Show();
            this.Hide();
        }
    }
}
