using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace microserviciocrud.Database
{
    public class DB
    {
        SqlConnection conexionn = new SqlConnection("Data Source=MARIAN\\MSSQLSERVER2;Initial Catalog=userm;User ID=sa;Password=3483440");
    
        public string MostrarInfo(string funcion, int cant)
        {
            string resultado = "";
            conexionn.Open();
            SqlCommand comando = new SqlCommand(funcion, conexionn);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                for (int i = 0; i < cant; i++)
                {
                    resultado += lector.GetValue(i).ToString() + " ";
                }
            }
            conexionn.Close();
            return resultado;
        }
    }
}
