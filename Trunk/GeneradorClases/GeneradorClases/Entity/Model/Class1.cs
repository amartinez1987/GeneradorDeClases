using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using a.Entity.Model;
using System.Threading.Tasks;

namespace a.Entity.Controller
{
public class ISTATESOLICITUDES_CTC_Inactivo:ISTATESOLICITUDES_CTC
{
private const string nombreEstado = "Inactivo"
Result Nuevo(ref SOLICITUDES_CTC registro)
{
Result resul = new Result();
resul.error = "No se puede realizar esta operación en el estado actual del registro";
return resul;
}
Result Editar(ref SOLICITUDES_CTC registro)
{
Result resul = new Result();
resul.error = "No se puede realizar esta operación en el estado actual del registro";
return resul;
}
}
}
