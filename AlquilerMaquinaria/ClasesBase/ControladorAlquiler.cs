using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class ControladorAlquiler
    {
        /// <summary>
        /// Registro de un alquiler
        /// </summary>
        /// <param name="alquiler"></param>
        public static void registrar_alquiler(Alquiler alquiler)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "registrarAlquiler";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            
            cmd.Parameters.AddWithValue("@codigo", alquiler.Alq_Codigo);
            cmd.Parameters.AddWithValue("@fechaAlq", alquiler.Alq_FechaAlq);
            cmd.Parameters.AddWithValue("@fechaDev", alquiler.Alq_FechaDev);
            cmd.Parameters.AddWithValue("@precio", alquiler.Alq_Precio);
            cmd.Parameters.AddWithValue("@idMaq", alquiler.Maq_Id);
            cmd.Parameters.AddWithValue("@idCli", alquiler.Cli_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Busqueda de un alquiler
        /// </summary>
        /// <param name="alquiler"></param>
        public static DataTable buscar_alquiler(int idMaq)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarAlquiler";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idMaq", idMaq);
            //cmd.Parameters.AddWithValue("@fechaDesde", alquiler.Alq_FechaAlq);
            //cmd.Parameters.AddWithValue("@fechaHasta", alquiler.Alq_FechaDev);
    //        SELECT * 
    //        FROM Alquiler
    //        WHERE( (maq_id = @idMaq) 
    //        AND (CAST(@fechaDesde AS DATE) BETWEEN CAST(alq_fechaAlq AS DATE) AND CAST(alq_fechaDev AS DATE)) )
    //        OR
    //        ((maq_id = @idMaq) AND (CAST(@fechaHasta AS DATE) BETWEEN CAST(alq_fechaAlq AS DATE) AND CAST(alq_fechaDev AS DATE)) )
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
