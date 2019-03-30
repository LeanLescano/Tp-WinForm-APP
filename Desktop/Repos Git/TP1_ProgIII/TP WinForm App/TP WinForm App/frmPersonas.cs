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
        private List<string> listadoEstilos = new List<string>();

        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            //lblEdadCalculada.Text = "";
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Amarillo");
            cboColor.Items.Add("Violeta");
            cboColor.Items.Add("Negro");
            cboColor.Items.Add("Blanco");
            cboColor.Items.Add("Marrón");
            cboColor.Items.Add("Cian");

            dgvPersonas.DataSource = new List<Persona>();

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

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
            lblEdadCalculada.Text = edad.ToString();        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fechnac = dtpFechaNacimiento.Text;

            //Busca cuál es el radioButton seleccionado y lo asigna a la variable.
            string sexoSelected = "No definido";
            foreach (RadioButton Rboton in gpSexo.Controls)
            {
                if(Rboton.Checked)
                {
                    sexoSelected = Rboton.Text;
                }
            }
            //ESTILOS MUSICALES
            string estilosMusicales = "";
            int vuelta = 0;
            foreach (CheckBox Cbox in gpbEstilosMusicales.Controls)
            {
                if (Cbox.Checked)
                {
                    estilosMusicales += Cbox.Text;
                    if (vuelta == 8)
                    {
                        estilosMusicales += ".";
                    }
                    else
                    {
                        estilosMusicales += ", ";
                    }
                }
                vuelta++;
            }
            //Asigna los datos cargados mediante un constructor y lo agrega a la lista.
            Persona nueva = new Persona(txtNombre.Text.Trim(), txtApellido.Text.Trim(), fechnac, sexoSelected , estilosMusicales, cboColor.Text);
            listadoPersonas.Add(nueva);
            refrescarGrilla();
            restablecerControles();
        }

        private void refrescarGrilla()
        {
            dgvPersonas.DataSource = new List<Persona>();
            dgvPersonas.DataSource = listadoPersonas;
        }

        private void restablecerControles()
        {
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restablecerControles();
        }

        private void dgvPersonas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(e.StateChanged == DataGridViewElementStates.Selected)
            {

            }
        }
    }
}
