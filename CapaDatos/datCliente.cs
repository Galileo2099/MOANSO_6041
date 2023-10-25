﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datCliente{
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia{
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //listado de Clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try{
                SqlConnection cn = Conexion.Instancia.Conectar(); // se le pone instancia por el singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()){
                    entCliente Cli = new entCliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.razonSocial = dr["razonSocial"].ToString();
                    Cli.idTipoCliente = Convert.ToInt32(dr["idTipoCliente"].ToString());
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    Cli.idCiudad = Convert.ToInt32(dr["idCiudad"].ToString());
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    lista.Add(Cli);
                }

            }catch (Exception e){

                throw e;

            }finally{

                cmd.Connection.Close();

            }
            return lista;
        }   

        //InsertaCliente
        public Boolean InsertarCliente(entCliente Cli){

            SqlCommand cmd = null;
            Boolean inserta = false;

            try{

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@idTipoCliente", Cli.idTipoCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0){

                    inserta = true;
                }
            }
            catch (Exception e){

                throw e;

            }

            finally { cmd.Connection.Close(); }
            return inserta;

        }

        //Edita Cliente
        public Boolean EditaCliente(entCliente Cli){
            SqlCommand cmd = null;
            Boolean edita = false;
            try{
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@idTipoCliente", Cli.idTipoCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0){
                    edita = true;
                }
            }
            catch (Exception e){
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //DESHABILITA cliente
        public Boolean DeshabilitaCliente(entCliente Cli){
            SqlCommand cmd = null;
            Boolean delete = false;
            try{
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0){
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion metodos  
    }
}
