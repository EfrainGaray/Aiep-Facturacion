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
    public class daoUsuario
    {
    
        Usuario user = new Usuario();
        public List<Usuario>  GetUsuarios(string user) {
            try
            {
                ConexionBD conexion = new ConexionBD();
                conexion.abrirConexion();
                string sql = "SELECT * FROM usuario where usuario=@usuario";
                SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

                sqlData.SelectCommand.Parameters.AddWithValue("@usuario", SqlDbType.VarChar);
                sqlData.SelectCommand.Parameters["@usuario"].Value = user;


                DataTable dataTable = new DataTable();


                sqlData.Fill(dataTable);
                conexion.cerrarConexion();
                List<Usuario> usuarios = new List<Usuario>();
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        Usuario usuario = new Usuario();
                        usuario.User = dataTable.Rows[i]["usuario"].ToString();
                        usuario.Password = dataTable.Rows[i]["password"].ToString();
                        usuario.IdEmpresa = int.Parse(dataTable.Rows[i]["id_empresa"].ToString());
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

    }
   
}
