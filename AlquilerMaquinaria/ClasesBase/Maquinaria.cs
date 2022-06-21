using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Maquinaria
    {

        private int maq_Id;
        private string maq_CodigoMaq;
        private string maq_Marca;
        private string maq_Modelo;
        private string maq_Tipo;
        private DateTime maq_FechaAdquisicion;
        private decimal maq_PrecioVigente;
        private string maq_Estado;
        private int cat_Id;

        public Maquinaria()
        {

        }

        public int Maq_Id
        {
            get { return maq_Id; }
            set { maq_Id = value; }
        }

        public string Maq_CodigoMaq
        {
            get { return maq_CodigoMaq; }
            set { maq_CodigoMaq = value; }
        }

        public string Maq_Marca
        {
            get { return maq_Marca; }
            set { maq_Marca = value; }
        }

        public string Maq_Modelo
        {
            get { return maq_Modelo; }
            set { maq_Modelo = value; }
        }

        public string Maq_Tipo
        {
            get { return maq_Tipo; }
            set { maq_Tipo = value; }
        }

        public DateTime Maq_FechaAdquisicion
        {
            get { return maq_FechaAdquisicion; }
            set { maq_FechaAdquisicion = value; }
        }

        public decimal Maq_PrecioVigente
        {
            get { return maq_PrecioVigente; }
            set { maq_PrecioVigente = value; }
        }

        public string Maq_Estado
        {
            get { return maq_Estado; }
            set { maq_Estado = value; }
        }

        public int Cat_Id
        {
            get { return cat_Id; }
            set { cat_Id = value; }
        }
        

    }
    
}
