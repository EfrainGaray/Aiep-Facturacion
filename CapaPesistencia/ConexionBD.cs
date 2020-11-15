﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaPesistencia
{
    public class ConexionBD
    {
        private string cadenaConexion=@"";
        private SqlConnection conexion = null;

        public ConexionBD() {
            cadenaConexion= ConfigurationManager
        }

        public SqlConnection Conexion { get => conexion; }

        public void abrirConexion() {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed) {
                    conexion.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
