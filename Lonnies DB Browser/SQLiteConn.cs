using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Lonnies_DB_Browser
{
    public class SQLiteConn : DatabaseConnection
    {
        public SQLiteConnection Connection { get; set; }
        public string DatabasePath { get; set; }
        public string Version { get; set; }
        public string Password { get; set; }

        public SQLiteConn(string databasePath, string password, string version = "3")
        {
            Connection = new SQLiteConnection();
            Version = version;
            DatabasePath = databasePath;
            Password = password;
        }

        public override string GetConnectionString()
        {
            if (Password.Length > 0)
            {
                return "Data Source=" + DatabasePath + ";Version=" +
                    Version + ";Password=" + Password;
            }
            else { return "Data Source=" + DatabasePath + ";Version=" + Version + ";"; }
        }

        public override void OpenConnection()
        {
            Connection.ConnectionString = GetConnectionString();
            try { Connection.Open(); }
            catch (Exception e) { throw e; }
        }

        public override void CloseConnection()
        {
            try { Connection.Close(); }
            catch (Exception) { }
        }

        public override string SqlSelect(string qry)
        {
            SQLiteCommand cmd = new SQLiteCommand(qry, Connection);
            SQLiteDataReader reader;            
            string result = "NULL";

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader[0].ToString();
                    reader.Close();
                }
            }
            catch (Exception e) { throw e; }
            return result;
        }

        public override DataTable SqlSelectTable(string qry)
        {

            DataTable dt = new System.Data.DataTable();
            SQLiteCommand cmd = new SQLiteCommand(qry, Connection);
            SQLiteDataReader reader;     
            try
            {
                reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception e) { throw e; }
            return dt;
        }

        public override void SqlExecute(string qry)
        {
            SQLiteCommand cmd = new SQLiteCommand(qry, Connection);
            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw e; }
        }
    }
}
