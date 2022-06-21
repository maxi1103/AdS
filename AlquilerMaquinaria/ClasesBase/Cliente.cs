using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class Cliente
    {
        private int cli_Id;
        private string cli_RazonSocial;
        private string cli_Direccion;
        private int cli_CodigoPostal;        
        private DateTime cli_FechaAlta;
        //private string cli_Id_contacto;


        public Cliente()
        {

        }

       
        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }

        public string Cli_RazonSocial
        {
            get { return cli_RazonSocial; }
            set { cli_RazonSocial = value; }
        }

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }

        public int Cli_CodigoPostal
        {
            get { return cli_CodigoPostal; }
            set { cli_CodigoPostal = value; }
        }

        public DateTime Cli_FechaAlta
        {
            get { return cli_FechaAlta; }
            set { cli_FechaAlta = value; }
        }

        //public string Cli_Id_contacto
        //{
        //    get { return cli_Id_contacto; }
        //    set { cli_Id_contacto = value; }
        //}

        public static string createCliente(Cliente cliente,int opcion ){
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
            return "Cliente registrado correctamente";  
        }
    }
}
