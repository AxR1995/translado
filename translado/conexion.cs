using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Input;
using System.Windows.Forms;


namespace translado
{
    public class bdcomun
    {

        public static MySqlConnection conexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=hotelsancarlos; Uid=root; pwd=andy;");
            conectar.Open();
            return conectar;
        }
    }
}
