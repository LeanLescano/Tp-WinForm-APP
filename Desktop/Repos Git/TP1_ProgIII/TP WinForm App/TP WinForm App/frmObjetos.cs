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
    public partial class frmObjetos : Form
    {
        public frmObjetos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "") return;
            ltbUno.Items.Add(txtNombre.Text.Trim());
            txtNombre.ResetText();
            txtNombre.Focus();
            actualizarRegistros();
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            if (ltbUno.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en la lista de la derecha.", "¡Cuidado!");
                return;
            }
            for (int i = 0; i <= ltbUno.Items.Count -1; i++)
            {
                if (!objetoRepetido(ltbUno.Items[i].ToString()))
                {
                    ltbDos.Items.Add(ltbUno.Items[i].ToString());
                    ltbUno.Items.RemoveAt(i);
                    i--;
                }
                else
                {
                    ltbUno.Items.RemoveAt(i);
                    i--;
                }
            }
            actualizarRegistros();
        }

        private void btnOneRight_Click(object sender, EventArgs e)
        {
            int index = ltbUno.SelectedIndex;
            if(index >= 0)
            {
                if(!objetoRepetido(ltbUno.SelectedItem.ToString()))
                {
                    ltbDos.Items.Add(ltbUno.Items[index].ToString());
                    ltbUno.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Este item ya existe en la lista de la derecha.", "¡Cuidado!");
                    ltbUno.Items.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("No hay ningún objeto seleccionado.", "¡Atención!");
            }
            actualizarRegistros();
        }

        private bool objetoRepetido(string o)
        {
            for (int i = 0; i <= ltbDos.Items.Count - 1; i++)
            {
                if (o == ltbDos.Items[i].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private void btnOneLeft_Click(object sender, EventArgs e)
        {
            int index = ltbDos.SelectedIndex;
            if (index >= 0)
            {

                    ltbUno.Items.Add(ltbDos.Items[index].ToString());
                    ltbDos.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("No hay ningún objeto seleccionado.", "¡Atención!");
            }
            actualizarRegistros();
        }

        private void actualizarRegistros()
        {
            lblCantidadUno.Text = "Cantidad de registros: " + ltbUno.Items.Count.ToString();
            lblCantidadDos.Text = "Cantidad de registros: " + ltbDos.Items.Count.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = ltbDos.SelectedIndex;
            if (index >= 0)
            {
                ltbDos.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("No hay ningún objeto seleccionado.", "¡Atención!");
            }
            actualizarRegistros();
        }
    }
}
