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

            if(dtpFechaNacimiento.Value.Month == DateTime.Now.Month && dtpFechaNacimiento.Value.Day == DateTime.Now.Day)
            {
                lblEdadCalculada.Text = edad.ToString() + "  ¡Feliz cumpleaños!";
            }
            else
            {
                lblEdadCalculada.Text = edad.ToString();
            }
        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fechnac = dtpFechaNacimiento.Text;
            string selectedSexo = "No definido";
            foreach (var Rboton in gpSexo.Controls)
            {
                RadioButton radiobtn = Rboton as RadioButton;
                if(radiobtn.Checked)
                {
                    selectedSexo = radiobtn.Text;
                }
            }

            Persona nueva = new Persona(txtNombre.Text.Trim(), txtApellido.Text.Trim(), fechnac, selectedSexo ,listadoEstilos, "amarillo");
            listadoPersonas.Add(nueva);
            refrescarGrilla();
        }

        private void refrescarGrilla()
        {
            dgvPersonas.DataSource = new List<Persona>();
            dgvPersonas.DataSource = listadoPersonas;
        }
    }
}
