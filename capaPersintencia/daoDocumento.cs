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
        public bool registrarDocumento(Documento nuevoDocumento, Cliente comprador) {

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

        }

        public bool modificarDocumento(Documento documentoModificar)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();

                conexion.abrirConexion();

                string sqlQueryDocumento = "UPDATE documento set subtotal=@subTotal, iva=@iva, total=@total, tipoPago=@tipoPago, cliente_id=@cliente_id, observacion=@observacion, creadoPor=@creadoPor  where folio =@folio";

                SqlCommand commandSql = new SqlCommand(sqlQueryDocumento, conexion.Conexion);

                commandSql.Parameters.AddWithValue("@subtotal", SqlDbType.VarChar);
                commandSql.Parameters["@subtotal"].Value = documentoModificar.Folio;

                commandSql.Parameters.AddWithValue("@iva", SqlDbType.VarChar);
                commandSql.Parameters["@iva"].Value = documentoModificar.Iva;

                commandSql.Parameters.AddWithValue("@total", SqlDbType.VarChar);
                commandSql.Parameters["@total"].Value = documentoModificar.Total;

                commandSql.Parameters.AddWithValue("@tipoPago", SqlDbType.VarChar);
                commandSql.Parameters["@tipoPago"].Value = documentoModificar.TipoPago;

                commandSql.Parameters.AddWithValue("@cliente_id", SqlDbType.VarChar);
                commandSql.Parameters["@cliente_id"].Value = documentoModificar.Comprador.IdCliente;

                commandSql.Parameters.AddWithValue("@observacion", SqlDbType.VarChar);
                commandSql.Parameters["@observacion"].Value = documentoModificar.Observacion;

                commandSql.Parameters.AddWithValue("@creadoPor", SqlDbType.VarChar);
                commandSql.Parameters["@creadoPor"].Value = documentoModificar.CreadoPor;


                commandSql.Parameters.AddWithValue("@folio", SqlDbType.VarChar);
                commandSql.Parameters["@folio"].Value = documentoModificar.Folio;

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

        public bool anularDocumento(string folio)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();

                conexion.abrirConexion();

                string sqlQueryDocumento = "UPDATE documento set estado = 2 where folio =@folio";

                SqlCommand commandSql = new SqlCommand(sqlQueryDocumento, conexion.Conexion);


                commandSql.Parameters.AddWithValue("@folio", SqlDbType.VarChar);
                commandSql.Parameters["@folio"].Value = folio;

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
        public List<Documento> consultarDocumento()
        {

            try
            {
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
                        daoEmpresa empresaAux = new daoEmpresa();
                        daoCliente clienteAux = new daoCliente();

                        documentoAux.Folio = dataTable.Rows[i]["folio"].ToString();
                        documentoAux.EstadoEmitido = int.Parse(dataTable.Rows[i]["estado"].ToString());
                        documentoAux.SubTotal = int.Parse(dataTable.Rows[i]["subtotal"].ToString());
                        documentoAux.Iva = int.Parse(dataTable.Rows[i]["iva"].ToString());
                        documentoAux.Total = int.Parse(dataTable.Rows[i]["total"].ToString());
                        documentoAux.TipoPago = int.Parse(dataTable.Rows[i]["tipoPago"].ToString());
                        documentoAux.Observacion = dataTable.Rows[i]["observacion"].ToString();
                        documentoAux.CreadoPor = dataTable.Rows[i]["creadoPor"].ToString();
                        documentoAux.FechaEmision = DateTime.Parse(dataTable.Rows[i]["fechaEmision"].ToString());
                        //Devuelvo también el vendedor y comprador para agregarlo al detalle de la consulta
                        documentoAux.Vendedor = empresaAux.detalleEmpresaId(int.Parse(dataTable.Rows[i]["empresa_id"].ToString()));
                        documentoAux.Comprador = clienteAux.detalleClienteId(int.Parse(dataTable.Rows[i]["cliente_id"].ToString()));

                        //Se agrega a la lista
                        documentos.Add(documentoAux);
                    }
                }
                return documentos;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public List<Documento> consultarDocumentoxUsuario( string user)
        {

            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM documento where creadoPor=@creadoPor";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);
                sqlData.SelectCommand.Parameters.Add("@creadoPor", SqlDbType.VarChar, 10).Value = user;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<Documento> documentos = new List<Documento>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Documento documentoAux = new Documento();
                        daoEmpresa empresaAux = new daoEmpresa();
                        daoCliente clienteAux = new daoCliente();

                        documentoAux.Folio = dataTable.Rows[i]["folio"].ToString();
                        documentoAux.EstadoEmitido = int.Parse(dataTable.Rows[i]["estado"].ToString());
                        documentoAux.SubTotal = int.Parse(dataTable.Rows[i]["subtotal"].ToString());
                        documentoAux.Iva = int.Parse(dataTable.Rows[i]["iva"].ToString());
                        documentoAux.Total = int.Parse(dataTable.Rows[i]["total"].ToString());
                        documentoAux.TipoPago = int.Parse(dataTable.Rows[i]["tipoPago"].ToString());
                        documentoAux.Observacion = dataTable.Rows[i]["observacion"].ToString();
                        documentoAux.CreadoPor = dataTable.Rows[i]["creadoPor"].ToString();
                        documentoAux.FechaEmision = DateTime.Parse(dataTable.Rows[i]["fechaEmision"].ToString());
                        //Devuelvo también el vendedor y comprador para agregarlo al detalle de la consulta
                        documentoAux.Vendedor = empresaAux.detalleEmpresaId(int.Parse(dataTable.Rows[i]["empresa_id"].ToString()));
                        documentoAux.Comprador = clienteAux.detalleClienteId(int.Parse(dataTable.Rows[i]["cliente_id"].ToString()));

                        //Se agrega a la lista
                        documentos.Add(documentoAux);
                    }
                }
                return documentos;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<Documento> consultarDocumentoxFecha(DateTime fInicial, DateTime fFinal)
        {

            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM documento where fechaCreacion BETWEEN @fInicial and @fFinal";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@fInicial", SqlDbType.DateTime2);
                sqlData.SelectCommand.Parameters["@fInicial"].Value = fInicial;

                sqlData.SelectCommand.Parameters.AddWithValue("@fFinal", SqlDbType.DateTime2);
                sqlData.SelectCommand.Parameters["@fFinal"].Value = fFinal;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<Documento> documentos = new List<Documento>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Documento documentoAux = new Documento();
                        daoEmpresa empresaAux = new daoEmpresa();
                        daoCliente clienteAux = new daoCliente();

                        documentoAux.Folio = dataTable.Rows[i]["folio"].ToString();
                        documentoAux.EstadoEmitido = int.Parse(dataTable.Rows[i]["estado"].ToString());
                        documentoAux.SubTotal = int.Parse(dataTable.Rows[i]["subtotal"].ToString());
                        documentoAux.Iva = int.Parse(dataTable.Rows[i]["iva"].ToString());
                        documentoAux.Total = int.Parse(dataTable.Rows[i]["total"].ToString());
                        documentoAux.TipoPago = int.Parse(dataTable.Rows[i]["tipoPago"].ToString());
                        documentoAux.Observacion = dataTable.Rows[i]["observacion"].ToString();
                        documentoAux.CreadoPor = dataTable.Rows[i]["creadoPor"].ToString();
                        documentoAux.FechaEmision = DateTime.Parse(dataTable.Rows[i]["fechaEmision"].ToString());
                        //Devuelvo también el vendedor y comprador para agregarlo al detalle de la consulta
                        documentoAux.Vendedor = empresaAux.detalleEmpresaId(int.Parse(dataTable.Rows[i]["empresa_id"].ToString()));
                        documentoAux.Comprador = clienteAux.detalleClienteId(int.Parse(dataTable.Rows[i]["cliente_id"].ToString()));

                        //Se agrega a la lista
                        documentos.Add(documentoAux);
                    }
                }
                return documentos;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
