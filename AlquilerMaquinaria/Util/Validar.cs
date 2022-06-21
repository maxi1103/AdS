using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Util
{
    public class Validar
    {
        /// <summary>
        /// Metodo que permite ingresar solo numeros
        /// </summary>
        public static void soloNumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled == true)
                MessageBox.Show("Debe ingresar solo números", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Metodo que permite ingresar solo letras
        /// </summary>
        public static void soloLetras(KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            if (e.Handled == true)
                MessageBox.Show("Debe ingresar solo letras", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Metodo que permite ingresar solo numeros enteros o decimales
        /// </summary>
        public static void soloDecimal(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar.ToString().Equals(","));
            if (e.Handled == true)
                MessageBox.Show("Debe ingresar un número entero o decimal (separador: coma)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// RETORNA UN STRING con el nombre del rol dependiendo de un valor int
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string obtener_rol(int valor)
        {
            string rol = "";
            switch (valor)
            {
                case 1: rol = "ADMINISTRADOR"; break;
                case 2: rol = "OPERADOR"; break;
                case 3: rol = "AUDITOR"; break;
            }
            return rol;
        }

    }
}
