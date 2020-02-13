using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lonnies_DB_Browser
{
    public class MsSQLServerConnection : DatabaseConnection
    {
        public SqlConnection Connection { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }

        public MsSQLServerConnection(string username, string password, string host, string databasename)
        {
            UserName = username;
            Password = password;
            Host = host;
            DatabaseName = databasename;
            Connection = new SqlConnection();
        }

        public override string GetConnectionString()
        {
            return "Server=" + Host + ";Trusted_Connection=yes" + ";Database=" +
               DatabaseName + ";Uid=" + UserName + ";Pwd=" + Password + ";";
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
            var cmd = new SqlCommand(qry, Connection);
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
        { return SqlSelect("SELECT SCOPE_IDENTITY();"); }

        public override void SqlExecute(string qry)
        {
            var cmd = new SqlCommand(qry, Connection);
            try { cmd.ExecuteNonQuery(); }
            catch (Exception e) { throw e; }
        }

        public override DataTable SqlSelectTable(string qryString)
        {
            var dt = new DataTable();
            var cmd = new SqlCommand(qryString, Connection);
            using (var reader = cmd.ExecuteReader()) { dt.Load(reader); }
            return dt;
        }
    }
}
