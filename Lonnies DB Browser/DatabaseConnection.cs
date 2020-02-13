using System;
using System.Data;

namespace Lonnies_DB_Browser
{
    public class DatabaseConnection
    {
        public string ConnectionString { get; set; }

        public string Quotify(string inString)
        {
            if (inString == "") { return "NULL"; }
            return "'" + inString.Replace("'", "''") + "'";
        }

        public string TrueFalse(bool isTrue)
        {
            string returnValue = isTrue ? "1" : "0";
            return returnValue;
        }

        public virtual string GetConnectionString() { return "??"; }

        public virtual void OpenConnection() { }

        public virtual void CloseConnection() { }

        public virtual string SqlSelect(string qry) { return "??"; }

        public virtual DataTable SqlSelectTable(string qryString) { return null; }

        public virtual void SqlExecute(string qry) { }
    }
}

