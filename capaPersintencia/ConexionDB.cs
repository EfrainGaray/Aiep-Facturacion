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

            Conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection Conexion { get => conexion; set => conexion = value; }

        public void abrirConexion()
        {
            try
            {
                if (Conexion.State == System.Data.ConnectionState.Closed)
                {
                    Conexion.Open();

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
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
