namespace TP_WinForm_App
{
    partial class frmPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonas));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.rdFemenino = new System.Windows.Forms.RadioButton();
            this.rdOtro = new System.Windows.Forms.RadioButton();
            this.gpSexo = new System.Windows.Forms.GroupBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.chbElectronica = new System.Windows.Forms.CheckBox();
            this.gpbEstilosMusicales = new System.Windows.Forms.GroupBox();
            this.chbTrap = new System.Windows.Forms.CheckBox();
            this.chbReggaeton = new System.Windows.Forms.CheckBox();
            this.chbJazz = new System.Windows.Forms.CheckBox();
            this.chbReggae = new System.Windows.Forms.CheckBox();
            this.chbMetal = new System.Windows.Forms.CheckBox();
            this.chbClasica = new System.Windows.Forms.CheckBox();
            this.chbRock = new System.Windows.Forms.CheckBox();
            this.chbPop = new System.Windows.Forms.CheckBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpSexo.SuspendLayout();
            this.gpbEstilosMusicales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(31, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(255, 12);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(320, 61);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(255, 108);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color favorito:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(31, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(255, 38);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(199, 20);
            this.dtpFechaNacimiento.TabIndex = 8;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(14, 19);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdMasculino.TabIndex = 9;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.Location = new System.Drawing.Point(124, 19);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdFemenino.TabIndex = 10;
            this.rdFemenino.TabStop = true;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UseVisualStyleBackColor = true;
            // 
            // rdOtro
            // 
            this.rdOtro.AutoSize = true;
            this.rdOtro.Location = new System.Drawing.Point(232, 19);
            this.rdOtro.Name = "rdOtro";
            this.rdOtro.Size = new System.Drawing.Size(45, 17);
            this.rdOtro.TabIndex = 11;
            this.rdOtro.TabStop = true;
            this.rdOtro.Text = "Otro";
            this.rdOtro.UseVisualStyleBackColor = true;
            // 
            // gpSexo
            // 
            this.gpSexo.Controls.Add(this.rdMasculino);
            this.gpSexo.Controls.Add(this.rdOtro);
            this.gpSexo.Controls.Add(this.rdFemenino);
            this.gpSexo.Location = new System.Drawing.Point(504, 12);
            this.gpSexo.Name = "gpSexo";
            this.gpSexo.Size = new System.Drawing.Size(284, 46);
            this.gpSexo.TabIndex = 12;
            this.gpSexo.TabStop = false;
            this.gpSexo.Text = "Sexo";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(333, 105);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(121, 21);
            this.cboColor.Sorted = true;
            this.cboColor.TabIndex = 14;
            // 
            // chbElectronica
            // 
            this.chbElectronica.AutoSize = true;
            this.chbElectronica.Location = new System.Drawing.Point(14, 28);
            this.chbElectronica.Name = "chbElectronica";
            this.chbElectronica.Size = new System.Drawing.Size(79, 17);
            this.chbElectronica.TabIndex = 15;
            this.chbElectronica.Text = "Electrónica";
            this.chbElectronica.UseVisualStyleBackColor = true;
            // 
            // gpbEstilosMusicales
            // 
            this.gpbEstilosMusicales.Controls.Add(this.chbTrap);
            this.gpbEstilosMusicales.Controls.Add(this.chbReggaeton);
            this.gpbEstilosMusicales.Controls.Add(this.chbJazz);
            this.gpbEstilosMusicales.Controls.Add(this.chbReggae);
            this.gpbEstilosMusicales.Controls.Add(this.chbMetal);
            this.gpbEstilosMusicales.Controls.Add(this.chbClasica);
            this.gpbEstilosMusicales.Controls.Add(this.chbRock);
            this.gpbEstilosMusicales.Controls.Add(this.chbPop);
            this.gpbEstilosMusicales.Controls.Add(this.chbElectronica);
            this.gpbEstilosMusicales.Location = new System.Drawing.Point(504, 74);
            this.gpbEstilosMusicales.Name = "gpbEstilosMusicales";
            this.gpbEstilosMusicales.Size = new System.Drawing.Size(284, 124);
            this.gpbEstilosMusicales.TabIndex = 16;
            this.gpbEstilosMusicales.TabStop = false;
            this.gpbEstilosMusicales.Text = "Estilos musicales preferidos";
            // 
            // chbTrap
            // 
            this.chbTrap.AutoSize = true;
            this.chbTrap.Location = new System.Drawing.Point(209, 96);
            this.chbTrap.Name = "chbTrap";
            this.chbTrap.Size = new System.Drawing.Size(48, 17);
            this.chbTrap.TabIndex = 23;
            this.chbTrap.Text = "Trap";
            this.chbTrap.UseVisualStyleBackColor = true;
            // 
            // chbReggaeton
            // 
            this.chbReggaeton.AutoSize = true;
            this.chbReggaeton.Location = new System.Drawing.Point(14, 96);
            this.chbReggaeton.Name = "chbReggaeton";
            this.chbReggaeton.Size = new System.Drawing.Size(79, 17);
            this.chbReggaeton.TabIndex = 22;
            this.chbReggaeton.Text = "Reggaeton";
            this.chbReggaeton.UseVisualStyleBackColor = true;
            // 
            // chbJazz
            // 
            this.chbJazz.AutoSize = true;
            this.chbJazz.Location = new System.Drawing.Point(124, 96);
            this.chbJazz.Name = "chbJazz";
            this.chbJazz.Size = new System.Drawing.Size(47, 17);
            this.chbJazz.TabIndex = 21;
            this.chbJazz.Text = "Jazz";
            this.chbJazz.UseVisualStyleBackColor = true;
            // 
            // chbReggae
            // 
            this.chbReggae.AutoSize = true;
            this.chbReggae.Location = new System.Drawing.Point(209, 63);
            this.chbReggae.Name = "chbReggae";
            this.chbReggae.Size = new System.Drawing.Size(64, 17);
            this.chbReggae.TabIndex = 20;
            this.chbReggae.Text = "Reggae";
            this.chbReggae.UseVisualStyleBackColor = true;
            // 
            // chbMetal
            // 
            this.chbMetal.AutoSize = true;
            this.chbMetal.Location = new System.Drawing.Point(124, 63);
            this.chbMetal.Name = "chbMetal";
            this.chbMetal.Size = new System.Drawing.Size(52, 17);
            this.chbMetal.TabIndex = 19;
            this.chbMetal.Text = "Metal";
            this.chbMetal.UseVisualStyleBackColor = true;
            // 
            // chbClasica
            // 
            this.chbClasica.AutoSize = true;
            this.chbClasica.Location = new System.Drawing.Point(14, 63);
            this.chbClasica.Name = "chbClasica";
            this.chbClasica.Size = new System.Drawing.Size(60, 17);
            this.chbClasica.TabIndex = 18;
            this.chbClasica.Text = "Clásica";
            this.chbClasica.UseVisualStyleBackColor = true;
            // 
            // chbRock
            // 
            this.chbRock.AutoSize = true;
            this.chbRock.Location = new System.Drawing.Point(209, 26);
            this.chbRock.Name = "chbRock";
            this.chbRock.Size = new System.Drawing.Size(52, 17);
            this.chbRock.TabIndex = 17;
            this.chbRock.Text = "Rock";
            this.chbRock.UseVisualStyleBackColor = true;
            // 
            // chbPop
            // 
            this.chbPop.AutoSize = true;
            this.chbPop.Location = new System.Drawing.Point(124, 28);
            this.chbPop.Name = "chbPop";
            this.chbPop.Size = new System.Drawing.Size(45, 17);
            this.chbPop.TabIndex = 16;
            this.chbPop.Text = "Pop";
            this.chbPop.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(15, 217);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(773, 221);
            this.dgvPersonas.TabIndex = 18;
            this.dgvPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(93, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(216, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(339, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.gpbEstilosMusicales);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.gpSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de personas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPersonas_Load);
            this.gpSexo.ResumeLayout(false);
            this.gpSexo.PerformLayout();
            this.gpbEstilosMusicales.ResumeLayout(false);
            this.gpbEstilosMusicales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.RadioButton rdFemenino;
        private System.Windows.Forms.RadioButton rdOtro;
        private System.Windows.Forms.GroupBox gpSexo;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.CheckBox chbElectronica;
        private System.Windows.Forms.GroupBox gpbEstilosMusicales;
        private System.Windows.Forms.CheckBox chbReggae;
        private System.Windows.Forms.CheckBox chbMetal;
        private System.Windows.Forms.CheckBox chbClasica;
        private System.Windows.Forms.CheckBox chbRock;
        private System.Windows.Forms.CheckBox chbPop;
        private System.Windows.Forms.CheckBox chbTrap;
        private System.Windows.Forms.CheckBox chbReggaeton;
        private System.Windows.Forms.CheckBox chbJazz;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
    }
}