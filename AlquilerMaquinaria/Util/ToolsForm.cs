using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClasesBase;
namespace Util
{
    public static class ToolsForm
    {
        /// <summary>
        /// Metodo para limpiar los campos de un formulario
        /// </summary>
        public static void limpiarCampos(GroupBox group)
        {
            foreach (Control b in group.Controls)
            {
                if (b is TextBox)
                    b.Text = string.Empty;
                if (b is DateTimePicker)
                    b.Text = string.Empty;
                if (b is ComboBox)
                    b.Text = "Seleccionar";
                if (b is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)b;
                    nud.Value = nud.Minimum;
                }
            }
        }

        /// <summary>
        /// Metodo para limpiar los mostrar los errores de un formulario
        /// </summary>
        public static void mostrarErrores(Label[] notificacion, Control[] campos, Label notifFecha = null, DateTime inicio = new DateTime(), DateTime final = new DateTime())
        {
            for (int i = 0; i < campos.Length; i++)
            {
                if (campos[i].Text.Trim() == "")
                    notificacion[i].Text = " *Campo vacío";
                else
                    if (campos[i].Text.Trim() == "Seleccionar")
                        notificacion[i].Text = " *Elija una opción";
                    else { 
                        if (campos[i].Text.Trim() == "")
                            notificacion[i].Text = " *Campo vacío";
                        else
                            notificacion[i].Text = "";
                    }
                       
            }
            if (notifFecha != null)
            {
                if (final <= inicio)
                    notifFecha.Text = " *Ingrese otra fecha";
                else
                    notifFecha.Text = "";
            }

        }


        /// <summary>
        /// Los Label para mostrar error se los cambia a un texto vacio
        /// </summary>
        /// <param name="error"></param>
        public static void borrarErrores(Label[] error)
        {
            foreach (Label errores in error)
            {
                errores.Text = "";
            }
        }

        /// <summary>
        /// Metdo para generar un archivo pdf, hace uso la libreria itextsharp
        /// </summary>
        /// <param name="dgv"></param>el dataGridView que contiene la tabla con los datos 
        /// <param name="nombre"></param> el nombre del archivo 
        /// <param name="sTitulo"></param> el titulo del documento pdf
        public static void exportar_dgv_como_pdf(Alquiler alquiler, Maquinaria oMaquinaria,Cliente oCliente,Contacto oContacto)
        {
            string Titulo = "COMPROBANTE DE PAGO";
            string NombreAgencia = "NOMBRE DE LA AGENCIA";
            string cuil = "23-123456-1";
            string telefono = "4232327";
            string direccion = "San Salvador de Jujuy - B° Centro - Calle Belgrano 756";
            string fechaActual = DateTime.Now.ToShortDateString();

            //Fuentes
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);//tipo de fuente
            BaseFont fuente2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);


            //Primer tabla
            PdfPTable tabla1 = new PdfPTable(2);
            tabla1.DefaultCell.Padding = 3;
            tabla1.SpacingBefore = 10;
            tabla1.WidthPercentage = 80;
            tabla1.HorizontalAlignment = Element.ALIGN_CENTER;

            PdfPCell cCodigo = new PdfPCell(new Phrase(1, "CODIGO N°: 199132"));
            cCodigo.Border = PdfPCell.NO_BORDER;
            cCodigo.HorizontalAlignment = Element.ALIGN_LEFT;
            tabla1.AddCell(cCodigo);
            PdfPCell cFecha = new PdfPCell(new Phrase(2,"FECHA DE EMISIÓN: "+ fechaActual));
            cFecha.Border = PdfPCell.NO_BORDER;
            cFecha.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabla1.AddCell(cFecha);

            //Creacion de titulos
            Paragraph titulo = new Paragraph(string.Format(Titulo), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 26, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 100, 167)));
            titulo.Alignment = Element.ALIGN_CENTER;

            Paragraph subTitulo = new Paragraph(string.Format(NombreAgencia), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 100, 167)));
            subTitulo.Alignment = Element.ALIGN_CENTER;

            //Datos de la agencia

            Paragraph datoCuil = new Paragraph("CUIL: "+cuil, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0)));
            datoCuil.Alignment = Element.ALIGN_LEFT;

            Paragraph datoTel = new Paragraph("TELEFONO: "+ telefono, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0)));
            datoTel.Alignment = Element.ALIGN_LEFT;

            Paragraph datoDireccion = new Paragraph("DIRECCION: "+direccion, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0)));
            datoDireccion.Alignment = Element.ALIGN_LEFT;

            //Descripcion-----------------------------------------------------------------------------
            Paragraph descripcion = new Paragraph("DESCRIPCIÓN", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0)));
            descripcion.Alignment = Element.ALIGN_CENTER;
            descripcion.SpacingBefore = 5;

            PdfPTable tablaAlquiler = new PdfPTable(2);
            tablaAlquiler.DefaultCell.Padding = 3;
            tablaAlquiler.SpacingBefore = 5;
            tablaAlquiler.WidthPercentage = 100;
            //tablaAlquiler.HorizontalAlignment = Element.ALIGN_LEFT;

            PdfPCell titCod = new PdfPCell(new Phrase(1,"CODIGO-ALQUILER: "));
            titCod.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaAlquiler.AddCell(titCod);
            
            PdfPCell codigo = new PdfPCell(new Phrase(2,alquiler.Alq_Codigo));
            codigo.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaAlquiler.AddCell(codigo);

            PdfPCell titFecAlq = new PdfPCell(new Phrase(1, "FECHA DE INICIO: "));
            titFecAlq.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaAlquiler.AddCell(titFecAlq);
            PdfPCell fecAlq = new PdfPCell(new Phrase(2,Convert.ToString( alquiler.Alq_FechaAlq)));
            fecAlq.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaAlquiler.AddCell(fecAlq);

            PdfPCell titFecDev = new PdfPCell(new Phrase(1, "FECHA DE DEVOLUCIÓN: "));
            titFecDev.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaAlquiler.AddCell(titFecDev);
            PdfPCell fecDev = new PdfPCell(new Phrase(2, Convert.ToString(alquiler.Alq_FechaDev)));
            fecDev.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaAlquiler.AddCell(fecDev);

            PdfPCell titCliente = new PdfPCell(new Phrase(1, "CLIENTE: "));
            titCliente.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaAlquiler.AddCell(titCliente);
            PdfPCell cliente = new PdfPCell(new Phrase(2, oCliente.Cli_RazonSocial));
            cliente.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaAlquiler.AddCell(cliente);

            PdfPCell titContacto = new PdfPCell(new Phrase(1, "REPRESENTANTE: "));
            titContacto.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaAlquiler.AddCell(titContacto);
            PdfPCell contacto = new PdfPCell(new Phrase(2, oContacto.Cont_Apellido+", "+oContacto.Cont_Nombre));
            contacto.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaAlquiler.AddCell(contacto);

            PdfPCell titPrecio = new PdfPCell(new Phrase(1, "PRECIO ACORDADO: "));
            titPrecio.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaAlquiler.AddCell(titPrecio);
            PdfPCell precio = new PdfPCell(new Phrase(2,"$ "+ alquiler.Alq_Precio.ToString()));
            precio.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaAlquiler.AddCell(precio);

            //Descripcion de Maquinaria -----------------------------

            Paragraph descMaquinaria = new Paragraph("MAQUINARIA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0)));
            descMaquinaria.Alignment = Element.ALIGN_CENTER;
            descMaquinaria.SpacingBefore = 5;

            PdfPTable tablaMaquinaria = new PdfPTable(2);
            tablaMaquinaria.DefaultCell.Padding = 3;
            tablaMaquinaria.SpacingBefore = 5;
            tablaMaquinaria.WidthPercentage = 100;

            PdfPCell titCodMaq = new PdfPCell(new Phrase(1, "CODIGO-MAQUINARIA: "));
            titCodMaq.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaMaquinaria.AddCell(titCodMaq);

            PdfPCell codMaq = new PdfPCell(new Phrase(2, oMaquinaria.Maq_CodigoMaq));
            codMaq.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaMaquinaria.AddCell(codMaq);

            PdfPCell titMarca = new PdfPCell(new Phrase(1, "MARCA: "));
            titMarca.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaMaquinaria.AddCell(titMarca);

            PdfPCell marca = new PdfPCell(new Phrase(2, oMaquinaria.Maq_Marca));
            marca.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaMaquinaria.AddCell(marca);

            PdfPCell titModelo = new PdfPCell(new Phrase(1, "MODELO: "));
            titModelo.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaMaquinaria.AddCell(titModelo);

            PdfPCell modelo = new PdfPCell(new Phrase(2, oMaquinaria.Maq_Modelo));
            modelo.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaMaquinaria.AddCell(modelo);

            PdfPCell titTipo= new PdfPCell(new Phrase(1, "TIPO: "));
            titTipo.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaMaquinaria.AddCell(titTipo);

            PdfPCell tipo = new PdfPCell(new Phrase(2, oMaquinaria.Maq_Tipo));
            tipo.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaMaquinaria.AddCell(tipo);



            //asignamos el tipo de fuente
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL, new iTextSharp.text.BaseColor(0, 73, 121));
            iTextSharp.text.Font text2 = new iTextSharp.text.Font(fuente2, 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);

            
            //guardar el archivo
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = "COMPROBANTE DE PAGO";
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(tabla1);
                    pdfdoc.Add(titulo);
                    pdfdoc.Add(subTitulo);
                    pdfdoc.Add(datoCuil);
                    pdfdoc.Add(datoTel);
                    pdfdoc.Add(datoDireccion);
                    pdfdoc.Add(descripcion);
                    pdfdoc.Add(tablaAlquiler);
                    pdfdoc.Add(descMaquinaria);
                    pdfdoc.Add(tablaMaquinaria);
                    pdfdoc.Close();
                    stream.Close();
                }
                MessageBox.Show("SE GENERO EL ARCHIVO CORRECTAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
