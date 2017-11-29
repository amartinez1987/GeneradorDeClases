using GeneradorClases.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Controller
{
    public class MetodosGeneralesController
    {
        public static List<vSysDataBaseViewModel> getListaBaseDatos(string nombreServidor, string nombreUsuario, string contrasena, ref string error)
        {
            string cadenaConeccion = string.Format("Data Source={0};Initial Catalog=master;Persist Security Info=True;User ID={1};Password={2}", nombreServidor, nombreUsuario, contrasena);
            using (SqlConnection con = new SqlConnection(cadenaConeccion))
            {
                try
                {
                    con.Open();
                    con.Close();
                    return vSysDataBaseController.getListConeccionesServidor();
                }
                catch (Exception ex)
                {
                    error = "No se puede Realizar Conección con el servidor de Base datos " + ex.Message;
                    return new List<vSysDataBaseViewModel>();
                }
            }
        }

        public static List<string> getListaTablasBaseDatos(string nombreServidor, string baseDatos, string nombreUsuario, string contrasena, ref string error)
        {
            string cadenaConeccion = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", nombreServidor, baseDatos, nombreUsuario, contrasena);
            List<string> listaTablas = new List<string>();
            using (SqlConnection con = new SqlConnection(cadenaConeccion))
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(string.Format("select name from  {0}.sys.objects where type = 'u' order by name", baseDatos), con);
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        listaTablas.Add(reader["name"].ToString());
                    }
                    con.Close();

                    return listaTablas;
                }
                catch (Exception ex)
                {
                    error = "No se puede Realizar Conección con el servidor de Base datos " + ex.Message;
                    return new List<string>();
                }
            }
        }

        internal static List<DatosColumna> getColumnasTablaBaseDato(string nombreServidor, string baseDatos, string nombreUsuario, string contrasena, string tabla, ref string error, string lenguaje = "")
        {
            string cadenaConeccion = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", nombreServidor, baseDatos, nombreUsuario, contrasena);
            List<DatosColumna> listaDatosColumna = new List<DatosColumna>();
            using (SqlConnection con = new SqlConnection(cadenaConeccion))
            {
                try
                {
                    con.Open();
                    SqlCommand comand = new SqlCommand(string.Format("select syscolumns.name AS nombreColumna , systypes.name AS tipoDatoColumna , syscolumns.isnullable  as esNulable FROM     {0}.dbo.syscolumns INNER JOIN {0}.dbo.sysobjects ON syscolumns.id = sysobjects.id INNER JOIN {0}.dbo.systypes ON systypes.xtype = syscolumns.xtype where  sysobjects.name = '{1}'", baseDatos, tabla), con);
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        DatosColumna dtC = new DatosColumna();
                        dtC.nombreColumna = reader["nombreColumna"].ToString();
                        dtC.tipoDatoColumna = reader["tipoDatoColumna"].ToString();
                        dtC.esNulable = reader["esNulable"].ToString();
                        if(lenguaje !=null?true:false )
                        {
                            dtC.tipoControl = (getTipoControl( dtC.tipoDatoColumna, lenguaje, dtC.nombreColumna ) as Control);
                            dtC.tipoControlId = dtC.tipoControl.id;
                        }
                        listaDatosColumna.Add(dtC);
                    }
                    con.Close();

                    return listaDatosColumna;
                }
                catch (Exception ex)
                {
                    error = "No se puede Realizar Conección con el servidor de Base datos " + ex.Message;
                    return new List<DatosColumna>();
                }
            }
        }

        private static Control getTipoControl(string tipoDatoColumna = "", string lenguaje="", string nombreAtributo ="")
        {
            switch (lenguaje)
            {
                case ".net + DevExpress":
                    return    GenerarFormulariosDevExpress.getControlesDevExprex(tipoDatoColumna, nombreAtributo);
                    break;
                default:
                    return null;
                    break;
            }
        }

      

        internal static List<Control> getElementosDevExpres()
        {
         

            List<Control> lElement = new List<Control>();
            Control cdx = new Control_ASPxComboBox();
            cdx.id = 0;            
            cdx.nombre = "ASPxComboBox";
            lElement.Add(cdx);

            cdx = new Control_ASPxSpinEdit();
            cdx.id = 1;            
            cdx.nombre = "ASPxSpinEdit";
            lElement.Add(cdx);

            cdx = new Control_ASPxTextBox();
            cdx.id = 2;            
            cdx.nombre = "ASPxTextBox";
            lElement.Add(cdx);

            cdx = new Control_ASPxDateEdit();
            cdx.id = 3;            
            cdx.nombre = "ASPxDateEdit";
            lElement.Add(cdx);

            cdx = new Control_ASPxCheckBox();
            cdx.id = 4;            
            cdx.nombre = "ASPxCheckBox";
            lElement.Add(cdx);

            cdx = new Control_ASPxRadioButton();
            cdx.id = 5;            
            cdx.nombre = "ASPxRadioButton";
            lElement.Add(cdx);

            cdx = new Control_ASPxCheckBoxList();
            cdx.id = 6;            
            cdx.nombre = "ASPxCheckBoxList";
            lElement.Add(cdx);

            cdx = new Control_ASPxRadioButtonList();
            cdx.id = 7;            
            cdx.nombre = "ASPxRadioButtonList";
            lElement.Add(cdx);

            cdx = new Control_ASPxListBox();
            cdx.id = 8;            
            cdx.nombre = "ASPxListBox";
            lElement.Add(cdx);

            cdx = new Control_ASPxTimeEdit();
            cdx.id = 9;            
            cdx.nombre = "ASPxTimeEdit";
            lElement.Add(cdx);

            cdx = new Control_ASPxUploadControl();
            cdx.id = 11;            
            cdx.nombre = "ASPxUploadControl";
            lElement.Add(cdx);

            cdx = new Control_ASPxButtonEdit();
            cdx.id = 12;            
            cdx.nombre = "ASPxButtonEdit";
            lElement.Add(cdx);

            cdx = new Control_ASPxMemo();
            cdx.id = 13;            
            cdx.nombre = "ASPxMemo";
            lElement.Add(cdx);

            return lElement;
        }
    }
}
