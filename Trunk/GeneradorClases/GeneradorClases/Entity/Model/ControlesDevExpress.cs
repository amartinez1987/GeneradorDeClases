using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Entity.Model
{
    public class ControlesDevExpress
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string alias { set; get; }
        public string tabla { set; get; }
        public string dataSource { set; get; }
        public string valueField { set; get; }
        public string textField { set; get; }
        public string formatoFecha { set; get; }
        public string sinSpinButton { set; get; }
    }
}
