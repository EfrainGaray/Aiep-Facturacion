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
    public class daoEmpresa
    {
        public bool registrarEmpresa() {
            return false;
        }
        public bool modificarEmpresa()
        {
            return false;
        }
        public bool consultarEmpresa()
        {
            return false;
        }
        public List<Empresa> detalleEmpresa(string rut)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrirConexion();
            string sql = "SELECT * FROM empresa where rut=@rut";
            SqlDataAdapter sqlData = new SqlDataAdapter(sql, conexion.Conexion);

            sqlData.SelectCommand.Parameters.AddWithValue("@rut", SqlDbType.VarChar);
            sqlData.SelectCommand.Parameters["@rut"].Value = rut;


            DataTable dataTable = new DataTable();


            sqlData.Fill(dataTable);
            conexion.cerrarConexion();
            List<Empresa> empresas = new List<Empresa>();
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                { 
                    Empresa empresaAux = new Empresa();
                    empresaAux.Rut = dataTable.Rows[i]["rut"].ToString();
                    empresaAux.RazonSocial = dataTable.Rows[i]["razonSocial"].ToString();
                    empresaAux.Giro = dataTable.Rows[i]["giro"].ToString();
                    empresaAux.Direccion = dataTable.Rows[i]["direccion"].ToString();
                    empresaAux.Email = dataTable.Rows[i]["email"].ToString();
                    empresaAux.Telefono = dataTable.Rows[i]["telefono"].ToString();
                    empresaAux.IdEmpresa= int.Parse(dataTable.Rows[i]["id"].ToString());


                    empresas.Add(empresaAux);
                }
            }
            return empresas;
        }
    }
}
