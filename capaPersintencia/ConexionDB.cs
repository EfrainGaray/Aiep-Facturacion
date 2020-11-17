using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPersintencia
{
    public class ConexionBD
    {
        private string cadenaConexion = @"";
        private SqlConnection conexion = null;

        public ConexionBD()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["ProyectoFacturacionBD"].ConnectionString;

            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection Conexion { get => conexion; }

        public void abrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
