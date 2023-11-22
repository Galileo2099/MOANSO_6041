using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class logDiagnostico
    {
        #region singleton
        // Variable estática para la instancia
        private static readonly logDiagnostico _instancia = new logDiagnostico();

        // Propiedad pública para acceder a la instancia
        public static logDiagnostico Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion singleton
        #region metodos
        //listar diagnostico 
        public List<entDiagnostico> ListarDiagnostico()
        {
            // Lógica para obtener la lista de diagnósticos
            return datDiagnostico.Instancia.ListarDiagnostico();
        }
        // Método para agregar un diagnóstico
        public void InsertaDiagnostico(entDiagnostico diag)
        {
            // Lógica para validar y agregar un diagnóstico
            datDiagnostico.Instancia.InsertaDiagnostico(diag);
        }

        // Método para editar un diagnóstico
        public void EditaDiagnostico(entDiagnostico diag)
        {
            // Lógica para validar y editar un diagnóstico
            datDiagnostico.Instancia.EditaDiagnostico(diag);
        }

        // Método para deshabilitar un diagnóstico
        public void EliminaDiagnostico(entDiagnostico diag)
        {
            // Lógica para deshabilitar un diagnóstico
            datDiagnostico.Instancia.DeshabilitarDiagnostico(diag);
        }
        #endregion
    }
}
