using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class DBAccess
    {
        //Objeto conexion
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["AccesoTiendaNET"].ConnectionString);

        //Metodos
        public SqlConnection getConexion()
        {
            return this.conexion;
        }

        public void abrirConexion()
        {
            if(this.conexion.State == ConnectionState.Closed)
            {
                this.conexion.Open();
            }
        }

        public void cerrarConexion()
        {
            if(this.conexion.State == ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }

        /// <summary>
        /// Metodo general que retorna una coleccion de datos de una consulta
        /// que no tiene valores de entrada
        /// </summary>
        /// <param name="spu">Nombre del procedimiento almacenado</param>
        /// <returns>
        /// Colección de datos de tipo DataTable
        /// </returns>
        public DataTable listarDatos(string spu)
        {
            DataTable dt = new DataTable();
            this.abrirConexion();
            SqlCommand comando = new SqlCommand(spu, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            dt.Load(comando.ExecuteReader());
            this.cerrarConexion();
            return dt;
        }

        public DataTable listarDatosVariable(string spu, string nombreVariable, object valorVariable)
        {
            DataTable dt = new DataTable();
            this.abrirConexion();
            SqlCommand comando = new SqlCommand(spu, this.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            //AGREGAR PARAMETRO DE ENTRADA (VARIABLE)
            comando.Parameters.AddWithValue(nombreVariable,valorVariable);

            dt.Load(comando.ExecuteReader());
            this.cerrarConexion();
            return dt;
        }
    }
}