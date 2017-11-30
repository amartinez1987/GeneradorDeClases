using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxListBox:Control
    {
               private const string alias = "lb";
        public string nombreAtributo { get; set; }
        
        public Control_ASPxListBox(string nombreAtributo)
        {
            this.id = 8;
            this.nombre = "ASPxListBox";
            this.nombreAtributo = nombreAtributo;
        }

        public Control_ASPxListBox()
        {
            // TODO: Complete member initialization
            this.id = 8;
            this.nombre = "ASPxListBox";
        }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxListBox get{1}{0}()", nombreAtributo, alias));
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
            lineasDocumento.Add(string.Format("<dx:ASPxListBox ID=\"{1}{0}\" ClientInstanceName=\"{1}{0}\" runat=\"server\">", nombreAtributo, alias));
            lineasDocumento.Add("</dx:ASPxListBox>");
            return lineasDocumento;
        }
    }
}
