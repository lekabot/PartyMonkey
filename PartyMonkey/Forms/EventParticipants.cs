using PartyMonkey.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PartyMonkey.Forms
{
    public partial class EventParticipants : Form
    {
        private DBFunctions functions;
        private string LastName;
        private string EventTitle;
        private int EventID;

        public EventParticipants()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            functions = new DBFunctions();
        }

        private void EventParticipants_Load(object sender, EventArgs e)
        {
            BackForm();
            SetDataForDGV();
            SetLastNamesToComboBox();
            SetEventsTitlesToComboBox();
        }

        private void LastNameSearch()
        {
            var findUsersLastName = functions.sqlSelect($"SELECT [photo], [last name], [first name], [patronymic], [e-mail], [phone] FROM Users WHERE [last name] = '{LastName}'");
            try
            {
                infoGrid.DataSource = findUsersLastName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
            }
            quantity.Text = (infoGrid.RowCount - 1).ToString();
        }

        private void EventSearch()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("photo", typeof(Image));
            dataTable.Columns.Add("last name", typeof(string));
            dataTable.Columns.Add("first name", typeof(string));
            dataTable.Columns.Add("patronymic", typeof(string));
            dataTable.Columns.Add("e-mail", typeof(string));
            dataTable.Columns.Add("phone", typeof(string));

            EventTitle = eventList.Text;
            EventID = functions.GetEventID(EventTitle);

            var findUsersEvent = functions.sqlSelect($"SELECT [photo], [last name], [first name], [patronymic], [e-mail], [phone] FROM Users JOIN [Activity log] ON Users.id = [Activity log].user_id WHERE event_id = {EventID}");

            try
            {
                if (findUsersEvent != null && findUsersEvent.Rows.Count > 0)
                {
                    foreach (DataRow row in findUsersEvent.Rows)
                    {
                        Image photo = GetImageFromRow(row);
                        string lastName = row["last name"].ToString();
                        string firstName = row["first name"].ToString();
                        string patronymic = row["patronymic"].ToString();
                        string email = row["e-mail"].ToString();
                        string phone = row["phone"].ToString();
                        dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, phone);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
            }

            infoGrid.DataSource = dataTable;
            quantity.Text = (infoGrid.RowCount - 1).ToString();
        }

        private void SetEventsTitlesToComboBox()
        {
            DataTable eventsTitles = functions.sqlSelect("SELECT title FROM [Events]");
            eventList.DataSource = eventsTitles;
            eventList.DisplayMember = "Title";
        }

        private void SetLastNamesToComboBox()
        {
            DataTable juryData = functions.sqlSelect("SELECT [last name] FROM Users");
            lastName.DataSource = juryData;
            lastName.DisplayMember = "Last name";
        }

        private void SetDataForDGV()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("photo", typeof(Image));
            dataTable.Columns.Add("last name", typeof(string));
            dataTable.Columns.Add("first name", typeof(string));
            dataTable.Columns.Add("patronymic", typeof(string));
            dataTable.Columns.Add("e-mail", typeof(string));
            dataTable.Columns.Add("phone", typeof(string));

            DataTable UserData = functions.sqlSelect("SELECT [photo], [last name], [first name], [patronymic], [e-mail], [phone] FROM [dbo].[Users]");
            foreach (DataRow row in UserData.Rows)
            {
                Image photo = GetImageFromRow(row);
                string lastName = row["last name"].ToString();
                string firstName = row["first name"].ToString();
                string patronymic = row["patronymic"].ToString();
                string email = row["e-mail"].ToString();
                string phone = row["phone"].ToString();
                if (!string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(patronymic) && !string.IsNullOrWhiteSpace(email))
                {
                    dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, phone);
                }
            }
            infoGrid.DataSource = dataTable;
            quantity.Text = (infoGrid.RowCount - 1).ToString();
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Bitmap bitmap = new Bitmap(memoryStream);
                Image image = (Image)bitmap;
                return image;
            }
        }

        private Image GetImageFromRow(DataRow row)
        {
            if (row["photo"] != DBNull.Value)
            {
                byte[] photoData = (byte[])row["photo"];
                return ByteArrayToImage(photoData);
            }
            return null;
        }

        public void BackForm()
        {
            Button backToModeratorWin = Buttons.CreateButtonBack();
            backToModeratorWin.Click += BackEvent;
            backToModeratorWin.BringToFront();
            this.Controls.Add(backToModeratorWin);

            Button logOut = Buttons.CreateButtonLogOut();
            logOut.Click += LogOutEvent;
            logOut.BringToFront();
            this.Controls.Add(logOut);
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

        private void SearchbyLastName_Click(object sender, EventArgs e)
        {
            LastNameSearch();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            EventSearch();
        }

        private void Board_button_Click(object sender, EventArgs e)
        {
            RegistrationParticipant registrationParticipant = new RegistrationParticipant();
            registrationParticipant.Show();
            this.Hide();
        }

        private void lastName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastName = lastName.Text;
        }
    }
}
