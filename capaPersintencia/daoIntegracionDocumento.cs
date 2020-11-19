﻿using System;
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
                    tDocumentoAux.IdDetalle = int.Parse(dataTable.Rows[i]["id"].ToString());


                    tipoDocumentos.Add(tDocumentoAux);
                }
            }
            return tipoDocumentos;
        }

        //Ingresar y obtener detalle del documento
        public bool ingresarDetalle()
        {

            try
            {

                ConexionBD conexion = new ConexionBD();

                conexion.abrirConexion();

                string sqlQuery = "INSERT INTO detalleDocumento (empresa_id, nombre, codigo, stock, descipcion, precio) " +
                             "values('1', @nombre, @codigo , @stock , @descipcion, @precio)";

                SqlCommand commandSql = new SqlCommand(sqlQuery, conexion.Conexion);


                commandSql.Parameters.AddWithValue("@nombre", SqlDbType.VarChar);
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
    }
}