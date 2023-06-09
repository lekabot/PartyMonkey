using PartyMonkey.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;

namespace PartyMonkey.Forms
{
    public partial class EventWindow : Form, IBackForm
    {
        DBFunctions functions = new DBFunctions();

        private DateTime BeginingEventDate { get; set; }
        private int DurationEvent { get; set; }
        private string EventName { get; set; }
        private int EventCity { get; set; }


        public EventWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void createEventWindow_Load(object sender, EventArgs e)
        {
            Event.AutoCompleteMode = AutoCompleteMode.Suggest;
            Event.AutoCompleteSource = AutoCompleteSource.ListItems;
            GetJuriesToComboBox();
            GetCitiesToComboBox();
            BackForm();
            ActivityTime();
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

        private void ActivityTime()
        {
            //// Задаем начальное время и конечное время
            //DateTime startTime = DateTime.Parse("12:00 AM");
            //DateTime endTime = DateTime.Parse("24:00 PM");

            //// Задаем временной интервал активностей и перерыва
            //TimeSpan activityInterval = TimeSpan.FromMinutes(90);
            //TimeSpan breakInterval = TimeSpan.FromMinutes(15);

            //// Создаем список временных значений
            //List<string> timeSlots = new List<string>();

            //// Генерируем временные значения
            //DateTime currentTime = startTime;
            //while (currentTime.Add(activityInterval) <= endTime)
            //{
            //    timeSlots.Add(currentTime.ToString("hh:mm tt"));
            //    currentTime = currentTime.Add(activityInterval).Add(breakInterval);
            //}

            //// Заполняем ComboBox
            //timeActivity1.DataSource = timeSlots;
        }

        private void GetJuriesToComboBox()
        {
            DataTable dataTable = functions.sqlSelect($"SELECT [last name] FROM Jury");
            City.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string LastName = row["last name"].ToString();
                juryAct1.Items.Add(LastName);
                juryAct2.Items.Add(LastName);
                juryAct3.Items.Add(LastName);
            }
            juryAct1.ValueMember = "last name";
            juryAct2.ValueMember = "last name";
            juryAct3.ValueMember = "last name";
        }

        private void GetCitiesToComboBox()
        {
            DataTable dataTable = functions.sqlSelect($"SELECT title FROM Cities");
            City.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string title = row["title"].ToString();
                City.Items.Add(title);
            }
            City.ValueMember = "title";
        }
        /// <summary>
        /// Add event button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myProfileBT_Click(object sender, EventArgs e)
        {
            if (WorkingWithDate())
            {
                if (new[] { Event.Text, City.Text.ToString() }.All(x => string.IsNullOrWhiteSpace(x)))
                {
                    MessageBox.Show("You didn't specify event name or city", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.EventName = Event.Text;
                }

                if (CheckCityExists(City.Text.ToString()))
                {
                    GetIdCity(City.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Please select city a value from the list.");
                }

                CreateNewEvent();
            }
        }

        private void CreateNewEvent()
        {
            var command = functions.sqlInsert($"INSERT INTO [dbo].[Events] (title, date, days, city) VALUES('{this.EventName}', '{this.BeginingEventDate}', {this.DurationEvent}, {this.EventCity});");
            MessageBox.Show("The event has been added", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetIdCity(string city) { var id = Convert.ToInt32(functions.sqlSelect($"SELECT id FROM Cities WHERE title = '{city}'").Rows[0][0]); this.EventCity = id; } 

        /// <summary>
        /// Calculating duration event and check dates for correctness
        /// </summary>
        private bool WorkingWithDate()
        {
            if (new[] { Beginning.Text, Ending.Text }.All(x => string.IsNullOrWhiteSpace(x)))
            {
                MessageBox.Show("You didn't specify event name", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                DateTime BeginningDate;
                DateTime EndingDate;

                if (DateTime.TryParse(Beginning.Text, out BeginningDate) && DateTime.TryParse(Ending.Text, out EndingDate))
                {
                    if (BeginningDate < DateTime.Now)
                    {
                        MessageBox.Show("The start time of the event has already passed", "Date is not correct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (EndingDate < DateTime.Now)
                    {
                        MessageBox.Show("The end time of the event has already passed", "Date is not correct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (BeginningDate > EndingDate)
                    {
                        MessageBox.Show("The date entered is not correct", "Date is not correct", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        TimeSpan duration = EndingDate - BeginningDate;
                        this.BeginingEventDate = BeginningDate;
                        this.DurationEvent = (int)duration.TotalDays;

                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("You have entered an incorrect date", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private bool CheckCityExists(string city)
        {
            bool cityExists = false;
            string query = $"SELECT COUNT(*) FROM Cities WHERE title = '{city}'";

            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int count = (int)command.ExecuteScalar();
                cityExists = (count > 0);
            }

            return cityExists;
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

        private void Board_button_Click(object sender, EventArgs e)
        {
            KanbanBoard kanbanBoard = new KanbanBoard();
            this.Hide();
            kanbanBoard.Show();
        }
    }
}
