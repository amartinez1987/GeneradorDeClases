using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxCheckBox:Control
    {
        private  const string alias = "ch";
        public string nombreAtributo { get; set; }
       
       public Control_ASPxCheckBox(string nombreAtributo)
        {
            this.id = 4;
            this.nombre = "ASPxCheckBox";
            this.nombreAtributo = nombreAtributo;            
        }

       public Control_ASPxCheckBox()
       {
           // TODO: Complete member initialization
           this.id = 4;
           this.nombre = "ASPxCheckBox";
       }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxCheckBox get{1}{0}()", nombreAtributo));
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
            lineasDocumento.Add(string.Format("<dx:ASPxCheckBox ID=\"{1}{0}\" ClientInstanceName=\"{1}{0}\" Text=\"{0}\" runat=\"server\">", nombreAtributo, alias));
            lineasDocumento.Add("</dx:ASPxCheckBox>");
            return lineasDocumento;
        }
    }
}
