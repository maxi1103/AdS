using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ControladorCliente
    {
        /// <summary>
        /// Agregar ,  Modificar o Eliminar dependiendo la opcion 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="opcion"></param>
        public static void ABM_cliente(Cliente cliente, int opcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "abmCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idCliente", cliente.Cli_Id);
            cmd.Parameters.AddWithValue("@razonSocial", cliente.Cli_RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@codigoPostal", cliente.Cli_CodigoPostal);
            cmd.Parameters.AddWithValue("@fechaAlta", cliente.Cli_FechaAlta);
            cmd.Parameters.AddWithValue("@opcion", opcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            //string msj = Cliente.createCliente(cliente, opcion);
        }


        /// <summary>
        /// Buscar un Cliente por Razon Social, Direccion 
        /// </summary>
        /// <param name="oCliente"></param>
        /// <param name="seleccion"></param>
        /// <returns></returns>
        public static DataTable buscar_cliente(Cliente oCliente, int seleccion)
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@razonSocial", "%" + oCliente.Cli_RazonSocial + "%");
            cmd.Parameters.AddWithValue("@direccion", "%" + oCliente.Cli_Direccion + "%");
            cmd.Parameters.AddWithValue("@codigoPostal",  oCliente.Cli_CodigoPostal );
            cmd.Parameters.AddWithValue("@opcion", seleccion);
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Listar todos los Cliente existentes
        /// </summary>
        /// <returns></returns>
        public static DataTable list_clientes()
        {
            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.alquilerMaquinaria);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
