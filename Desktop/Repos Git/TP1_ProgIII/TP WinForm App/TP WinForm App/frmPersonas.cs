using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace TP_WinForm_App
{
    public partial class frmPersonas : Form
    {
        private List<Persona> listadoPersonas = new List<Persona>();
        private BindingList<Persona> listaBindeable;

        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Rosa");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Amarillo");
            cboColor.Items.Add("Violeta");
            cboColor.Items.Add("Negro");
            cboColor.Items.Add("Blanco");
            cboColor.Items.Add("Marrón");
            cboColor.Items.Add("Cian");

            listaBindeable = new BindingList<Persona>(listadoPersonas);
            dgvPersonas.DataSource = listaBindeable;
            dgvPersonas.Columns[2].HeaderText = "Fecha de nacimiento";
            dgvPersonas.Columns[4].HeaderText = "Estilos musicales";
            dgvPersonas.Columns[5].HeaderText = "Color favorito";

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Now.Year - dtpFechaNacimiento.Value.Year;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value.AddYears(edad);
            if(DateTime.Now.CompareTo(fechaNacimiento) < 0)
            {
                edad--;
            }
            if (edad <= 0)
            {
                lblEdad.Text = "Edad: ";
                return;
            }
            lblEdad.Text = "Edad: " + edad.ToString();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (faltanDatos())
            {
                MessageBox.Show("Faltan cargar datos", "Atención");
                return;
            }
            //Busca cuál es el radioButton seleccionado y lo asigna a la variable.
            string sexoSelected = "";
            foreach (RadioButton Rboton in gpSexo.Controls)
            {
                if(Rboton.Checked)
                {
                    sexoSelected = Rboton.Text;
                }
            }
            //Guarda los estilos musicales en un array de strings y en forma de texto para mostrar en la grilla.
            string estilosMusicales = estilosToString();
            //Asigna los datos cargados mediante un constructor y lo agrega a la lista.
            Persona nueva = new Persona(txtNombre.Text.Trim(), txtApellido.Text.Trim(), dtpFechaNacimiento.Text, sexoSelected, estilosMusicales, cboColor.Text);
            if (btnAceptar.Text == "Agregar")
            {
                listadoPersonas.Add(nueva);
            }
            else
            {
                if (dgvPersonas.CurrentRow == null) return;
                listadoPersonas[dgvPersonas.CurrentRow.Index] = nueva;
            }

            refrescarGrilla();
            restablecerControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restablecerControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexList = dgvPersonas.CurrentRow.Index;
            listadoPersonas.Remove(listadoPersonas[indexList]);
            refrescarGrilla();
            restablecerControles();
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvPersonas.CurrentRow.DataBoundItem == null) return;
            restablecerControles();
            btnEliminar.Enabled = true;
            btnAceptar.Text = "Modificar";
            Persona personaSelected = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
            cargarDatosForm(personaSelected);
        }

        //private bool datosCargados()
        //{
        //    bool Dato = false;
        //    if (txtNombre.Text != "" || txtApellido.Text != "" || cboColor.Text != "") Dato = true;
        //    foreach (RadioButton Rboton in gpSexo.Controls)
        //    {
        //        if (Rboton.Checked) Dato = true;
        //    }
        //    foreach (CheckBox Cbox in gpbEstilosMusicales.Controls)
        //    {
        //        if (Cbox.Checked) Dato = true;
        //    }
        //    return Dato;
        //}

        private void cargarDatosForm(Persona p)
        {
            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            dtpFechaNacimiento.Text = p.fechaNacimiento;
            cboColor.Text = p.colorFavorito;
            foreach (RadioButton Rboton in gpSexo.Controls)
            {
                if (Rboton.Text == p.Sexo)
                {
                    Rboton.Checked = true;
                }
            }

            foreach (CheckBox Cbox in gpbEstilosMusicales.Controls)
            {
                if(p.estilosMusicales.Contains(Cbox.Text))
                {
                    Cbox.Checked = true;
                }
            }
        }

        private bool faltanDatos()
        {
            if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == "" || cboColor.SelectedIndex < 0) return true;
            bool VacioS = true , VacioE = true;
            foreach (RadioButton Rboton in gpSexo.Controls)
            {
                if (Rboton.Checked) VacioS = false;
            }
            foreach (CheckBox Cbox in gpbEstilosMusicales.Controls)
            {
                if (Cbox.Checked) VacioE = false;
            }
            if (!VacioS && !VacioE)
                return false;
            else
                return true;
        }

        private string estilosToString()
        {
            string estilosM = "";
            int vuelta = 0, indice = 0;
            foreach (CheckBox Cbox in gpbEstilosMusicales.Controls)
            {
                if (Cbox.Checked)
                {
                    estilosM += Cbox.Text;
                    if (vuelta == 8)
                    {
                        estilosM += ".";
                    }
                    else
                    {
                        estilosM += ", ";
                    }
                    indice++;
                }
                vuelta++;
            }
            return estilosM;
        }

        private void refrescarGrilla()
        {
            listaBindeable.ResetBindings();
        }

        private void restablecerControles()
        {
            btnAceptar.Text = "Agregar";
            btnEliminar.Enabled = false;
            foreach (RadioButton rb in gpSexo.Controls)
            {
                rb.Checked = false;
            }
            foreach (CheckBox cb in gpbEstilosMusicales.Controls)
            {
                cb.Checked = false;
            }

            txtNombre.ResetText();
            txtApellido.ResetText();
            dtpFechaNacimiento.ResetText();
            cboColor.ResetText();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void frmPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Desea salir del formulario?", "Atención", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
