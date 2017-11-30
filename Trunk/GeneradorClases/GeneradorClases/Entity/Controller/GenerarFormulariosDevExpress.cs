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
        public static Control getControlesDevExprex(string tipoDatoColumna = "", string nombreAtributo = "")
        {
            switch (tipoDatoColumna)
            {

                case "decimal":
                case "money":
                case "numeric":
                case "smallint":
                case "tinyint":
                case "int":
                case "float":
                case "real":
                case "bigint":
                    return new Control_ASPxDateEdit(nombreAtributo);
                    break;
                case "ntext":
                case "nvarchar":
                case "char":
                case "nchar":
                case "varchar":
                    return new Control_ASPxComboBox(nombreAtributo);
                    break;
                case "datetime":
                    return new Control_ASPxDateEdit(nombreAtributo);
                    break;
                case "bit":
                    return new Control_ASPxCheckBox(nombreAtributo);
                    break;
                default:
                    return null;
                    break;

            }
        }

        public static Control getControlDevExprex(int tipoControlId, Control tipoControl)
        {
            switch (tipoControlId)
            {
                case 0:
                    return new Control_ASPxComboBox() { dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 1:
                    return new Control_ASPxSpinEdit() { dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 2:
                    return new Control_ASPxTextBox() { dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 3:
                    return new Control_ASPxDateEdit(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 4:
                    return new Control_ASPxCheckBox(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 5:
                    return new Control_ASPxRadioButton(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 6:
                    return new Control_ASPxCheckBoxList(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 7:
                    return new Control_ASPxRadioButtonList(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 8:
                    return new Control_ASPxListBox(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 9:
                    return new Control_ASPxTimeEdit(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 10:
                    return new Control_ASPxUploadControl(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 11:
                    return new Control_ASPxButtonEdit(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;
                case 12:
                    return new Control_ASPxMemo(){dataSource = tipoControl.dataSource, formatoFecha = tipoControl.formatoFecha, nombreAtributo = tipoControl.nombre, sinSpinButton = tipoControl.sinSpinButton, tabla = tipoControl.tabla, textField = tipoControl.tabla, valueField = tipoControl.valueField };
                    break;                
                default:
                    return null;
                    break;
            }
        
        }

        public static void generarFormularioAscx(List<DatosColumna> lDct, string direccionDestino, string nombreTablaAClase, string nombreProyecto)
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
                Control cdx = (item.tipoControl as Control);
                string nombreAtributo = getInicialMayuscula(item.nombreColumna);
                switch (cdx != null ? cdx.nombre : "")
                {
                    case "ASPxComboBox":
                        lineasDocumento.AddRange(new Control_ASPxComboBox(nombreAtributo, cdx.tabla, cdx.textField, cdx.valueField).GetCodeAspxForm());
                        break;

                    case "ASPxSpinEdit":
                        lineasDocumento.AddRange(new Control_ASPxSpinEdit(nombreAtributo, cdx.sinSpinButton).GetCodeBehindForm());
                        break;

                    case "ASPxTextBox":
                        lineasDocumento.AddRange(new Control_ASPxTextBox(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxDateEdit":
                        lineasDocumento.AddRange(new Control_ASPxDateEdit(nombreAtributo, cdx.formatoFecha).GetCodeBehindForm());
                        break;

                    case "ASPxCheckBox":
                        lineasDocumento.AddRange(new Control_ASPxCheckBox(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxRadioButton":
                        lineasDocumento.AddRange(new Control_ASPxRadioButton(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxCheckBoxList":
                        lineasDocumento.AddRange(new Control_ASPxRadioButtonList(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxRadioButtonList":
                        lineasDocumento.AddRange(new Control_ASPxRadioButtonList(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxListBox":
                        lineasDocumento.AddRange(new Control_ASPxRadioButtonList(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxTimeEdit":
                        lineasDocumento.AddRange(new Control_ASPxTimeEdit(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxUploadControl":
                        lineasDocumento.AddRange(new Control_ASPxUploadControl(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxButtonEdit":
                        lineasDocumento.AddRange(new Control_ASPxButtonEdit(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxMemo":
                        lineasDocumento.AddRange(new Control_ASPxMemo(nombreAtributo).GetCodeBehindForm());
                        break;
                }

            }
            lineasDocumento.Add("");
            if (!Directory.Exists(directorioModelo))
            {
                System.IO.Directory.CreateDirectory(directorioModelo);
            }

            File.WriteAllLines(directorioModelo + "\\" + nombreClaseViewModel + ".ascx", lineasDocumento);

        }

        public static void generarFormularioAscxCs(List<DatosColumna> lDct, string direccionDestino, string nombreTablaAClase, string nombreProyecto)
        {

            if (!Directory.Exists(direccionDestino))
            {
                System.IO.Directory.CreateDirectory(direccionDestino);
            }

            string directorioModelo = direccionDestino + "\\ASCX";
            string nombreClaseViewModel = getNombreClase(nombreTablaAClase);
            List<string> lineasDocumento = new List<string>();

            lineasDocumento.Add(string.Format("using System;"));
            lineasDocumento.Add(string.Format("using System.Collections.Generic;"));
            lineasDocumento.Add(string.Format("using System.Configuration;"));
            lineasDocumento.Add(string.Format("using System.IO;"));
            lineasDocumento.Add(string.Format("using System.Linq;"));
            lineasDocumento.Add(string.Format("using System.Net;"));
            lineasDocumento.Add(string.Format("using System.Web;"));
            lineasDocumento.Add(string.Format("using System.Web.UI;"));
            lineasDocumento.Add(string.Format("using System.Web.UI.WebControls;"));
            lineasDocumento.Add(string.Format("using System.Web.UI.WebControls;"));
            lineasDocumento.Add(string.Format("namespace {0}.frm{0}", nombreProyecto, nombreTablaAClase));
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("public partial class frm{0} : System.Web.UI.UserControl", nombreTablaAClase));
            lineasDocumento.Add("{");
            foreach (DatosColumna item in lDct)
            {
                Control cdx = (item.tipoControl as Control);
                string nombreAtributo = getInicialMayuscula(item.nombreColumna);
                switch (cdx != null ? cdx.nombre : "")
                {
                    case "ASPxComboBox":
                        lineasDocumento.AddRange(new Control_ASPxComboBox(nombreAtributo, cdx.tabla, cdx.textField, cdx.valueField).GetCodeBehindForm());

                        break;

                    case "ASPxSpinEdit":
                        lineasDocumento.AddRange(new Control_ASPxSpinEdit(nombreAtributo, cdx.sinSpinButton).GetCodeBehindForm());
                        break;

                    case "ASPxTextBox":
                        lineasDocumento.AddRange(new Control_ASPxTextBox(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxDateEdit":
                        lineasDocumento.AddRange(new Control_ASPxDateEdit(nombreAtributo, cdx.formatoFecha).GetCodeBehindForm());
                        break;

                    case "ASPxCheckBox":
                        lineasDocumento.AddRange(new Control_ASPxCheckBox(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxRadioButton":
                        lineasDocumento.AddRange(new Control_ASPxRadioButton(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxCheckBoxList":
                        lineasDocumento.AddRange(new Control_ASPxCheckBoxList(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxRadioButtonList":
                        lineasDocumento.AddRange(new Control_ASPxRadioButtonList(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxListBox":
                        lineasDocumento.AddRange(new Control_ASPxListBox(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxTimeEdit":
                        lineasDocumento.AddRange(new Control_ASPxTimeEdit(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxUploadControl":
                        lineasDocumento.AddRange(new Control_ASPxUploadControl(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxButtonEdit":
                        lineasDocumento.AddRange(new Control_ASPxButtonEdit(nombreAtributo).GetCodeBehindForm());
                        break;

                    case "ASPxMemo":
                        lineasDocumento.AddRange(new Control_ASPxMemo(nombreAtributo).GetCodeBehindForm());
                        break;
                }

            }
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");

            lineasDocumento.Add("");
            if (!Directory.Exists(directorioModelo))
            {
                System.IO.Directory.CreateDirectory(directorioModelo);
            }

            File.WriteAllLines(directorioModelo + "\\" + nombreClaseViewModel + ".ascx.cs", lineasDocumento);

        }

        private static string getNombreClase(string nombreTablasAClase)
        {
            string caracterInicial = nombreTablasAClase.Remove(0).ToUpper();
            return "frm" + caracterInicial + nombreTablasAClase;

        }


        private static string getInicialMayuscula(string frase)
        {
            string caracterInicial = frase.Remove(0).ToUpper();
            return caracterInicial + frase;

        }
    }
}
