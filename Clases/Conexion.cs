using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Clases
{
    internal class Conexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string server = "localhost";
        static string db = "prueba";
        static string user="root";
        static string password="12345";
        static string port="3306";
        
        string cadenaConexion  = "server=" + server + ";" +"port=" + port + ";"+"user id="+user+";"+"password="+password+";"+"database="+db+";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Succes conection");
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Failed Conection"+e.ToString());
            }
            return conex;
        }
    }
}
