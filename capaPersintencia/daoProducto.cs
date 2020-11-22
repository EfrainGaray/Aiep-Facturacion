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
                             "values(@empresa_id, @nombre, @codigo , @stock , @descipcion, @precio)";

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

                commandSql.Parameters.AddWithValue("@empresa_id", SqlDbType.Int);
                commandSql.Parameters["@empresa_id"].Value = 2;

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

        public List<Producto> detalleProdutoxCodigo(string codigo) {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM producto where codigo=@codigo";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@codigo", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@codigo"].Value = codigo;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<Producto> productos = new List<Producto>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Producto productoAux = new Producto();
                        productoAux.Codigo = dataTable.Rows[i]["codigo"].ToString();
                        productoAux.Descripcion = dataTable.Rows[i]["descipcion"].ToString();
                        productoAux.Nombre = dataTable.Rows[i]["nombre"].ToString();
                        productoAux.Precio = int.Parse(dataTable.Rows[i]["precio"].ToString());
                        productoAux.Stock = int.Parse(dataTable.Rows[i]["stock"].ToString());
                        productoAux.IdProducto = int.Parse(dataTable.Rows[i]["id"].ToString());
                        productos.Add(productoAux);
                    }
                }
                return productos;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<Producto> detalleProdutoxNombre(string nombre)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM producto where nombre like '%"+nombre+"%'";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);
                /*
                sqlData.SelectCommand.Parameters.AddWithValue("@nombre", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@nombre"].Value = nombre;
  
                */
                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<Producto> productos = new List<Producto>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Producto productoAux = new Producto();
                        productoAux.Codigo = dataTable.Rows[i]["codigo"].ToString();
                        productoAux.Descripcion = dataTable.Rows[i]["descipcion"].ToString();
                        productoAux.Nombre = dataTable.Rows[i]["nombre"].ToString();
                        productoAux.Precio = int.Parse(dataTable.Rows[i]["precio"].ToString());
                        productoAux.Stock = int.Parse(dataTable.Rows[i]["stock"].ToString());
                        productoAux.IdProducto = int.Parse(dataTable.Rows[i]["id"].ToString());
                        productos.Add(productoAux);
                    }
                }
                return productos;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool productoExistente(string codigo) {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM producto where codigo= @codigo";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@codigo", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@codigo"].Value = codigo;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
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
