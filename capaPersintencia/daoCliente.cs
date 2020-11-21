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

        public bool clienteExiste(string rut)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM cliente where rut=@rut";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@rut", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@rut"].Value = rut;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                Cliente clienteAux = new Cliente();
                if (dataTable.Rows.Count > 0)
                {
                    return true;
                }
                else {
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public int getIdCliente(string rut) {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM cliente where rut=@rut";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@rut", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@rut"].Value = rut;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                int idCliente=-1;
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {

                        idCliente = int.Parse(dataTable.Rows[i]["id"].ToString()) ;
                    }
                }

                return idCliente;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool registrarCliente( Cliente nuevoCliente) {
            try
            {

                ConexionBD conexion = new ConexionBD();

                conexion.abrirConexion();

                string sqlQuery = "INSERT INTO cliente (rut, razonSocial, direccion, telefono, email) " +
                             "values(@rut, @razonSocial, @direccion , @telefono , @email)";

                SqlCommand commandSql = new SqlCommand(sqlQuery, conexion.Conexion);


                commandSql.Parameters.AddWithValue("@rut", SqlDbType.VarChar);
                commandSql.Parameters["@rut"].Value = nuevoCliente.Rut;

                commandSql.Parameters.AddWithValue("@razonSocial", SqlDbType.VarChar);
                commandSql.Parameters["@razonSocial"].Value = nuevoCliente.RazonSocial;

                commandSql.Parameters.AddWithValue("@direccion", SqlDbType.Int);
                commandSql.Parameters["@direccion"].Value = nuevoCliente.Direccion;

                commandSql.Parameters.AddWithValue("@telefono", SqlDbType.VarChar);
                commandSql.Parameters["@telefono"].Value = nuevoCliente.Telefono;

                commandSql.Parameters.AddWithValue("@email", SqlDbType.Int);
                commandSql.Parameters["@email"].Value = nuevoCliente.Email;

                //Ejecución de query
                int filasAfectadas = commandSql.ExecuteNonQuery();

                conexion.cerrarConexion();

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
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

        public Cliente detalleClienteRut(string rut)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM cliente where rut=@rut";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@rut", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@rut"].Value = rut;


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
                        clienteAux.IdCliente= int.Parse(dataTable.Rows[i]["id"].ToString()) ; 
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
