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
            comboBox3.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                string title = row["title"].ToString();
                comboBox3.Items.Add(title);
            }
            comboBox3.ValueMember = "title";

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

    }
}
