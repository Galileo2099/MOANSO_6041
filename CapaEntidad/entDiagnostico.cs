using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDiagnostico
    {
        public int DiagnosticoID { get; set; }
        public string Desc_diagnostico { get; set; }
        public DateTime Fecha_diagnostico { get; set; }
        public int ClienteID { get; set; }
        public int TecnicoID { get; set; }
        public bool estDiagnostico { get; set; }
    }
}
