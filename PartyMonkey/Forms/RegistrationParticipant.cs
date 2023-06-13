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

namespace PartyMonkey.Forms
{
    public partial class RegistrationParticipant : Form, IBackForm
    {
        public DBFunctions functions { get; private set; }
        public string PathToDeafaulPhoto { get; private set; } = Path.Combine(Application.StartupPath, "Resources", "DefIconUser.jpg");
        public string PathToSelectedPhoto { get; private set; }

        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Patronymic { get; private set; }
        public string Gender { get; private set; }
        public string BirthDay { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Country { get; private set; }
        public string Password { get; private set; }

        public RegistrationParticipant()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            passwordRepeate.PasswordChar = '*';
            functions = new DBFunctions();
            pictureOrganaizer.Image = Image.FromFile(PathToDeafaulPhoto);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationParticipant_Load(object sender, EventArgs e)
        {

            BackForm();
            GenerateIdNumber();
            GetGendersForComboBox();
            SetListCoutriesInComboBox();
        }

        public bool IsValidDate(string dateString)
        {
            try
            {
                DateTime date = DateTime.Parse(dateString);

                if (date.Year >= 1900)
                {
                    BirthDay = date.ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public int GetCountryID(string CityName)
        {
            var id = Convert.ToInt32(functions.sqlSelect($"SELECT id FROM [Countries] WHERE [country title] = '{CityName}'").Rows[0][0]);
            return id;
        }

        public DataTable GetAllCountriesFromDB()
        {
            DataTable ListСountries = functions.sqlSelect("SELECT [country title] FROM [Countries]");
            return ListСountries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAllFields();
            if (IsValidDate(BirthDay))
            {
                if (CheckPasswordIsCorrect())
                {
                    AddUserInDataBase();
                }
                else
                {
                    MessageBox.Show("Password is not correct");
                }
            }
            else
            {
                MessageBox.Show("Invalid Birthday or date older than 1900.");
            }
            
        }

        private void AddUserInDataBase()
        {
            int IdAddedRecord;
            try
            {
                if (CheckPasswordIsCorrect() && functions.CheckAccauntInExistDB(Email))
                {
                    string query = $"INSERT INTO Users ([last name], [first name], [patronymic], [e-mail], [birthday], [country_id], [phone], [password], [gender]) " +
                                   "VALUES (@lastName, @firstName, @patronymic, @email, @birthday, @country_id, @phone, @password, @gender) SELECT SCOPE_IDENTITY()";
                    using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@lastName", LastName);
                            command.Parameters.AddWithValue("@firstName", FirstName);
                            command.Parameters.AddWithValue("@patronymic", Patronymic);
                            command.Parameters.AddWithValue("@email", Email);
                            command.Parameters.AddWithValue("@birthday", BirthDay);
                            command.Parameters.AddWithValue("@country_id", GetCountryID(Country));
                            command.Parameters.AddWithValue("@phone", PhoneNumber);
                            command.Parameters.AddWithValue("@password", Password);
                            command.Parameters.AddWithValue("@gender", Gender);
                            
                            IdAddedRecord = Convert.ToInt32(command.ExecuteScalar());
                            connection.Close();
                        }
                    }

                    if (PathToSelectedPhoto != PathToDeafaulPhoto && PathToSelectedPhoto != null)
                    {
                        functions.sqlInsert($"UPDATE Users SET photo = (SELECT BulkColumn FROM OPENROWSET(BULK '{PathToSelectedPhoto}', SINGLE_BLOB) AS x) WHERE id = {IdAddedRecord};");
                    }
                    MessageBox.Show("Profile has been added");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean CheckPasswordIsCorrect()
        {
            if (password.Text == passwordRepeate.Text)
            {
                Password = password.Text;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetListCoutriesInComboBox()
        {
            c.DataSource = GetAllCountriesFromDB();
            c.DisplayMember = "country title";
        }

        private void GetGendersForComboBox()
        {
            List<string> genders = new List<string>() { "Male", "Female", "Other" };
            g.DataSource = genders;
            g.DisplayMember = "Role";
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
                ln.Text, fn.Text, p.Text, g.Text, birthday.Text, e.Text, password.Text, passwordRepeate.Text, phone.Text, c.Text
            };
            if (!CheckIsFieldIsNotOrWhiteSpace(fields))
            {
                MessageBox.Show("Some of the fields were empty");
            }
            else
            {
                LastName = ln.Text;
                FirstName = fn.Text;
                Patronymic = p.Text;
                Gender = g.Text;
                BirthDay = birthday.Text;
                Email = e.Text;
                PhoneNumber = p.Text;
                Country = c.Text;

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

        public void BackForm()
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

        private void BackEvent(object sender, EventArgs e)
        {
            EventParticipants organizerWindow = new EventParticipants();
            organizerWindow.Show();
            this.Hide();
        }

        private void LogOutEvent(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
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

        private void pictureOrganaizer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                PathToSelectedPhoto = selectedImagePath;
                pictureOrganaizer.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
