using System;

namespace GestaoPecuaria.Data
{
    internal class MySqlConnection
    {
        private string strconexao;

        public MySqlConnection(string strconexao)
        {
            this.strconexao = strconexao;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}