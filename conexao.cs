using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_inclusiON
{
    internal class conexao
    {
        private static string server = @"BOT0713145W11-1\";
        private static string database = "bd_inclusiON";
        private static string user = "sa";
        private static string password = "sasenac";

        public static string IniciarCon
        {
            get
            {
                return "Data Source=" + server + "; Integrated Security=False;Initial Catalog=" + database + ";" +
                    "User ID=" + user + "; Password=" + password;
            }
        }
    }
}
