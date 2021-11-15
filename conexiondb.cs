using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace deswebfinal.dbweb
{
    public class Conexiondb
    {
        string cadena = "Data Source=fredy5\\sqlserver;Initial Calago=dbweb; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public Conexiondb()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir "+ ex.Message);
            }

        }

        public void Cerrar()
        {
            conectarbd.Close();
        }

    }


}
