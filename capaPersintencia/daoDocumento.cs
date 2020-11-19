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
    public class daoDocumento
    {
        public bool registrarFactura(Documento nuevoDocumento, Cliente comprador) {

            try
            {
                ConexionBD conexion = new ConexionBD();

                conexion.abrirConexion();

                string sqlQueryDocumento = "INSERT INTO documento (folio, estado, subtotal, iva, total, tipoPago, cliente_id, empresa_id, tipoDocumento_id, fechaEmision, observacion, creadoPor) " +
                             "values(@folio, @estado, @subtotal, @iva, @total, @tipoPago, @cliente_id, '1', @tipoDocumento_id, @fechaEmision, @observacion, @creadoPor)";

                SqlCommand commandSql = new SqlCommand(sqlQueryDocumento, conexion.Conexion);


                commandSql.Parameters.AddWithValue("@folio", SqlDbType.VarChar);
                commandSql.Parameters["@folio"].Value = nuevoDocumento.Folio;

                commandSql.Parameters.AddWithValue("@estado", SqlDbType.SmallInt);
                commandSql.Parameters["@estado"].Value = nuevoDocumento.EstadoEmitido;

                commandSql.Parameters.AddWithValue("@subtotal", SqlDbType.Int);
                commandSql.Parameters["@subtotal"].Value = nuevoDocumento.SubTotal;

                commandSql.Parameters.AddWithValue("@iva", SqlDbType.Int);
                commandSql.Parameters["@iva"].Value = nuevoDocumento.Iva;

                commandSql.Parameters.AddWithValue("@total", SqlDbType.Int);
                commandSql.Parameters["@total"].Value = nuevoDocumento.Total;

                commandSql.Parameters.AddWithValue("@tipoPago", SqlDbType.SmallInt);
                commandSql.Parameters["@tipoPago"].Value = nuevoDocumento.TipoPago;

                commandSql.Parameters.AddWithValue("@fechaEmision", SqlDbType.DateTime2);
                commandSql.Parameters["@fechaEmision"].Value = nuevoDocumento.FechaEmision;

                commandSql.Parameters.AddWithValue("@observacion", SqlDbType.VarChar);
                commandSql.Parameters["@observacion"].Value = nuevoDocumento.Observacion;

                commandSql.Parameters.AddWithValue("@creadoPor", SqlDbType.VarChar);
                commandSql.Parameters["@creadoPor"].Value = nuevoDocumento.CreadoPor;

                //ID de relacionados al documento
                commandSql.Parameters.AddWithValue("@cliente_id", SqlDbType.Int);
                commandSql.Parameters["@cliente_id"].Value = comprador.IdCliente;

              
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

            return false;
        }

        public bool modificarFactura()
        {
            return false;
        }

        public bool anularFactura()
        {
            return false;
        }
        public List<Documento> consultarFactura()
        {/*
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string sql = "SELECT * FROM documento";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);




            DataTable dataTable = new DataTable();


            sqlData.Fill(dataTable);
            conexion.cerrarConexion();
            List<Documento> documentos = new List<Documento>();
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Documento documentoAux = new Documento();
                    documentoAux. = int.Parse(dataTable.Rows[i]["cantidadProducto"].ToString());
                    documentoAux.PrecioProducto = int.Parse(dataTable.Rows[i]["precioProducto"].ToString());
                    documentoAux.IdProducto = int.Parse(dataTable.Rows[i]["producto_id"].ToString());
                    documentoAux.IdDocumento = int.Parse(dataTable.Rows[i]["documento_id"].ToString());
                    documentoAux.Estado = int.Parse(dataTable.Rows[i]["estado"].ToString());
                    documentos.Add(documentoAux);
                }
            }
            return documentos;*/
                return null;
        }
    }
}
