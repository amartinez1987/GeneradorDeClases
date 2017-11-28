using GeneradorClases.Entity.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Controller
{
    public class GenerarFormulariosDevExpress
    {
        public void generarFormularioAscx(List<DatosColumna> lDct, string direccionDestino, string nombreTablaAClase, string nombreProyecto)
        {

            if (!Directory.Exists(direccionDestino))
            {
                System.IO.Directory.CreateDirectory(direccionDestino);
            }

            string directorioModelo = direccionDestino + "\\ASCX";
            string nombreClaseViewModel = getNombreClase(nombreTablaAClase);
            List<string> lineasDocumento = new List<string>();

            lineasDocumento.Add(string.Format("<%@ Control Language=\"C#\" AutoEventWireup=\"true\" CodeBehind=\"frm{0}.ascx.cs\" Inherits=\"{1}.frm{0}\" %>", nombreTablaAClase, nombreProyecto));
            lineasDocumento.Add("<%@ Register Assembly=\"DevExpress.Web.v13.2, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\" Namespace=\"DevExpress.Web.ASPxEditors\" TagPrefix=\"dx\" %>");
            lineasDocumento.Add("<%@ Register Assembly=\"DevExpress.Web.v13.2, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\" Namespace=\"DevExpress.Web.ASPxPopupControl\" TagPrefix=\"dx\" %>");
            lineasDocumento.Add("<%@ Register Assembly=\"DevExpress.Web.v13.2, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\" Namespace=\"DevExpress.Web.ASPxUploadControl\" TagPrefix=\"dx\" %>");
            lineasDocumento.Add("<%@ Register Assembly=\"DevExpress.Web.v13.2, Version=13.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\" Namespace=\"DevExpress.Web.ASPxHiddenField\" TagPrefix=\"dx\" %>");
            lineasDocumento.Add("<script src=\"\"></script>");
            lineasDocumento.Add("");
            foreach (DatosColumna item in lDct)
            {
                ControlesDevExpress cdx = (item.tipoControl as ControlesDevExpress); 
                switch (cdx.nombre)
                {
                    case "ASPxComboBox":
                        lineasDocumento.Add(string.Format( "<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">",item.nombreColumna));
                        lineasDocumento.Add("</dx:ASPxLabel>");
                        lineasDocumento.Add(string.Format( "<dx:ASPxComboBox ID=\"cmb{0}\" runat=\"server\" Theme=\"Moderno\" Width=\"100%\" ClientInstanceName=\"cmb{0}\" DropDownRows=\"1\">",item.nombreColumna));
                        lineasDocumento.Add(string.Format("</dx:ASPxComboBox>"));                                                
                        break;

                    case "ASPxSpinEdit":
                        lineasDocumento.Add(string.Format( "<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">",item.nombreColumna));
                        lineasDocumento.Add("</dx:ASPxLabel>");
                        lineasDocumento.Add(string.Format("<dx:ASPxSpinEdit ID=\"txt{0}\" ClientInstanceName=\"txt{0}\" Width=\"100%\" runat=\"server\" Number=\"0\">", item.nombreColumna));
                        if (!cdx.sinSpinButton)
                        {
                            lineasDocumento.Add("<SpinButtons ShowIncrementButtons=\"False\">");
                            lineasDocumento.Add("</SpinButtons>");
                        }
                        lineasDocumento.Add("</dx:ASPxSpinEdit>");
                        break;

                    case "ASPxTextBox":
                        lineasDocumento.Add(string.Format( "<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">",item.nombreColumna));
                        lineasDocumento.Add("</dx:ASPxLabel>");
                        lineasDocumento.Add(string.Format( "<dx:ASPxTextBox ID=\"txt{0}\" ClientInstanceName=\"txt{0}\" runat=\"server\" Width=\"100%\">",item.nombreColumna));
                        lineasDocumento.Add("</dx:ASPxTextBox>");
                        break;

                    case "ASPxDateEdit":
                        lineasDocumento.Add(string.Format( "<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">",item.nombreColumna));
                        lineasDocumento.Add("</dx:ASPxLabel>");
                        lineasDocumento.Add(string.Format( "<dx:ASPxDateEdit ID=\"txt{0}\" ClientInstanceName=\"txt{0}\" Width=\"100%\" {1} runat=\"server\">",item.nombreColumna, cdx.formatoFecha != ""? "DisplayFormatString=\"yyyy/MM/dd\" UseMaskBehavior=\"True\" EditFormat=\"Custom\" ":"" ));
                        lineasDocumento.Add("</dx:ASPxDateEdit>");
                        
                        break;

                    case "ASPxCheckBox":
                        break;

                    case "ASPxRadioButton":
                        break;

                    case "ASPxCheckBoxList":
                        break;

                    case "ASPxRadioButtonList":
                        break;

                    case "ASPxListBox":
                        break;

                    case "ASPxTimeEdit":
                        break;

                    case "ASPxUploadControl":
                        break;

                    case "ASPxButtonEdit":
                        break;

                    case "ASPxMemo":
                        break;
                }

            }
            lineasDocumento.Add("");
            lineasDocumento.Add("");
            lineasDocumento.Add("");
            lineasDocumento.Add("");
            if (!Directory.Exists(directorioModelo))
            {
                System.IO.Directory.CreateDirectory(directorioModelo);
            }

            File.WriteAllLines(directorioModelo + "\\" + nombreClaseViewModel + ".ascx", lineasDocumento);

        }

        private static string getNombreClase(string nombreTablasAClase)
        {
            string caracterInicial = nombreTablasAClase.Remove(0).ToUpper();
            return caracterInicial + nombreTablasAClase + "ViewModel";

        }
    }
}
