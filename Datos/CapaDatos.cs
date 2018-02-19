using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Datos.EntidadesAux;

namespace Datos
{
    public class CapaDatos
    {

        OracleCommand cmd;
        OracleConnection conn;
        string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;

        #region "MetodosOracle"


        public void ModificarAvaluo(Avaluo objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "UPDATE CREDITO.CR_AVALUOS_MAD "+
                                  "SET FEC_AVALUO = :FEC_AVALUO, "+
                                  "    NUM_PERITO = :NUM_PERITO, "+
                                  "    MON_AVALUO = :MON_AVALUO, "+
                                  "    MON_TERRENO = :MON_TERRENO,"+
                                  "    MON_CONSTRUCCION = :MON_CONSTRUCCION, "+
                                  "    MON_VEHICULO = :MON_VEHICULO, "+
                                  "    ESTADO = :ESTADO, "+
                                  "    GENREG = :GENREG, "+
                                  "    COD_TIPOBIEN = :COD_TIPOBIEN, "+
                                  "    IND_BIENADJUDICADO = :IND_BIENADJUDICADO "+
                                  "Where NUM_GARANTIA_MADRE = :NUM_GARANTIA_MADRE";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;                
                cmd.Parameters.Add(new OracleParameter("FEC_AVALUO", objAv.FEC_AVALUO));
                cmd.Parameters.Add(new OracleParameter("NUM_PERITO", objAv.NUM_PERITO));
                cmd.Parameters.Add(new OracleParameter("MON_AVALUO", objAv.MON_AVALUO));
                cmd.Parameters.Add(new OracleParameter("MON_TERRENO", objAv.MON_TERRENO));
                cmd.Parameters.Add(new OracleParameter("MON_CONSTRUCCION", objAv.MON_CONSTRUCCION));
                cmd.Parameters.Add(new OracleParameter("MON_VEHICULO", objAv.MON_VEHICULO));
                cmd.Parameters.Add(new OracleParameter("ESTADO", objAv.ESTADO));
                cmd.Parameters.Add(new OracleParameter("GENREG", objAv.GENREG));
                cmd.Parameters.Add(new OracleParameter("COD_TIPOBIEN", objAv.COD_TIPOBIEN));
                cmd.Parameters.Add(new OracleParameter("IND_BIENADJUDICADO", objAv.IND_BIENADJUDICADO));
                cmd.Parameters.Add(new OracleParameter("NUM_GARANTIA_MADRE", objAv.NUM_GARANTIA_MADRE));               
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarAvaluo(Avaluo objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Delete from CREDITO.CR_AVALUOS_MAD WHERE NUM_GARANTIA_MADRE = :NUM_GARANTIA_MADRE";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("NUM_GARANTIA_MADRE", objAv.NUM_GARANTIA_MADRE));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RegistrarAvaluo(Avaluo objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Insert into CREDITO.CR_AVALUOS_MAD (COD_COMPANIA, NUM_GARANTIA_MADRE, FEC_AVALUO, NUM_PERITO, MON_AVALUO, "+
                    "MON_TERRENO, MON_CONSTRUCCION, MON_VEHICULO, ESTADO, GENREG, COD_TIPOBIEN, IND_BIENADJUDICADO) "+
                    "Values (:COD_COMPANIA, :NUM_GARANTIA_MADRE,:FEC_AVALUO, :NUM_PERITO, :MON_AVALUO, " +
                    ":MON_TERRENO, :MON_CONSTRUCCION, :MON_VEHICULO, :ESTADO, :GENREG, :COD_TIPOBIEN, :IND_BIENADJUDICADO)";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objAv.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_GARANTIA_MADRE", objAv.NUM_GARANTIA_MADRE));
                cmd.Parameters.Add(new OracleParameter("FEC_AVALUO", objAv.FEC_AVALUO));
                cmd.Parameters.Add(new OracleParameter("NUM_PERITO", objAv.NUM_PERITO));
                cmd.Parameters.Add(new OracleParameter("MON_AVALUO", objAv.MON_AVALUO));
                cmd.Parameters.Add(new OracleParameter("MON_TERRENO", objAv.MON_TERRENO));
                cmd.Parameters.Add(new OracleParameter("MON_CONSTRUCCION", objAv.MON_CONSTRUCCION));
                cmd.Parameters.Add(new OracleParameter("MON_VEHICULO", objAv.MON_VEHICULO));
                cmd.Parameters.Add(new OracleParameter("ESTADO", objAv.ESTADO));
                cmd.Parameters.Add(new OracleParameter("GENREG", objAv.GENREG));
                cmd.Parameters.Add(new OracleParameter("COD_TIPOBIEN", objAv.COD_TIPOBIEN));
                cmd.Parameters.Add(new OracleParameter("IND_BIENADJUDICADO", objAv.IND_BIENADJUDICADO));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void RegistrarVendedor(Vendedor objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Insert into FV_VENDEDORES (COD_COMPANIA, COD_VENDEDOR, COD_USUARIO, IND_ESTADO, NOMBRE_VENDEDOR, " +
                                  "  MTO_META_CAPTACION, MTO_META_CREDITO, MTO_META_SEGURO, IND_ORIGEN, TELEFONO, FAX, IND_FORMA_PAGO) " +
                                  " Values (:COD_COMPANIA,:COD_VENDEDOR, :COD_USUARIO, :IND_ESTADO, :NOMBRE_VENDEDOR, :MTO_META_CAPTACION, "+
                                  " :MTO_META_CREDITO, :MTO_META_SEGURO, :IND_ORIGEN, :TELEFONO,  :FAX, :IND_FORMA_PAGO); ";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objAv.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("COD_VENDEDOR", objAv.COD_VENDEDOR));
                cmd.Parameters.Add(new OracleParameter("COD_USUARIO", objAv.COD_USUARIO));
                cmd.Parameters.Add(new OracleParameter("IND_ESTADO", objAv.IND_ESTADO));
                cmd.Parameters.Add(new OracleParameter("NOMBRE_VENDEDOR", objAv.NOMBRE_VENDEDOR));
                cmd.Parameters.Add(new OracleParameter("MTO_META_CAPTACION", objAv.MTO_META_CAPTACION));
                cmd.Parameters.Add(new OracleParameter("MTO_META_CREDITO", objAv.MTO_META_CREDITO));
                cmd.Parameters.Add(new OracleParameter("MTO_META_SEGURO", objAv.MTO_META_SEGURO));
                cmd.Parameters.Add(new OracleParameter("IND_ORIGEN", objAv.IND_ORIGEN));
                cmd.Parameters.Add(new OracleParameter("TELEFONO", objAv.TELEFONO));
                cmd.Parameters.Add(new OracleParameter("FAX", objAv.FAX));
                cmd.Parameters.Add(new OracleParameter("IND_FORMA_PAGO", objAv.IND_FORMA_PAGO));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ConsultarSiguienteVendendedor()
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select max(COD_VENDEDOR) from FVENTAS.FV_VENDEDORES";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());            


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Vendedor> ConsultarVendedores()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select distinct * from FVENTAS.FV_VENDEDORES where COD_COMPANIA = '01001001' ORDER BY COD_VENDEDOR ASC";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Vendedor> ListadoVendedores = new List<Vendedor>();
                while (dr.Read())
                {
                    Vendedor objVend = new Vendedor();
                    objVend.COD_COMPANIA = dr.GetString(0);
                    objVend.COD_VENDEDOR = dr.GetInt32(1);
                    objVend.COD_USUARIO = dr.GetString(2);
                    objVend.IND_ESTADO = dr.GetString(3)=="A"?"1":"0";
                    objVend.NOMBRE_VENDEDOR = dr.GetString(4);
                    objVend.MTO_META_CAPTACION = dr.GetDecimal(5);
                    objVend.MTO_META_CREDITO = dr.GetDecimal(6);
                    objVend.MTO_META_SEGURO = dr.GetDecimal(7);
                    objVend.IND_ORIGEN = dr.GetString(8);
                    objVend.TELEFONO = dr.IsDBNull(9) == true ? "" : dr.GetString(9);
                    objVend.FAX = dr.IsDBNull(10) == true ? "" : dr.GetString(10);
                    objVend.IND_FORMA_PAGO = dr.IsDBNull(11) == true ? "" : dr.GetString(11);
                    ListadoVendedores.Add(objVend);

                }

                conn.Close();
                conn.Dispose();
                return ListadoVendedores;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Operacion> ConsultarOperacionesPS()
        {
            try
            {
                OracleDataReader dr;
                
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText =
                 "Select " +
                 " B.COD_COMPANIA, " +
                 " (SELECT DES_IDENTIFICACION FROM CLIENTES.CL_CLIENTES WHERE COD_CLIENTE = B.COD_CLIENTE) DES_IDENTIFICACION, " +
                 " B.COD_CLIENTE, " +
                 "(SELECT NOM_CLIENTE FROM CLIENTES.CL_CLIENTES WHERE COD_CLIENTE = B.COD_CLIENTE) NOM_CLIENTE, " +
                 " B.NUM_OPERACION, " +
                 " B.FEC_CONSTITUCION," +
                 " B.FEC_VENCIMIENTO, " +
                 " B.MON_ORIGINAL, " +
                 " ABS(C.MON_CREDITO - C.MON_DEBITO) SALDO, " +
                 " A.NUM_GARANTIA, " +
                 " NVL((SELECT NUM_GARANTIA_ORIGINAL FROM CREDITO.CR_GARANTIA_MADRE WHERE NUM_GARANTIA_MADRE = A.NUM_GARANTIA),'NO REGISTRA') GARANTIASIC," +
                 "(SELECT C.DES_ESTADO FROM CREDITO.CR_ESTADOS_OPER C WHERE IND_ESTADO = B.IND_ESTADO) ESTADO " +
                 " From CREDITO.CR_GARANTIA_SOLICITUD A " +
                 "  INNER JOIN CREDITO.CR_OPERACIONES B " +
                 "       ON A.NUM_SOLICITUD = B.NUM_SOLICITUD " +
                 "   INNER JOIN CREDITO.CR_SALDOS C " +
                 "       ON B.NUM_OPERACION = C.NUM_OPERACION " +
                 " Where C.COD_TIPOSALDO = 1 AND A.NUM_GARANTIA NOT IN (SELECT NUM_GARANTIA_MADRE FROM CREDITO.CR_AVALUOS_MAD)" +
                 " ORDER BY B.FEC_CONSTITUCION DESC ";
               
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Operacion> ListadoOperaciones = new List<Operacion>();
                while (dr.Read())
                {
                    Operacion Ope = new Operacion();
                    Ope.COD_COMPANIA = dr.GetString(0);
                    Ope.DES_IDENTIFICACION = dr.GetString(1);
                    Ope.COD_CLIENTE = dr.GetInt32(2);
                    Ope.NOM_CLIENTE = dr.GetString(3);
                    Ope.NUM_OPERACION = dr.GetString(4);
                    Ope.FEC_CONSTITUCION = dr.GetDateTime(5);
                    Ope.FEC_VENCIMIENTO = dr.GetDateTime(6);
                    Ope.MON_ORIGINAL = dr.GetDecimal(7);
                    Ope.SALDO = dr.GetDecimal(8);
                    Ope.NUM_GARANTIA = dr.GetDecimal(9);
                    Ope.GARANTIASIC = dr.GetString(10);
                    Ope.ESTADO = dr.GetString(11);
                    ListadoOperaciones.Add(Ope);     
                }

                conn.Close();
                conn.Dispose();
                return ListadoOperaciones;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<UsuarioPS> ConsultarUsuarioPS()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select COD_USUARIO,DES_NOMBRE from GENERAL.GL_USUARIOS";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<UsuarioPS> ListadoUsuariosPS = new List<UsuarioPS>();
                while (dr.Read())
                {
                    UsuarioPS UsPS = new UsuarioPS();
                    UsPS.COD_USUARIO = dr.GetString(0);
                    UsPS.DES_NOMBRE = dr.GetString(1);
                    ListadoUsuariosPS.Add(UsPS);
                }

                conn.Close();
                conn.Dispose();
                return ListadoUsuariosPS;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion
        #region "Metodos"

        public List<Modulos> ConsultarModulos()
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                return bd.Modulos.ToList();
            }
        }

        public List<SubOpciones> ConsultarSubOpciones()
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                return bd.SubOpciones.ToList();
            }
        }

        public List<Permisos> ConsultarPermisos()
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                return bd.Permisos.ToList();
            }
        }

        public List<Pantallas> ConsultarPantallas()
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                return bd.Pantallas.ToList();
            }
        }

        public List<Usuarios> ConsultarUsuarios()
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                return bd.Usuarios.ToList();
            }
        }

        public void AgregarUsuario(Usuarios objUsuario)
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                bd.Usuarios.Add(objUsuario);
                bd.SaveChanges();
            }
        }

        public void ModificarUsuario(Usuarios objUsuario)
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                Usuarios aux = bd.Usuarios.SingleOrDefault(x => x.IdUsuario == objUsuario.IdUsuario);
                if (aux != null)
                {
                     //bd.Usuarios.Attach(objUsuario);
                    aux.Usuario = objUsuario.Usuario;
                    aux.Nombre = objUsuario.Nombre;
                    aux.Apellido1 = objUsuario.Apellido1;
                    aux.Apellido2 = objUsuario.Apellido2;
                    aux.CambiarClave = objUsuario.CambiarClave;
                    aux.Clave = objUsuario.Clave;
                    aux.Correo = objUsuario.Correo;
                    aux.Estado = objUsuario.Estado;
                    
                     
                    
                   // bd.Entry(objUsuario).State = System.Data.Entity.EntityState.Modified;
                    //bd.Usuarios.Add(objUsuario);
                    bd.Entry(aux).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
        }

        public void EliminarUsuario(Usuarios objUsuario)
        {
             using (NovaCordEntities bd = new NovaCordEntities())
             {
                Usuarios aux = bd.Usuarios.SingleOrDefault(x => x.IdUsuario == objUsuario.IdUsuario);
                if (aux != null)
                {
                    bd.Usuarios.Remove(aux);
                    bd.SaveChanges();
                }
             }
        }

        public void AgregarPermiso(Permisos objPermisos)
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                bd.Permisos.Add(objPermisos);
                bd.SaveChanges();
            }
        }

        public void ModificarPermisos(Permisos objPermisos)
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                Permisos aux = bd.Permisos.SingleOrDefault(x => x.IdUsuario == objPermisos.IdUsuario && x.IdObjeto == objPermisos.IdObjeto);
                if (aux != null)
                {
                    //bd.Usuarios.Attach(objUsuario);
                    aux.Visible = objPermisos.Visible;
                    aux.Lectura = objPermisos.Lectura;
                    aux.Borrado = objPermisos.Borrado;
                    aux.Escritura = objPermisos.Escritura;



                    // bd.Entry(objUsuario).State = System.Data.Entity.EntityState.Modified;
                    //bd.Usuarios.Add(objUsuario);
                    bd.Entry(aux).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
        }

        public void EliminarPermiso(Permisos objPermiso)
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                Permisos aux = bd.Permisos.Where(x=>x.IdUsuario == objPermiso.IdUsuario && x.IdObjeto == objPermiso.IdObjeto).FirstOrDefault();
                bd.Permisos.Remove(aux);
                bd.SaveChanges();
            }
        }

        public void AgregarBitaAhorro(AHORROS_BIT_TRAS ahorroBit)
        {
            using (NovaCordEntities bd = new NovaCordEntities())
            {
                bd.AHORROS_BIT_TRAS.Add(ahorroBit);
                bd.SaveChanges();
            }
        }

#endregion



    }
}
