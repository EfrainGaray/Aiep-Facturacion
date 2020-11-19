using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace capaPersintencia
{
    public class daoCliente
    {
        public bool registrarCliente() {
            return false;
        }

        public bool modificarCliente()
        {
            return false;
        }

        public bool desactivarCliente()
        {
            return false;
        }
        public bool consultarCliente()
        {
            return false;
        }

        public Cliente detalleClienteId(int id)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM cliente where id=@id";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@id", SqlDbType.Int);
                sqlData.SelectCommand.Parameters["@id"].Value = id;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                Cliente clienteAux = new Cliente();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {

                        clienteAux.Rut = dataTable.Rows[i]["rut"].ToString();
                        clienteAux.RazonSocial = dataTable.Rows[i]["razonSocial"].ToString();
                        clienteAux.Direccion = dataTable.Rows[i]["direccion"].ToString();
                        clienteAux.Email = dataTable.Rows[i]["email"].ToString();
                        clienteAux.Telefono = dataTable.Rows[i]["telefono"].ToString();
                    }
                }

                return clienteAux;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
