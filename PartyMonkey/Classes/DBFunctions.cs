using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Boolean CheckAccauntInExistDB(string chaeckUsername, string checkEmail)
        {
            if (sqlSelect($"select username, email from customers where login = '{chaeckUsername}' OR email = '{checkEmail}'").Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
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
            var id = Convert.ToInt32(sqlSelect($"SELECT id FROM [Events] WHERE title = '{EventName}'").Rows[0][0]);

            return id
        }

        public List<string> GetNamesFromTable(int event_id)
        {
            List<string> namesList = new List<string>();

            using (SqlConnection connection = new SqlConnection(DataBase.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT Activities.title, " +
                    $"Activities.[time], Jury.[last name] FROM [Activity log] JOIN Activities ON Activities.id = " +
                    $"[Activity log].activity_id JOIN Jury ON Jury.id = [Activity log].jury_id WHERE " +
                    $"event_id = {event_id}", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    namesList.Add(reader["name"].ToString());
                }

                reader.Close();
            }

            return namesList;
        }
    }
}
