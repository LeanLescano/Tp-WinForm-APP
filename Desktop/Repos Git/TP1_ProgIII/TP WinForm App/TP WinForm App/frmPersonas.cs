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
            if (edad <= 0) return;
            lblEdad.Text = "Edad: " + edad.ToString();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (faltanDatos())
            {
                MessageBox.Show("Faltan cargar datos", "¡Atención!");
                return;
            }
            string fechnac = dtpFechaNacimiento.Text;
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
            string[] listadoEstilos = new string[8];
            string estilosMusicales = estilosToString(listadoEstilos);
            //Asigna los datos cargados mediante un constructor y lo agrega a la lista.
            Persona nueva = new Persona(txtNombre.Text.Trim(), txtApellido.Text.Trim(), fechnac, sexoSelected, estilosMusicales, listadoEstilos, cboColor.Text);
            if (btnAceptar.Text == "Agregar")
            {
                listadoPersonas.Add(nueva);
            }
            else
            {
                if (dgvPersonas.CurrentRow == null) return;
                int index = dgvPersonas.CurrentRow.Index;
                listadoPersonas[index] = nueva;
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
            if (dgvPersonas.CurrentRow.DataBoundItem == null) return;
            restablecerControles();
            btnEliminar.Visible = true;
            btnAceptar.Text = "Modificar";
            Object filaSelected;
            filaSelected = dgvPersonas.CurrentRow.DataBoundItem;
            Persona personaSelected = (Persona)filaSelected;
            cargarDatosForm(personaSelected);
        }

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
                Cbox.Checked = false;
                foreach (string estilo in p.estilosList)
                {
                    if (Cbox.Text == estilo)
                    {
                        Cbox.Checked = true;
                    }
                }

            }
        }

        private bool faltanDatos()
        {
            if (txtApellido.Text.Trim() == "" || txtNombre.Text.Trim() == "") return true;
            bool Vacio = true;
            foreach (RadioButton Rboton in gpSexo.Controls)
            {
                if (Rboton.Checked == true) Vacio = false;
            }
            if (Vacio) return true;

            return false;
        }

        private string estilosToString(string[] listadoE)
        {
            string estilosM = "";
            int vuelta = 0, indice = 0;
            foreach (CheckBox Cbox in gpbEstilosMusicales.Controls)
            {
                if (Cbox.Checked)
                {
                    listadoE[indice] = Cbox.Text;
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
            btnEliminar.Visible = false;
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
    }
}
