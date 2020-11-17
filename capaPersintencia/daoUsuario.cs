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
    public class daoUsuario
    {
    
        Usuario user = new Usuario();
        public List<Usuario>  GetUsuarios() {
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string sql = "SELECT * FROM usuario";
            DataTable dataTable = new DataTable();

            SqlDataAdapter sqlData = new SqlDataAdapter(sql,conexion.Conexion);
            sqlData.Fill(dataTable);
            conexion.cerrarConexion();
            List<Usuario> usuarios = new List<Usuario>();
            if (dataTable.Rows.Count>0){
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Usuario usuario = new Usuario();
                    usuario.User = dataTable.Rows[i]["usuario"].ToString();
                    usuario.Password = dataTable.Rows[i]["password"].ToString();
                    usuarios.Add(usuario);
                }
            }
            return usuarios;
        }

    }
   
}
