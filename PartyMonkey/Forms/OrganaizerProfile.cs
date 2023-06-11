using PartyMonkey.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace PartyMonkey.Forms
{
    public partial class OrganaizerProfile : Form
    {
        DBFunctions functions = new DBFunctions();

        public OrganaizerProfile()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox10.PasswordChar = '*';
            textBox11.PasswordChar = '*';
        }

        private void OrganaizerProfile_Load(object sender, EventArgs e)
        {
            getAndSetPhoto();
            getOrganaizerAccauntData();
            GenerateIdNumber();
            createButton();
        }

        private void createButton()
        {
            Button BackToModeratorWin = new Button();
            BackToModeratorWin = Buttons.CreateButtonBack();
            BackToModeratorWin.Click += new System.EventHandler(this.BackEvent);
            BackToModeratorWin.BringToFront();
            this.Controls.Add(BackToModeratorWin);

            Button LogOut = new Button();
            LogOut = Buttons.CreateButtonLogOut();
            LogOut.Click += new System.EventHandler(this.LogOutEvent);
            LogOut.BringToFront();
            this.Controls.Add(LogOut);
        }

        private void getAndSetPhoto()
        {
            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT photo FROM Organizers WHERE id = {DataBank.userID}", connection);
                byte[] imageData = (byte[])command.ExecuteScalar();
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    pictureOrganaizer.Image = image;
                }
            }
        }

        private void GenerateIdNumber()
        {
            Random random = new Random();
            idNumber.Text = random.Next(10000000, 99999999).ToString();
        }

        private void getOrganaizerAccauntData()
        {
            DataTable allData = new DataTable();
            allData = functions.sqlSelect($"SELECT [Organizers].[last name], [Organizers].[first name], [Organizers].[patronymic], [Organizers].[gender], [Organizers].[birthday], [Countries].[english title], [Organizers].[phone], [Organizers].[e-mail] FROM [Organizers] JOIN [Countries] ON [Organizers].[country_id] = [Countries].[id] WHERE [Organizers].[id] = {DataBank.userID}");
            lastName.Text = allData.Rows[0][0].ToString();
            firstName.Text = allData.Rows[0][1].ToString();
            patronymic.Text = allData.Rows[0][2].ToString();
            gender.Text = allData.Rows[0][3].ToString();
            birtday.Text = allData.Rows[0][4].ToString();
            country.Text = allData.Rows[0][5].ToString();
            phone.Text = allData.Rows[0][6].ToString();
            email.Text = allData.Rows[0][7].ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (visiblePassword.Checked)
            {
                textBox10.PasswordChar = '\0';
                textBox11.PasswordChar = '\0';
            }
            else
            {
                textBox10.PasswordChar = '*';
                textBox11.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass1 = textBox10.Text;
            string pass2 = textBox11.Text;
            
            if (changePassword.Checked)
            {
                if(!string.IsNullOrWhiteSpace(pass1) || !string.IsNullOrWhiteSpace(pass2))
                {
                    if(pass1 == pass2)
                    {
                        functions.sqlInsert($"UPDATE [Organizers] SET [password] = {pass1} WHERE id = {DataBank.userID};");
                        MessageBox.Show("the password has been successfully changed");
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match");
                    }
                }
                else
                {
                    MessageBox.Show("You have not filled in the password change fields");
                }
            }
            else
            {
                MessageBox.Show("Your password has not been changed");
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            OrganizerWindow organizerWindow = new OrganizerWindow();
            this.Hide();
            organizerWindow.Show();
        }

        private void BackEvent(object sender, EventArgs e)
        {
            OrganizerWindow organizerWindow = new OrganizerWindow();
            organizerWindow.Show();
            this.Hide();
        }

        private void LogOutEvent(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
