using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class ControladorContacto
    {
        
        /// <summary>
        /// Buscar contacto por ID de Cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public static DataTable buscar_contacto(int idABuscar, int opcion)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarContacto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", idABuscar );
            cmd.Parameters.AddWithValue("@idContacto", idABuscar);
            cmd.Parameters.AddWithValue("@opcion", opcion);
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Listar todos los Contactos existentes
        /// </summary>
        /// <returns></returns>
        public static DataTable list_contactos()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarContacto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
