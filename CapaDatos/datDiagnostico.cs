using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datDiagnostico
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDiagnostico _instancia = new datDiagnostico();

        // Propiedad pública para acceder a la instancia
        public static datDiagnostico Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion singleton

        public List<entDiagnostico> ListarDiagnostico()
        {
            SqlCommand cmd = null;
            List<entDiagnostico> lista = new List<entDiagnostico>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entDiagnostico diag = new entDiagnostico();
                    diag.DiagnosticoID = Convert.ToInt32(dr["DiagnosticoID"]);
                    diag.Desc_diagnostico = dr["Desc_diagnostico"].ToString();
                    diag.Fecha_diagnostico = Convert.ToDateTime(dr["Fecha_diagnostico"]);
                    diag.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    diag.TecnicoID = Convert.ToInt32(dr["TecnicoID"]);
                    diag.estDiagnostico = Convert.ToBoolean(dr["estDiagnostico"]);
                    lista.Add(diag);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Método para insertar diagnóstico
        public void InsertaDiagnostico(entDiagnostico diag)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Desc_diagnostico", diag.Desc_diagnostico);
                cmd.Parameters.AddWithValue("@Fecha_diagnostico", diag.Fecha_diagnostico);
                cmd.Parameters.AddWithValue("@ClienteID", diag.ClienteID);
                cmd.Parameters.AddWithValue("@TecnicoID", diag.TecnicoID);
                cmd.Parameters.AddWithValue("@estDiagnostico", diag.estDiagnostico);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        // Método para editar diagnóstico
        public void EditaDiagnostico(entDiagnostico diag)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiagnosticoID", diag.DiagnosticoID);
                cmd.Parameters.AddWithValue("@Desc_diagnostico", diag.Desc_diagnostico);
                cmd.Parameters.AddWithValue("@Fecha_diagnostico", diag.Fecha_diagnostico);
                cmd.Parameters.AddWithValue("@ClienteID", diag.ClienteID);
                cmd.Parameters.AddWithValue("@TecnicoID", diag.TecnicoID);
                cmd.Parameters.AddWithValue("@estDiagnostico", diag.estDiagnostico);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        // Método para deshabilitar diagnóstico
        public void DeshabilitarDiagnostico(entDiagnostico diag)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaDiagnostico", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DiagnosticoID", diag.DiagnosticoID);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
