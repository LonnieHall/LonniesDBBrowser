using System;
using System.Data;
using System.Data.OleDb;

namespace Lonnies_DB_Browser
{
    public class JetConnection : DatabaseConnection
    {
        public OleDbConnection Connection { get; set; }
        public string DatabasePath { get; set; }
        public string Provider { get; set; }
        public string Password { get; set; }

        public JetConnection(string databasePath, string password = "", string provider = "Microsoft.Jet.OLEDB.4.0") 
        {
            Connection = new OleDbConnection();
            Provider = provider;
            DatabasePath = databasePath;
            Password = password;
        }

        public override string GetConnectionString() 
        {
            if (Password.Length > 0)
            {
                return "Data Source=" + DatabasePath + ";Provider=" +
                    Provider + ";Jet OleDB:Database Password=" + Password;
            }
            else 
            {
                return "Data Source=" + DatabasePath + ";Provider=" +
                    Provider + ";";
            }
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
            OleDbCommand cmd = new OleDbCommand(qry, Connection);
            OleDbDataReader reader;
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

        public override DataTable SqlSelectTable(string qryString)
        {

            DataTable dt = new System.Data.DataTable();
            OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(qryString, Connection);
            OleDbDataReader reader;
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
            OleDbCommand cmd = new OleDbCommand(qry, Connection);
            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw e; }
        }
    }
}
