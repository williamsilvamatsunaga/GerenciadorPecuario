using System;

namespace GestaoPecuaria.Data
{
    internal class MySqlConnection2
    {
        private string strconexao;

        public MySqlConnection2(string strconexao)
        {
            this.strconexao = strconexao;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}