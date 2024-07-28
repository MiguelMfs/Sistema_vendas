using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas
{
    public class conexao
    {
        public MySqlConnection GetConnection()
        {
            string conn = "server=localhost; " +
                "user=root; " +
                "password=madnessa;" +
                "database=sistema_vendas;";

            return new MySqlConnection(conn);
        }

    }
}
