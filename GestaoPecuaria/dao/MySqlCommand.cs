using GestaoPecuaria.Data;
using System;

namespace GestaoPecuaria.dao
{
    internal class MySqlCommand
    {
        private string sql;
        private MySqlConnection mySqlConnection;

        public MySqlCommand(string sql, MySqlConnection mySqlConnection)
        {
            this.sql = sql;
            this.mySqlConnection = mySqlConnection;
        }

        public object Parameters { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}