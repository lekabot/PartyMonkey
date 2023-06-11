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
using PartyMonkey.Classes;

namespace PartyMonkey.Forms
{
    public partial class Moderator_RegistrationJury : Form, IBackForm
    {
        private DBFunctions functions;
        private DataBase database;
        public string Gender { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public Moderator_RegistrationJury()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Moderator_RegistrationJury_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            passwordRepeate.PasswordChar = '*';
            pictureOrganaizer.Image = Image.FromFile("D://AAProjects//C#//PartyMonkey//PartyMonkey//PartyMonkey//Resources//DefIconModerJury.png");
            GetGendersForComboBox();
            GetRolesForComboBox();
            BackForm();
            GenerateIdNumber();
        }

        private void GenerateIdNumber()
        {
            Random random = new Random();
            idNumber.Text = random.Next(10000000, 99999999).ToString();
        }

        private void CheckAllFields()
        {
            List<string> fields = new List<string>
            {
                ln.Text, fn.Text, p.Text, g.Text, r.Text, e.Text, password.Text, passwordRepeate.Text
            };
            if (!CheckIsFieldIsNotOrWhiteSpace(fields))
            {
                MessageBox.Show("Some of the fields were empty");
            }
            else
            {
                AddEventForModeratorJuty();
            }
        }

        private void GetGendersForComboBox()
        {
            List<string> genders = new List<string>() { "Male", "Female", "Other" };
            g.DataSource = genders;
            g.DisplayMember = "Role";
        }

        private void GetRolesForComboBox()
        {
            List<string> roles = new List<string>() { "Moderators", "Jury" };
            r.DataSource = roles;
            r.DisplayMember = "Role";
        }

        private void AddEventForModeratorJuty()
        {
            database = new DataBase();
            if (checkBox1.Checked)
            {
                //var event_id = functions.GetEventID(eventList.SelectedItem.ToString());
            }
            else
            {
                try
                {
                    if (CheckPasswordIsCorrect())
                    {
                        string query = $"INSERT INTO {r.Text} ([last name], [first name], [patronymic], [gender], [e-mail], [password]) " +
                                       "VALUES (@lastName, @firstName, @patronymic, @gender, @email, @password)";

                        database.openConnection();
                        SqlCommand command = new SqlCommand(query, DataBase.sqlConnection);
                        command.Parameters.AddWithValue("@lastName", ln.Text);
                        command.Parameters.AddWithValue("@firstName", fn.Text);
                        command.Parameters.AddWithValue("@patronymic", p.Text);
                        command.Parameters.AddWithValue("@gender", g.Text);
                        command.Parameters.AddWithValue("@email", e.Text);
                        command.Parameters.AddWithValue("@password", Password);
                        command.ExecuteNonQuery();
                        database.closeConnection();
                        MessageBox.Show("Profile has been added");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private Boolean CheckIsFieldIsNotOrWhiteSpace(List<string> field)
        {
            foreach (string s in field)
            {
                if (string.IsNullOrWhiteSpace(s))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAllFields();
        }

        private void visiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (visiblePassword.Checked)
            {
                password.PasswordChar = '\0';
                passwordRepeate.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
                passwordRepeate.PasswordChar = '*';
            }
        }

        private void g_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = g.SelectedItem;
            if (selectedItem != null)
            {
                string selectedText = selectedItem.ToString();
                Gender = selectedText;
            }
        }

        private void r_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = r.SelectedItem;
            if (selectedItem != null)
            {
                string selectedText = selectedItem.ToString();
                Role = selectedText;
            }
        }

        private Boolean CheckPasswordIsCorrect()
        {
            if (password.Text == passwordRepeate.Text)
            {
                Password = password.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Password is not correct");
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                functions = new DBFunctions();
                DataTable eventsTitles = functions.sqlSelect("SELECT title FROM [Events]");
                eventList.DataSource = eventsTitles;
                eventList.DisplayMember = "Title";
            }
            else
            {
                eventList.DataSource = null;
                eventList.Items.Clear();
            }
        }

        private void pictureOrganaizer_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureOrganaizer.Image = Image.FromFile(selectedImagePath);
            }

        }









        public void BackForm()
        {
            Button BackToModeratorWin = new Button();
            BackToModeratorWin = Buttons.createButtonBack();
            BackToModeratorWin.Click += new System.EventHandler(this.BackEvent);
            BackToModeratorWin.BringToFront();
            this.Controls.Add(BackToModeratorWin);

            Button LogOut = new Button();
            LogOut = Buttons.CreateButtonLogOut();
            LogOut.Click += new System.EventHandler(this.LogOutEvent);
            LogOut.BringToFront();
            this.Controls.Add(LogOut);
        }

        private void BackEvent(object sender, EventArgs e)
        {
            InformationAboutJutyModerator organizerWindow = new InformationAboutJutyModerator();
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
