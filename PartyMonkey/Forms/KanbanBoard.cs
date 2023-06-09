using PartyMonkey.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyMonkey.Forms
{
    public partial class KanbanBoard : Form, IBackForm
    {
        private string ChosenEvent { get; set; }
        DBFunctions functions;
        Button[] buttons;
        List<string> eventsList;
        string selectedValue;


        public KanbanBoard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CreateButtons();
        }

        private void KanbanBoard_Load(object sender, EventArgs e)
        {
            BackForm();
            GetListEventsForComBox();
        }

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = eventList.SelectedItem.ToString();
        }

        private void ButtonClick(object sender, EventArgs e)
        {

        }

        private void CreateButtons()
        {
            List<string> tableNames = functions.GetNamesFromTable(functions.GetEventID(selectedValue));
            buttons = new Button[tableNames.Count];
            Rectangle bounds = this.Bounds;
            int left = bounds.Left;
            int top = bounds.Top;
            int width = bounds.Width;
            int height = bounds.Height;
            int buttonWidth = 365;
            int buttonHeight = 80;
            int verticalSpacing = 45;
            int horizontalSpacing = 45;
            int buttonsPerRow = width / (buttonWidth + horizontalSpacing);

            int rowCount = (tableNames.Count + buttonsPerRow - 1) / buttonsPerRow; // Определение числа строк

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < buttonsPerRow; col++)
                {
                    int index = row * buttonsPerRow + col; // Индекс текущей кнопки в списке

                    if (index >= tableNames.Count)
                    {
                        break; // Прекращаем цикл, если все кнопки уже созданы
                    }

                    Button button = new Button();
                    button.Text = tableNames[index];
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Location = new Point(col * (buttonWidth + horizontalSpacing) + 10, row * (buttonHeight + verticalSpacing) + 60);
                    buttons[index] = button;
                    buttons[index].BackColor = System.Drawing.Color.White;
                    buttons[index].Cursor = System.Windows.Forms.Cursors.Hand;
                    buttons[index].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
                    buttons[index].FlatAppearance.BorderSize = 2;
                    buttons[index].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    buttons[index].Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
                    buttons[index].Location = new System.Drawing.Point(33, 187);
                    buttons[index].Name = "button1";
                    buttons[index].Size = new System.Drawing.Size(365, 80);
                    buttons[index].TabIndex = 60;
                    buttons[index].Text = "Попрыгушки, 12:45, Лопатин";
                    buttons[index].UseVisualStyleBackColor = false;
                    button.Click += new EventHandler(ButtonClick);
                    this.Controls.Add(button);
                }
            }
        }

        //private void GetChosenActivities()
        //{
        //    functions = new DBFunctions();
        //    var FirstActivities = functions.sqlSelect($"SELECT ");
        //}

        public void GetListEventsForComBox()
        {
            functions = new DBFunctions();
            DataTable resultTable = functions.sqlSelect("SELECT title FROM [dbo].[Events]");
            eventList.Items.Clear();
            foreach (DataRow row in resultTable.Rows)
            {
                string title = row["title"].ToString();
                eventList.Items.Add(title);
            }
            eventList.ValueMember = "title";
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
    }
}
