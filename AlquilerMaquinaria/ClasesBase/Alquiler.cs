using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Alquiler
    {
        private int alq_Id;
        private string alq_Codigo;
        private DateTime alq_FechaAlq;
        private DateTime alq_FechaDev;
        private decimal alq_Precio;
        private int cli_Id;
        private int maq_Id;

        public Alquiler()
        {

        }

        public int Alq_Id
        {
            get { return alq_Id; }
            set { alq_Id = value; }
        }
        public string Alq_Codigo
        {
            get { return alq_Codigo; }
            set { alq_Codigo = value; }
        }
        public DateTime Alq_FechaAlq
        {
            get { return alq_FechaAlq; }
            set { alq_FechaAlq = value; }
        }
        public DateTime Alq_FechaDev
        {
            get { return alq_FechaDev; }
            set { alq_FechaDev = value; }
        }
        public decimal Alq_Precio
        {
            get { return alq_Precio; }
            set { alq_Precio = value; }
        }
        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        public int Maq_Id
        {
            get { return maq_Id; }
            set { maq_Id = value; }
        }
        
    }
}
