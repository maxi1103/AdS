using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class ControladorMaquinaria
    {
        /// <summary>
        /// Agregar ,  Modificar o Eliminar dependiendo la opcion
        /// </summary>
        /// <param name="maquinaria"></param>
        /// <param name="opcion"></param>
        public static void ABM_maquinaria(Maquinaria maquinaria, int opcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "abmMaquinaria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idMaquinaria", maquinaria.Maq_Id);
            cmd.Parameters.AddWithValue("@codigo", maquinaria.Maq_CodigoMaq);
            cmd.Parameters.AddWithValue("@marca", maquinaria.Maq_Marca);
            cmd.Parameters.AddWithValue("@modelo", maquinaria.Maq_Modelo);
            cmd.Parameters.AddWithValue("@tipo", maquinaria.Maq_Tipo);
            cmd.Parameters.AddWithValue("@fecha", maquinaria.Maq_FechaAdquisicion);
            cmd.Parameters.AddWithValue("@precio", maquinaria.Maq_PrecioVigente);
            cmd.Parameters.AddWithValue("@estado", maquinaria.Maq_Estado);
            cmd.Parameters.AddWithValue("@opcion", opcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        /// <summary>
        /// Buscar una Maquinaria por tipo (1), marca(2), modelo(3)
        /// </summary>
        /// <param name="oMaquinaria"></param>
        /// <param name="seleccion"></param>
        /// <returns></returns>
        public static DataTable buscar_maquinaria(Maquinaria oMaquinaria, int seleccion)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarMaquinaria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@marca", "%" + oMaquinaria.Maq_Marca + "%");
            cmd.Parameters.AddWithValue("@modelo", "%" + oMaquinaria.Maq_Modelo + "%");
            cmd.Parameters.AddWithValue("@tipo", "%"+oMaquinaria.Maq_Tipo+"%");
            cmd.Parameters.AddWithValue("@codigo", "%" + oMaquinaria.Maq_CodigoMaq + "%");
            cmd.Parameters.AddWithValue("@opcion", seleccion);
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Listar todos los Maquinaria existentes
        /// </summary>
        /// <returns></returns>
        public static DataTable list_maquinarias()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarMaquinaria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Listar todos los Maquinaria disponibles
        /// </summary>
        /// <returns></returns>
        public static DataTable list_maquinariasDisponibles()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listaMaqDisponibles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void actualizar_estado(string estado, int idMaquinaria)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "abmMaquinaria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idMaquinaria", idMaquinaria);
            cmd.Parameters.AddWithValue("@estado", estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
