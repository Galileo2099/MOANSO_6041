using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente{
        public int idCliente { get; set; }
        public string razonSocial { get; set; }
        public int Numero { get; set; }
        public DateTime fecRegCliente { get; set; }
        public int idCiudad { get; set; } 
        public Boolean estCliente { get; set; }

    }
}
