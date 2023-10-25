using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;


namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///LISTADO CLIENTE
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        ///INSERTA CLIENTE
        public void InsertaCliente(entCliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }
        //EDITA CLIENTE
        public void EditaCliente(entCliente Cli)
        {
            datCliente.Instancia.EditaCliente(Cli);
        }
        //DESABILITA CLIENTE
        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitaCliente(Cli);
        }
        #endregion metodos

    }
}
