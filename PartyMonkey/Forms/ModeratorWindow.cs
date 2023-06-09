using PartyMonkey.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PartyMonkey.Forms
{
    public partial class ModeratorWindow : Form
    {
        DBFunctions functions = new DBFunctions();
        int eventID { get; set; }
        string userRole = DataBank.tableName;

        public ModeratorWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void ModeratorWindow_Load(object sender, EventArgs e)
        {
            checkTimeForLabel();
            getListEventsForComBox();
            getActivitiesForComboBox();
            getGender();
            activityGrid.DataSource = functions.sqlSelect($"SELECT [Activities].id, [Activities].title, " +
                $"[Events].[date], [Activities].[time] FROM [Activities] JOIN [Activity log] ON [Activities].[id] = " +
                $"[Activity log].activity_id JOIN [Events] ON [Events].id = " +
                $"[Activity log].event_id  WHERE [Activity log].event_id = {eventID}");
            coloringRows();
        }

        private void coloringRows() 
        {
            DataTable gotActivitiesModerator = new DataTable();
            DataTable gotActivities = new DataTable();
            gotActivitiesModerator = functions.sqlSelect($"SELECT [activity_id] FROM [Activity log] WHERE [moderator_id] is not null");
            gotActivities = functions.sqlSelect($"SELECT [activity_id] FROM [Activity log] WHERE [moderator_id] = '{DataBank.userID}'");

            if (gotActivitiesModerator.Rows.Count > 0)
            {
                foreach (DataRow row in gotActivitiesModerator.Rows)
                {
                    int idActivity = Convert.ToInt32(row["activity_id"]);

                    foreach (DataGridViewRow gridRow in activityGrid.Rows)
                    {
                        int gridID = Convert.ToInt32(gridRow.Cells["id"].Value);

                        if (idActivity == gridID)
                        {
                            gridRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); ; // Те которые забил левый чел
                        }
                    }
                }
            }
            if (gotActivities.Rows.Count > 0)
            {
                foreach (DataRow row in gotActivities.Rows)
                {
                    int idActivity = Convert.ToInt32(row["activity_id"]); // Получаем значение столбца "title" в текущей строке DataTable

                    foreach (DataGridViewRow gridRow in activityGrid.Rows)
                    {
                        int gridID = Convert.ToInt32(gridRow.Cells["id"].Value); // Получаем значение ячейки в столбце "title" в DataGridView

                        if (idActivity == gridID)
                        {
                            gridRow.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204))))); // Те которые я забил
                        }
                    }
                }
            }
        }

        private void getGender()
        {
            DataTable getGender = new DataTable();
            getGender = functions.sqlSelect($"SELECT gender, [first name] FROM [dbo].[Moderators] WHERE [e-mail] = '{DataBank.userEmail}'");
            string moderatorGender = getGender.Rows[0][0].ToString();
            if(moderatorGender[0] == 'ж')
            {
                nameTextBox.Text = $"Ms. {getGender.Rows[0][1]}";
            }
            else
            {
                nameTextBox.Text = $"Mr. {getGender.Rows[0][1]}";
            }
        }

        private void getActivitiesForComboBox()
        {
            DataTable resultTable = functions.sqlSelect("SELECT title FROM [dbo].[Activities]");
            pathToActivity.Items.Clear();
            foreach (DataRow row in resultTable.Rows)
            {
                string title = row["title"].ToString();
                pathToActivity.Items.Add(title);
            }
            pathToActivity.ValueMember = "title";
        }

        public void getListEventsForComBox()
        {
            DataTable resultTable = functions.sqlSelect("SELECT title FROM [dbo].[Events]");
            eventList.Items.Clear();
            foreach (DataRow row in resultTable.Rows)
            {
                string title = row["title"].ToString();
                eventList.Items.Add(title);
            }
            eventList.ValueMember = "title";
        }

        private List<TimeSpan> GetActivityTimes()
        {
            DataTable gotTime = new DataTable();
            gotTime = functions.sqlSelect($"SELECT [Activities].[time] FROM [dbo].[Activities] JOIN [dbo].[Activity log] ON [dbo].[Activities].[id] = [dbo].[Activity log].[activity_id] WHERE event_id = {eventID} AND moderator_id is not null");

            List<TimeSpan> activityTimes = new List<TimeSpan>(); // Создаем список для сохранения временных значений

            foreach (DataRow row in gotTime.Rows)
            {
                TimeSpan time = TimeSpan.Parse(row["time"].ToString()); // Получаем значение столбца "time" в текущей строке DataTable

                activityTimes.Add(time); // Добавляем время в список activityTimes
            }

            return activityTimes;
        }


        private void сheckButton_Click(object sender, EventArgs e)
        {
            bool isOccupied = false;
            if (activityGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = activityGrid.SelectedRows[0];
                TimeSpan timeFromDGW = TimeSpan.Parse(row.Cells["time"].Value.ToString());
                
                foreach(TimeSpan time in GetActivityTimes())
                {
                    if (time == timeFromDGW)
                    {
                        isOccupied = true;
                    }
                }
                if (isOccupied == true)
                {
                    MessageBox.Show("\tОтмена прошлого мероприятия и заявка на новое;\r\n\tОтмена заявки на данное мероприятие.", "This time is already occupied");
                }
                else if (isOccupied == false)
                {
                    int activityID = Convert.ToInt32(row.Cells["id"].Value);
                    functions.sqlInsert($"UPDATE [Activity log] SET [moderator_id] = '{DataBank.userID}' WHERE activity_id = '{activityID}';");
                    MessageBox.Show($"You have signed up for the moderation of this event: {activityID}");
                }
            }
            else
            {
                MessageBox.Show("You didn't select data");
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

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = eventList.SelectedItem.ToString();
            DataTable getIDEvent = new DataTable();
            getIDEvent = functions.sqlSelect($"SELECT id FROM [dbo].[Events] WHERE title = '{selectedValue}'");
            eventID = Convert.ToInt32(getIDEvent.Rows[0][0]);
            ModeratorWindow_Load(sender, e);

        }

        private void pathToActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = pathToActivity.SelectedItem.ToString();
            activityGrid.DataSource = functions.sqlSelect($"SELECT [Activities].id, [Activities].title, [Events].[date], [Activities].[time] FROM [Activities] JOIN [Activity log] ON [Activities].[id] = [Activity log].activity_id JOIN [Events] ON [Events].id = [Activity log].event_id  WHERE [Activities].title = '{selectedValue}'");
            coloringRows();
        }
    }
}
