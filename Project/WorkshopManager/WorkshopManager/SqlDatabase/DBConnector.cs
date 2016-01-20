using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
/*
Należy pobrać MySQL Installer ze strony
https://dev.mysql.com/downloads/installer/
a następnie przy jego pomocy zainstalować MySQL Connector/NET
Po zainstalowaniu konektora należy dodać referencję do solucji:
-w solucji WorkshopManager kliknąć prawym przyciksiem na References
-wybrać Add References
-przejść do zakładki Extensions
-znaleść MySql.Data, zaznaczyć i kliknąć ok
*/

namespace WorkshopManager.SqlDatabase.MySql
{
    public static class DBConnector
    {
        private static MySqlConnection _connection;
        private static string _server;
        private static string _database;
        private static string _uid;
        private static string _password;

        static DBConnector()
        {
            Initialize();
        }

        private static void Initialize()
        {
            _server = "mysql.sh178054.website.pl";
            _database = "sh178054_carserwis";
            _uid = "sh178054_Cars";
            _password = "autko123";
            string connectionString =   "SERVER=" + _server + ";" +
                                        "DATABASE=" + _database + ";" +
                                        "UID=" + _uid + ";" +
                                        "PASSWORD=" + _password + ";";
            _connection = new MySqlConnection(connectionString);
        }

        private static bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password!");
                        break;
                }
                return false;
            }
        }

        private static bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static List<string>[] Select(string data, bool distinct, string table, string where)
        {
            where = (where == "") ? "" : string.Format("where {0}", where);

            string query = (distinct) ?
                string.Format("Select distinct {0} from {1} {2};", data, table, where) :
                string.Format("Select {0} from {1} {2};", data, table, where);

            int row = 0;
            var dataList = new string[GetRows(data)];

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',') row++;
                else
                if (data[i] != ' ') dataList[row] += data[i];
            }
            row++;

            var list = new List<string>[row];
            for (int i = 0; i < row; i++)
            {
                list[i] = new List<string>();
            }

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    for (int i = 0; i < row; i++)
                    {
                        list[i].Add(dataReader[dataList[i]].ToString());
                    }
                }
                dataReader.Close();
                CloseConnection();
                return list; 
            }
            else
            {
                return list;
            }
        }

        private static int GetRows(string data)
        {
            int rows = 1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',') rows++;
            }
            return rows;
        }

        public static void Insert(string table, string columns, string values)
        {
            if (GetRows(columns) != GetRows(values))
                return;

            var sqlCommand = string.Format("INSERT INTO {0} ({1}) VALUES ({2});", table, columns, values);

            if (OpenConnection())
            {
                try
                {
                    using (var command = new MySqlCommand(sqlCommand, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                finally
                {
                    CloseConnection();
                }
            }
        }

        public static void Update(string table, string set, string where)
        {
            var sqlCommand = string.Format("UPDATE {0} SET {1} where {2}", table, set, where);

            if (OpenConnection())
            {
                try
                {
                    using (var command = new MySqlCommand(sqlCommand, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public static void Delete(string table, string where)
        {
            var sqlCommand = string.Format("DELETE FROM {0} WHERE {1}", table, where);

            if (OpenConnection())
            {
                try
                {
                    using (var command = new MySqlCommand(sqlCommand, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }
    }
}
