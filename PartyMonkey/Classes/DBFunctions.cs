using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using System.Windows.Forms;

namespace PartyMonkey
{
    public class DBFunctions
    {
        DataBase database = new DataBase();
        
        public DataTable sqlSelect(String s)
        {
            SqlCommand command = new SqlCommand(s);
            command.Connection = database.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public SqlCommand sqlInsert(String querystring)
        {
            database.openConnection();
            SqlCommand command = new SqlCommand(querystring);
            command.Connection = database.GetConnection();
            command.ExecuteNonQuery();
            database.closeConnection();
            return command;
        }

        public Boolean CheckAccauntInExistDB(string checkEmail)
        {
            if (sqlSelect($"select [e-mail] from [dbo].[Users] where [e-mail] = '{checkEmail}'").Rows.Count > 0)
            {
                MessageBox.Show("E-mail is already exist");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public List<string> GetTableNamesFromDatabase()
        {
            List<string> tableNames = new List<string>();

            DataTable tables = new DataTable();
            tables = sqlSelect("SELECT name FROM sys.tables WHERE type = 'U'");


            foreach (DataRow row in tables.Rows)
            {
                tableNames.Add(row["name"].ToString());
            }

            return tableNames;
        }

        public int GetEventID(string EventName)
        {
            int id = Convert.ToInt32(sqlSelect($"SELECT id FROM [Events] WHERE title = '{EventName}'").Rows[0][0]);
            return id;
        }

        public DataTable GetAllEventsTitle()
        {
            var id = sqlSelect($"SELECT title FROM [Events]");
            return id;
        }

        public List<string> GetNamesFromTable(int event_id)
        {
            List<string> namesList = new List<string>();
            
            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT Activities.title, Activities.[time], Jury.[last name] " +
                        "FROM [Activity log] JOIN Activities ON Activities.id = [Activity log].activity_id " +
                        "JOIN Jury ON Jury.id = [Activity log].jury_id WHERE event_id = @eventID", connection);
                    command.Parameters.AddWithValue("@eventID", event_id);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string title = reader.GetString(0);
                        TimeSpan time = reader.GetTimeSpan(1);
                        string lastName = reader.GetString(2);

                        StringBuilder sb = new StringBuilder();
                        sb.Append(title);
                        sb.Append(", ");
                        sb.Append(time.ToString());
                        sb.Append(", ");
                        sb.Append(lastName);
                        namesList.Add(sb.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении значений: {ex.Message}");
                }
            }

            return namesList;
        }
    }
}
