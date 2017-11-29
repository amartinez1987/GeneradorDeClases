using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class Control_ASPxCheckBoxList :Control
    {
        
        private const string alias = "chL";
        public string nombreAtributo { get; set; }
        bool sinSpinButton { get; set; }
        public Control_ASPxCheckBoxList(string nombreAtributo)
        {
            this.id = 6;
            this.nombre = "ASPxCheckBoxList";
            this.nombreAtributo = nombreAtributo;
        }

        public Control_ASPxCheckBoxList()
        {
            // TODO: Complete member initialization
        }

        public List<string> GetCodeBehindForm()
        {
            List<string> lineasDocumento = new List<string>();
            lineasDocumento.Add(string.Format("public DevExpress.Web.ASPxEditors.ASPxCheckBoxList get{1}{0}()", nombreAtributo, alias));
            lineasDocumento.Add("{");
            lineasDocumento.Add("get");
            lineasDocumento.Add("{");
            lineasDocumento.Add(string.Format("return {1}{0};", nombreAtributo, alias));
            lineasDocumento.Add("}");
            lineasDocumento.Add("}");

            return lineasDocumento;
        }
    }
}
