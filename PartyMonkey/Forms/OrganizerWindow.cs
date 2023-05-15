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
    public partial class OrganizerWindow : Form
    {
        DBFunctions functions = new DBFunctions();

        public OrganizerWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void OrganizerWindow_Load(object sender, EventArgs e)
        {
            checkTimeForLabel();
            getGender();
            getAndSetPhoto();
        }

        private void getGender()
        {
            DataTable getGender = new DataTable();
            getGender = functions.sqlSelect($"SELECT gender, [first name] FROM [dbo].[Organizers] WHERE [e-mail] = '{DataBank.userEmail}'");
            string moderatorGender = getGender.Rows[0][0].ToString();
            if (moderatorGender[0] == 'ж')
            {
                nameTextBox.Text = $"Ms. {getGender.Rows[0][1]}";
            }
            else
            {
                nameTextBox.Text = $"Mr. {getGender.Rows[0][1]}";
            }
        }

        private void checkTimeForLabel()
        {
            System.DateTime currentTime = System.DateTime.Now;
            string text = "";

            if (currentTime.TimeOfDay >= new TimeSpan(9, 0, 0) && currentTime.TimeOfDay < new TimeSpan(11, 0, 0))
            {
                text = "Good morning";
            }
            else if (currentTime.TimeOfDay >= new TimeSpan(11, 1, 0) && currentTime.TimeOfDay < new TimeSpan(18, 0, 0))
            {
                text = "Good afternoon";
            }
            else if (currentTime.TimeOfDay >= new TimeSpan(18, 1, 0) && currentTime.TimeOfDay <= new TimeSpan(23, 59, 59))
            {
                text = "Good evening";
            }
            else
            {
                text = "Good night";
            }

            timeTextBox.Text = text;
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

        private void myProfileBT_Click(object sender, EventArgs e)
        {
            OrganaizerProfile organaizerProfileForm = new OrganaizerProfile();
            organaizerProfileForm.Show();
            this.Hide();
        }

        private void eventVT_Click(object sender, EventArgs e)
        {
            CreateEventWindow createEventWindow = new CreateEventWindow();
            this.Hide();
            createEventWindow.Show();
        }
    }
}
