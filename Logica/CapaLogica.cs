using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.EntidadesAux;
using System.Reflection;
using Oracle.DataAccess;

namespace Logica
{
    public class CapaLogica
    {

    #region "Atributos"

        CapaDatos objCapaDatos; 
    
        
    #endregion

        #region "MetodosOracle"
        public List<UsuarioPS> ConsultarUsuarioPS()
        {
            try
            {
                objCapaDatos = new CapaDatos();
                return objCapaDatos.ConsultarUsuarioPS();
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
                objCapaDatos = new CapaDatos();
                return objCapaDatos.ConsultarOperacionesPS();
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
                if (objAv.COD_TIPOBIEN == "999")
                {
                    throw new Exception("Debe especificar el tipo de bien del avaluo");
                }

                objCapaDatos = new CapaDatos();
                objCapaDatos.RegistrarAvaluo(objAv);
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
                objCapaDatos = new CapaDatos();
                objCapaDatos.EliminarAvaluo(objAv);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void ModificarAvaluo(Avaluo objAv)
        {
            try
            {
                if (objAv.COD_TIPOBIEN == "999")
                {
                    throw new Exception("Debe especificar el tipo de bien del avaluo");
                }

                objCapaDatos = new CapaDatos();
                objCapaDatos.ModificarAvaluo(objAv);
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
                
                objCapaDatos = new CapaDatos();
                objCapaDatos.RegistrarVendedor(objAv);
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

                objCapaDatos = new CapaDatos();
                return objCapaDatos.ConsultarVendedores();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ConsultarSiguienteVendendedor()
        {
            objCapaDatos = new CapaDatos();
            return objCapaDatos.ConsultarSiguienteVendendedor();
        }


       
        #endregion 
        #region "Consultas"

        public List<Modulos> ConsultarModulos()
       {
            objCapaDatos = new Datos.CapaDatos();
            return objCapaDatos.ConsultarModulos();
       }

       public List<SubOpciones> ConsultarSubOpciones()
       {
           objCapaDatos = new Datos.CapaDatos();
           return objCapaDatos.ConsultarSubOpciones();
       }

       public List<Pantallas> ConsultarPantallas()
       {
           objCapaDatos = new Datos.CapaDatos();
           return objCapaDatos.ConsultarPantallas();
       }

       public List<Permisos> ConsultarPermisos()
       {
           objCapaDatos = new Datos.CapaDatos();
           return objCapaDatos.ConsultarPermisos();
       }

       public List<Usuarios> ConsultarUsuarios()
       {
           objCapaDatos = new Datos.CapaDatos();
           return objCapaDatos.ConsultarUsuarios();
       }

       public void AgregarUsuario(Usuarios objUsuario)
       {
           objCapaDatos = new Datos.CapaDatos();
           objCapaDatos.AgregarUsuario(objUsuario);
       }

       public void EliminarUsuario(Usuarios objUsuario)
       {
           objCapaDatos = new Datos.CapaDatos();
           objCapaDatos.EliminarUsuario(objUsuario);
       }

       public void ModificarUsuario(Usuarios objUsuario)
       {
           objCapaDatos = new Datos.CapaDatos();
           objCapaDatos.ModificarUsuario(objUsuario);
       }

       public void AgregarPermiso(Permisos objPermiso)
       {
           objCapaDatos = new Datos.CapaDatos();
           objCapaDatos.AgregarPermiso(objPermiso);
       }

        public void ModificarPermiso(Permisos objPermiso)
       {
           objCapaDatos = new Datos.CapaDatos();
           objCapaDatos.ModificarPermisos(objPermiso);
       }

        public void EliminarPermiso(Permisos objPermiso)
        {
            objCapaDatos = new Datos.CapaDatos();
            objCapaDatos.EliminarPermiso(objPermiso);
        }

        public void AgregarBitaAhorro(AHORROS_BIT_TRAS ahorroBit)
        {
            objCapaDatos = new Datos.CapaDatos();
            objCapaDatos.AgregarBitaAhorro(ahorroBit);
        }

    #endregion


    }
}
