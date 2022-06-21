using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Contacto
    {
        private int cont_Id;
        private string cont_NroDocumento;
        private string cont_TipoDocumento;
        private string cont_Apellido;
        private string cont_Nombre;
        private string cont_Telefono;
        private int cli_id;

        public Contacto()
        {

        }

        public int Cont_Id
        {
            get { return cont_Id; }
            set { cont_Id = value; }
        }

        public string Cont_NroDocumento
        {
            get { return cont_NroDocumento; }
            set { cont_NroDocumento = value; }
        }

        public string Cont_TipoDocumento
        {
            get { return cont_TipoDocumento; }
            set { cont_TipoDocumento = value; }
        }

        public string Cont_Apellido
        {
            get { return cont_Apellido; }
            set { cont_Apellido = value; }
        }

        public string Cont_Nombre
        {
            get { return cont_Nombre; }
            set { cont_Nombre = value; }
        }

        public string Cont_Telefono
        {
            get { return cont_Telefono; }
            set { cont_Telefono = value; }
        }

        public int Cli_id
        {
            get { return cli_id; }
            set { cli_id = value; }
        }
    }
}
