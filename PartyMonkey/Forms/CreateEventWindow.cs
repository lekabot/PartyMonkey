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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace PartyMonkey.Forms
{
    public partial class CreateEventWindow : Form
    {
        DBFunctions functions = new DBFunctions();

        public CreateEventWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void createEventWindow_Load(object sender, EventArgs e)
        {
            getCities();
        }

        private void getCities()
        {
            DataTable dataTable = functions.sqlSelect($"SELECT title FROM Cities");
            City.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string title = row["title"].ToString();
                City.Items.Add(title);
            }
            City.ValueMember = "title";

            //Это в кнопку
            //if (comboBox3.SelectedItem != null)
            //{
            //    string selectedCity = comboBox3.SelectedItem.ToString();

            //    if (!CheckCityExists(selectedCity))
            //    {
            //        functions.sqlInsert($"INSERT INTO Cities(title) VALUES('{selectedCity}');");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a value from the list.");
            //}
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

        private void myProfileBT_Click(object sender, EventArgs e)
        {
            if (new[] { Beginning.Text, Ending.Text, Event.Text, City.Text, title.Text, jury.Text }
                .All(x => string.IsNullOrWhiteSpace(x)))
            {
                MessageBox.Show("You didn't specify a field", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void checkNullFields()
        {
            List<MaskedTextBox> maskedTextBoxes = new List<MaskedTextBox> { Beginning, Ending, title };

            List<ComboBox> comboBoxes = new List<ComboBox> { Event, City, time, jury };

            List<string> emptyFields = new List<string>();

            foreach (MaskedTextBox textBox in maskedTextBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    emptyFields.Add(textBox.Name);
                }
            }

            if (emptyFields.Count > 0)
            {
                // Вывод списка пустых полей
                foreach (string fieldName in emptyFields)
                {
                    Console.WriteLine($"Поле {fieldName} пустое.");
                }
            }
            else
            {
                // Все поля заполнены
            }

            foreach (ComboBox textBox in comboBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    emptyFields.Add(textBox.Name);
                }
            }

            if (emptyFields.Count > 0)
            {
                // Вывод списка пустых полей
                foreach (string fieldName in emptyFields)
                {
                    Console.WriteLine($"Поле {fieldName} пустое.");
                }
            }
            else
            {
                // Все поля заполнены
            }

        }
    }
}
