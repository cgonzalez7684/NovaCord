using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos.EntidadesAux;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmBuscarUsuariosPs : Form
    {
        CapaLogica objLogica;
        UsuarioPS objUsPs;

        public FrmBuscarUsuariosPs()
        {
            InitializeComponent();
        }

        public FrmBuscarUsuariosPs(ref UsuarioPS aux)
        {
            InitializeComponent();
            
            aux.COD_USUARIO = "asddfad";
            aux.DES_NOMBRE = "asdfasdf";
            objUsPs = aux;
        }

        private void ConsultaraUsuariosPS()
        {
            try
            {
                objLogica = new CapaLogica();
                DgUsuariosPs.DataSource = objLogica.ConsultarUsuarioPS().ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmBuscarUsuariosPs_Load(object sender, EventArgs e)
        {
            ConsultaraUsuariosPS();
        }

        private void DgUsuariosPs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FrmVendedores.UsPs.COD_USUARIO = DgUsuariosPs.CurrentRow.Cells["DgCOD_USUARIO"].Value.ToString();
            FrmVendedores.UsPs.DES_NOMBRE = DgUsuariosPs.CurrentRow.Cells["DgDES_NOMBRE"].Value.ToString();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
