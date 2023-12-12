using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Programas
using DAL; //Acceso a conexion Server + BD
using System.Data; //Objetos manejadores datos
using System.Data.SqlClient; //Acceso MSSQL Server
using ENTITIES;                 //ENTIDADES 

namespace BOL
{
    public class Empresa
    {
        //La conexion de la instancia
        DBAccess conexion = new DBAccess();


        public DataTable iniciarSesion(string email)
        {
            DataTable ep = new DataTable();
            conexion.abrirConexion();

            SqlCommand comando = new SqlCommand("spu_empresas_login", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;
            ep.Load(comando.ExecuteReader());
            conexion.cerrarConexion();
            return ep;
        }
        public int Registar(EEmpresa entidad)
        {
            int RegistrarEmpresa = 0;
            SqlCommand codigo = new SqlCommand("spu_empresas_registrar", conexion.getConexion());
            codigo.CommandType = CommandType.StoredProcedure;

            //ABRIENDO LA CONEXION
            conexion.abrirConexion();

            try
            {
                codigo.Parameters.AddWithValue("@razonsocial", entidad.razon_social);
                codigo.Parameters.AddWithValue("@ruc", entidad.ruc);
                codigo.Parameters.AddWithValue("@direccion", entidad.direccion);
                codigo.Parameters.AddWithValue("@telefono", entidad.telefono);
                codigo.Parameters.AddWithValue("@email", entidad.email);
                codigo.Parameters.AddWithValue("@website", entidad.website);

                RegistrarEmpresa = codigo.ExecuteNonQuery();
            }
            catch
            {
                RegistrarEmpresa = -1;
            }
            finally
            {
                conexion.cerrarConexion();
            }
            return RegistrarEmpresa;
        }

        public DataTable Listar()
        {
            DataTable ep = new DataTable();
            SqlCommand comando = new SqlCommand("spu_empresas_listar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            conexion.abrirConexion();
            ep.Load(comando.ExecuteReader());
            conexion.cerrarConexion();

            return ep;
        }
    }
}
