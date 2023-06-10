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
using iTextSharp.text;

namespace PartyMonkey.Forms
{
    public partial class KanbanBoard : Form, IBackForm
    {
        private string ChosenEvent { get; set; }
        private DBFunctions functions;
        private Button[] buttons;
        public List<string> eventsList { get; private set; }
        private string selectedValue;
        private int EventID { get; set; }
        private Button draggingButton = null;
        private string ButtonTextForDandD;

        public KanbanBoard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void KanbanBoard_Load(object sender, EventArgs e)
        {
            BackForm();
            GetListEventsForComBox();
            
        }

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = eventList.SelectedItem.ToString();
            EventID = functions.GetEventID(selectedValue);
            CreateButtons();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            NonModalWindow nonModalWindow = new NonModalWindow();
            nonModalWindow.CreateWindow();
        }

        private void CreateButtons()
        {
            if (buttons != null)
            {
                foreach (Button button in buttons)
                {
                    button.Click -= ButtonClick;
                    button.MouseDown -= ButtonMouseDown;
                    button.AllowDrop = false;
                    button.Dispose(); // Освобождаем ресурсы кнопки
                }
            }
            List<string> tableNames = functions.GetNamesFromTable(EventID);
            buttons = new Button[tableNames.Count];

            System.Drawing.Rectangle bounds = this.Bounds;
            int left = bounds.Left;
            int top = bounds.Top;
            int width = bounds.Width;
            int height = bounds.Height;
            int buttonWidth = 365;
            int buttonHeight = 80;
            int verticalSpacing = 15;
            int horizontalSpacing = 25;
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
                    button.MouseDown += ButtonMouseDown;
                    button.AllowDrop = true;
                    button.DragEnter += ButtonDragEnter;
                    button.DragDrop += ButtonDragDrop;
                    button.Text = tableNames[index];
                    button.Size = new Size(buttonWidth, buttonHeight);
                    int columnToRender = col;
                    button.Location = new Point(col * (buttonWidth + horizontalSpacing) + 25, row * (buttonHeight + verticalSpacing) + 200);
                    buttons[index] = button;
                    buttons[index].BackColor = System.Drawing.Color.White;
                    buttons[index].Cursor = System.Windows.Forms.Cursors.Hand;
                    buttons[index].FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
                    buttons[index].FlatAppearance.BorderSize = 2;
                    buttons[index].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    buttons[index].Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
                    buttons[index].Text = tableNames[index];
                    button.Click += new EventHandler(ButtonClick);
                    this.Controls.Add(button);
                }
            }
        }

        private void ButtonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draggingButton = (Button)sender;
                draggingButton.DoDragDrop(draggingButton.Text, DragDropEffects.Move);
            }
        }

        private void ButtonDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ButtonDragDrop(object sender, DragEventArgs e)
        {
            Button targetButton = (Button)sender;
            ButtonTextForDandD = targetButton.Text;
            targetButton.Text = (string)e.Data.GetData(typeof(string));
            draggingButton.Text = ButtonTextForDandD;
            if (targetButton.Text == draggingButton.Text)
            {
                ButtonClick(sender, e);
            }
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (eventList.SelectedItem.ToString() != null)
            {
                List<string> tableNames = functions.GetNamesFromTable(EventID);

            }
            else
            {
                MessageBox.Show("You have not selected an activity");
            }
        }
    }
}
