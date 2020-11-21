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
    public class daoIntegracionDocumento
    {
        //Obtener datos de la base para los tipos de documentos
        public List<TipoDocumento> detalleTDocumento()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM tipoDocumento";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<TipoDocumento> tipoDocumentos = new List<TipoDocumento>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        TipoDocumento tDocumentoAux = new TipoDocumento();
                        tDocumentoAux.Nombre = dataTable.Rows[i]["nombre"].ToString();
                        tDocumentoAux.IdTDocumento = int.Parse(dataTable.Rows[i]["id"].ToString());


                        tipoDocumentos.Add(tDocumentoAux);
                    }
                }
                return tipoDocumentos;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool eliminarDDocumento( int id)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sqlQuery = "DELETE FROM detalleDocumento where id= @id";
                SqlCommand commandSql = new SqlCommand(sqlQuery, conexion.Conexion);

                DataTable dataTable = new DataTable();

                commandSql.Parameters.AddWithValue("@id", SqlDbType.Int);
                commandSql.Parameters["@id"].Value = id;

                conexion.cerrarConexion();
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

        //Ingresar y obtener detalle del documento
        public int ingresarDetalle(List<DetalleDocumento> detalle)
        {

            try
            {

                ConexionBD conexion = new ConexionBD();
                int cantidadRegistros = 0;
                conexion.abrirConexion();

                string sqlQuery = "INSERT INTO detalleDocumento (cantidadProducto, precioProducto, producto_id, documento_id, estado) " +
                             "values(@cantidadProducto, @precioProducto, @producto_id , @documento_id , @estado)";

                SqlCommand commandSql = new SqlCommand(sqlQuery, conexion.Conexion);

                foreach (DetalleDocumento aux in detalle) {

                    commandSql.Parameters.AddWithValue("@cantidadProducto", SqlDbType.Int);
                    commandSql.Parameters["@cantidadProducto"].Value = aux.CantidadProducto;

                    commandSql.Parameters.AddWithValue("@precioProducto", SqlDbType.Int);
                    commandSql.Parameters["@precioProducto"].Value = aux.PrecioProducto;

                    commandSql.Parameters.AddWithValue("@producto_id", SqlDbType.Int);
                    commandSql.Parameters["@producto_id"].Value = aux.IdProducto;

                    commandSql.Parameters.AddWithValue("@documento_id", SqlDbType.Int);
                    commandSql.Parameters["@documento_id"].Value = aux.IdDocumento;

                    commandSql.Parameters.AddWithValue("@estado", SqlDbType.SmallInt);
                    commandSql.Parameters["@estado"].Value = aux.Estado;
                    // Ejecución de query
                    int filasAfectadas = commandSql.ExecuteNonQuery();
                    

                    if (filasAfectadas > 0)
                    {
                        cantidadRegistros++;
                    }
                }


                conexion.cerrarConexion();
                return cantidadRegistros;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DetalleDocumento> consultaDDocumento(int idDocumento) {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM detalleDocumento where documento_id=@documento_id";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@documento_id", SqlDbType.Int);
                sqlData.SelectCommand.Parameters["@documento_id"].Value = idDocumento;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<DetalleDocumento> detalleD = new List<DetalleDocumento>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DetalleDocumento detalleAux = new DetalleDocumento();
                        detalleAux.CantidadProducto = int.Parse(dataTable.Rows[i]["cantidadProducto"].ToString());
                        detalleAux.PrecioProducto = int.Parse(dataTable.Rows[i]["precioProducto"].ToString());
                        detalleAux.IdProducto = int.Parse(dataTable.Rows[i]["producto_id"].ToString());
                        detalleAux.IdDocumento = int.Parse(dataTable.Rows[i]["documento_id"].ToString());
                        detalleAux.Estado = int.Parse(dataTable.Rows[i]["estado"].ToString());
                        detalleD.Add(detalleAux);
                    }
                }
                return detalleD;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
