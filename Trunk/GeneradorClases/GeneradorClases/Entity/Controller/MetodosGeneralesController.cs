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

                    return vSysDataBaseController.getListConeccionesServidor();
                }
                catch (Exception ex)
                {
                    error = "No se puede Realizar Conección con el servidor de Base datos " + ex.Message;
                    return new List<vSysDataBaseViewModel>();
                }
            }
        }
    }
}
