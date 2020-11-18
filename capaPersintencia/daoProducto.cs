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
    public class daoProducto
    {
        public bool registrarProducto(Producto nuevoProducto) {

            try
            {

                ConexionBD conexion = new ConexionBD();

                conexion.abrirConexion();

                string sqlQuery = "INSERT INTO producto (empresa_id, nombre, codigo, stock, descipcion, precio) " +
                             "values('1', @nombre, @codigo , @stock , @descipcion, @precio)";

                SqlCommand commandSql = new SqlCommand(sqlQuery,conexion.Conexion);


                commandSql.Parameters.AddWithValue("@nombre", SqlDbType.VarChar)  ;
                commandSql.Parameters["@nombre"].Value = nuevoProducto.Nombre;

                commandSql.Parameters.AddWithValue("@codigo", SqlDbType.VarChar);
                commandSql.Parameters["@codigo"].Value = nuevoProducto.Codigo;

                commandSql.Parameters.AddWithValue("@stock", SqlDbType.Int);
                commandSql.Parameters["@stock"].Value = nuevoProducto.Stock;

                commandSql.Parameters.AddWithValue("@descipcion", SqlDbType.VarChar);
                commandSql.Parameters["@descipcion"].Value = nuevoProducto.Descripcion;

                commandSql.Parameters.AddWithValue("@precio", SqlDbType.Int);
                commandSql.Parameters["@precio"].Value = nuevoProducto.Precio;

                //Ejecución de query
                int filasAfectadas= commandSql.ExecuteNonQuery();

                conexion.cerrarConexion();

                if (filasAfectadas > 0)
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
        public bool modificararProducto()
        {
            return false;
        }
        public bool desactivarProducto()
        {
            return false;
        }
        public bool consultarProducto()
        {
            return false;
        }
    }
}
