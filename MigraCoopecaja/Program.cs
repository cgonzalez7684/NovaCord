using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppEscritorio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       
        
        [STAThread]
        static void Main()
        {

            //Colocaciones.FrmPlanillas obj = new Colocaciones.FrmPlanillas();
            //obj.ShowDialog();

            //return;

            FrmLogin fLogin = new FrmLogin();
            fLogin.ShowDialog();
            if (FrmLogin.UsuarioValidado)
            {
                Application.Run(new FrmMain());
            }

           
           
        }
    }
}
