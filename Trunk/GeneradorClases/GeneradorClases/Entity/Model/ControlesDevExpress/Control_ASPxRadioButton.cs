using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxRadioButton:Control
    {
        
        private const string alias = "rb";
        public string nombreAtributo { get; set; }
        bool sinSpinButton { get; set; }
        public Control_ASPxRadioButton(string nombreAtributo)
        {
            this.id = 5;
            this.nombre = "ASPxRadioButton";
            this.nombreAtributo = nombreAtributo;
        }

        public Control_ASPxRadioButton()
        {
            // TODO: Complete member initialization
        }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxRadioButton get{1}{0}()", nombreAtributo, alias));
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
            lineasDocumento.Add(string.Format("<dx:ASPxRadioButton ID=\"{1}{0}\" ClientInstanceName=\"{1}{0}\" Text=\"{0}\" runat=\"server\">", nombreAtributo, alias));
            lineasDocumento.Add("</dx:ASPxRadioButton>");
            return lineasDocumento;
        }
    }
}
