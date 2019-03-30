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

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas VentanaP = new frmPersonas();
            VentanaP.ShowDialog();

        }

        private void listadosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void listadosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void objetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObjetos VentanaO = new frmObjetos();
            VentanaO.ShowDialog();
        }
    }
}
