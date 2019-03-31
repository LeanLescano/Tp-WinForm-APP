using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm_App
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frmPersonas VentanaP = new frmPersonas();
            VentanaP.ShowDialog();
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            frmObjetos VentanaO = new frmObjetos();
            VentanaO.ShowDialog();
        }
    }
}
