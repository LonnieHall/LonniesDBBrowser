using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Lonnies_DB_Browser
{
    public class MySQLConnection : DatabaseConnection
    {
        public MySqlConnection Connection { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }

        public MySQLConnection(string username, string password, string host, string databasename, string port = "3306")
        {
            UserName = username;
            Password = password;
            Host = host;
            Port = port;
            DatabaseName = databasename;
            Connection = new MySqlConnection();
        }

        public override string GetConnectionString()
        {
            return "Server=" + Host + ";Port=" + Port + ";Database=" +
               DatabaseName + ";Uid=" + UserName + ";Pwd=" + Password + ";SSL Mode=Required;";
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
            var cmd = new MySqlCommand(qry, Connection);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader[0].ToString();
                }
            }
            return "NULL";
        }

        public string SqlSelectIdentity()
        { return SqlSelect("SELECT LAST_INSERT_ID();"); }

        public override void SqlExecute(string qry)
        {
            var cmd = new MySqlCommand(qry, Connection);
            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw e; }
        }

        public override DataTable SqlSelectTable(string qryString)
        {
            var dt = new DataTable();
            var cmd = new MySqlCommand(qryString, Connection);
            using (var reader = cmd.ExecuteReader()) { dt.Load(reader); }
            return dt;
        }

        public string Datify(DateTime inDate)
        {
            if (inDate == null) { return "NULL"; }
            return "STR_TO_DATE('" + inDate.ToShortDateString() + "', '%m/%d/%Y %p')";
        }

        public string DatifyLong(DateTime inDate)
        {
            if (inDate == null) { return "NULL"; }
            return "STR_TO_DATE('" + inDate.ToString() + "', '%m/%d/%Y %h:%i:%s %p')";
        }

        public bool IsOpen()
        {
            try { return Connection.State == ConnectionState.Open; }
            catch (Exception) { return false; }            
        }

    }
}
