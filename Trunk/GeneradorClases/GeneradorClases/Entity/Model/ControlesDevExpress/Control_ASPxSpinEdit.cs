using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxSpinEdit:Control
    {
        private const string alias = "txt";
        public string nombreAtributo { get; set; }
        
        public Control_ASPxSpinEdit(string nombreAtributo, bool sinSpinButton = false)
        {
            this.id = 1;
            this.nombre = "ASPxSpinEdit";
            this.nombreAtributo = nombreAtributo;
            this.sinSpinButton = sinSpinButton;
        }

        public Control_ASPxSpinEdit()
        {
            // TODO: Complete member initialization
            this.id = 1;
            this.nombre = "ASPxSpinEdit";
        }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();

            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxLabel getlbl{0}", nombreAtributo));
            lineasDocumento.Add("{");
            lineasDocumento.Add("get");
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("return lbl{0};", nombreAtributo));
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxSpinEdit get{1}{0}()", nombreAtributo, alias));
            lineasDocumento.Add("{");
            lineasDocumento.Add("get");
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("return {1}{0};", nombreAtributo, alias));
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");

            return lineasDocumento;
        }


        public List<string> GetCodeAspxForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("<dx:ASPxLabel ID=\"lbl{0}\" runat=\"server\" ClientInstanceName=\"lbl{0}\" Text=\"{0}\" Theme=\"Moderno\">", nombreAtributo));
            lineasDocumento.Add("</dx:ASPxLabel>");
            lineasDocumento.Add(string.Format("<dx:ASPxSpinEdit ID=\"{1}{0}\" ClientInstanceName=\"{1}{0}\" Width=\"100%\" runat=\"server\" Number=\"0\">", nombreAtributo, alias));
            if (!sinSpinButton)
            {
                lineasDocumento.Add("<SpinButtons ShowIncrementButtons=\"False\">");
                lineasDocumento.Add("</SpinButtons>");
            }
            lineasDocumento.Add("</dx:ASPxSpinEdit>");
            return lineasDocumento;
        }
    }
}
