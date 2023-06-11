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
    public partial class InformationAboutJutyModerator : Form, IBackForm
    {
        private DBFunctions functions { get; set; }
        private string LastName { get; set; }
        private string EventTitle { get; set; }
        private int EventID { get; set; }

        public InformationAboutJutyModerator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void InformationAboutJutyModerator_Load(object sender, EventArgs e)
        {
            BackForm();
            SetDataForDGV();
            SetLastNamesToComboBox();
            SetEventsTitlesToComboBox();
        }

        private void LastNameSearch()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("photo", typeof(Image));
            dataTable.Columns.Add("last name", typeof(string));
            dataTable.Columns.Add("first name", typeof(string));
            dataTable.Columns.Add("patronymic", typeof(string));
            dataTable.Columns.Add("e-mail", typeof(string));
            dataTable.Columns.Add("role", typeof(string));

            LastName = lastName.Text;
            
            var findJuryLastName = functions.sqlSelect($"SELECT [photo], [last name], [first name], [patronymic], [e-mail] FROM Jury WHERE [last name] = '{LastName}'");
            var findModerLastName = functions.sqlSelect($"SELECT [photo], [last name], [first name], [patronymic], [e-mail] FROM Moderators WHERE [last name] = '{LastName}'");
            if (findJuryLastName != null && findJuryLastName.Rows.Count > 0)
            {
                try
                {
                    

                    foreach (DataRow row in findJuryLastName.Rows)
                    {
                        Image photo = null;
                        if (row["photo"] != DBNull.Value)
                        {
                            photo = ByteArrayToImage((byte[])row["photo"]);
                        }
                        string lastName = row["last name"].ToString();
                        string firstName = row["first name"].ToString();
                        string patronymic = row["patronymic"].ToString();
                        string email = row["e-mail"].ToString();
                        if (!string.IsNullOrWhiteSpace(lastName))
                        {
                            dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, "Jury");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
                }
            }
            if (findModerLastName != null && findModerLastName.Rows.Count > 0)
            {
                try
                {
                    foreach (DataRow row in findModerLastName.Rows)
                    {
                        Image photo = null;
                        if (row["photo"] != DBNull.Value)
                        {
                            photo = ByteArrayToImage((byte[])row["photo"]);
                        }
                        string lastName = row["last name"].ToString();
                        string firstName = row["first name"].ToString();
                        string patronymic = row["patronymic"].ToString();
                        string email = row["e-mail"].ToString();
                        if (!string.IsNullOrWhiteSpace(lastName))
                        {
                            dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, "Jury");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
                }
            }
            infoGrid.DataSource = dataTable;
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
            dataTable.Columns.Add("role", typeof(string));

            functions = new DBFunctions();

            var event_id = functions.GetEventID(eventList.Text);
            var findJuryEvent = functions.sqlSelect($"SELECT [photo], [last name], [first name], [patronymic], [e-mail] FROM Moderators " +
                $"JOIN [Activity log] ON Moderators.id = [Activity log].moderator_id WHERE event_id = {event_id}");
            var findmoderatorEvent = functions.sqlSelect($"SELECT [photo], [last name], [first name], [patronymic], [e-mail] FROM Jury " +
                $"JOIN [Activity log] ON Jury.id = [Activity log].jury_id WHERE event_id = {event_id}");

            if (findJuryEvent != null && findJuryEvent.Rows.Count > 0)
            {
                try
                {
                    

                    foreach (DataRow row in findJuryEvent.Rows)
                    {
                        Image photo = ByteArrayToImage((byte[])row["photo"]);
                        string lastName = row["last name"].ToString();
                        string firstName = row["first name"].ToString();
                        string patronymic = row["patronymic"].ToString();
                        string email = row["e-mail"].ToString();

                        // Добавление строки с данными и ролью "Жури"
                        dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, "Jury");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
                }
            }
            if (findmoderatorEvent != null && findmoderatorEvent.Rows.Count > 0)
            {
                try
                {
                    foreach (DataRow row in findmoderatorEvent.Rows)
                    {
                        Image photo = ByteArrayToImage((byte[])row["photo"]);
                        string lastName = row["last name"].ToString();
                        string firstName = row["first name"].ToString();
                        string patronymic = row["patronymic"].ToString();
                        string email = row["e-mail"].ToString();
                        dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, "Moderator");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
                }
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
            DataTable juryData = functions.sqlSelect("SELECT [last name] FROM Jury UNION SELECT [last name] FROM Moderators\r\n");
            lastName.DataSource = juryData;
            lastName.DisplayMember = "Last name";
        }

        private void SetDataForDGV()
        {
            functions = new DBFunctions();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("photo", typeof(Image));
            dataTable.Columns.Add("last name", typeof(string));
            dataTable.Columns.Add("first name", typeof(string));
            dataTable.Columns.Add("patronymic", typeof(string));
            dataTable.Columns.Add("e-mail", typeof(string));
            dataTable.Columns.Add("role", typeof(string));

            DataTable juryData = functions.sqlSelect("SELECT [photo], [last name], [first name], [patronymic], [e-mail] FROM Jury");
            foreach (DataRow row in juryData.Rows)
            {
                Image photo = null;
                if (row["photo"] != DBNull.Value)
                {
                    photo = ByteArrayToImage((byte[])row["photo"]);
                }
                string lastName = row["last name"].ToString();
                string firstName = row["first name"].ToString();
                string patronymic = row["patronymic"].ToString();
                string email = row["e-mail"].ToString();
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, "Jury");
                }
            }

            DataTable moderData = functions.sqlSelect("SELECT [photo], [last name], [first name], [patronymic], [e-mail] FROM Moderators");
            foreach (DataRow row in moderData.Rows)
            {
                Image photo = null;
                if (row["photo"] != DBNull.Value)
                {
                    photo = ByteArrayToImage((byte[])row["photo"]);
                }
                string lastName = row["last name"].ToString();
                string firstName = row["first name"].ToString();
                string patronymic = row["patronymic"].ToString();
                string email = row["e-mail"].ToString();
                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    dataTable.Rows.Add(photo, lastName, firstName, patronymic, email, "Moderator");
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

        private void Search_Click(object sender, EventArgs e)
        {
            EventSearch();
        }

        private void SearchbyLastName_Click(object sender, EventArgs e)
        {
            LastNameSearch();
        }

        private void Board_button_Click(object sender, EventArgs e)
        {
            Moderator_RegistrationJury moderator_RegistrationJury = new Moderator_RegistrationJury();
            moderator_RegistrationJury.Show();
            this.Hide();
        }
    }
}
