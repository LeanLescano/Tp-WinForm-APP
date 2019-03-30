﻿namespace TP_WinForm_App
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
            this.cboTrap = new System.Windows.Forms.CheckBox();
            this.cboReggaeton = new System.Windows.Forms.CheckBox();
            this.cboJazz = new System.Windows.Forms.CheckBox();
            this.cboReggae = new System.Windows.Forms.CheckBox();
            this.cboMetal = new System.Windows.Forms.CheckBox();
            this.cboClasica = new System.Windows.Forms.CheckBox();
            this.cboRock = new System.Windows.Forms.CheckBox();
            this.cboPop = new System.Windows.Forms.CheckBox();
            this.lblEdadCalculada = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpSexo.SuspendLayout();
            this.gpbEstilosMusicales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(236, 12);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(436, 42);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(236, 108);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "Color favorito:";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(12, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(236, 38);
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
            this.cboColor.Location = new System.Drawing.Point(314, 105);
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
            this.gpbEstilosMusicales.Controls.Add(this.cboTrap);
            this.gpbEstilosMusicales.Controls.Add(this.cboReggaeton);
            this.gpbEstilosMusicales.Controls.Add(this.cboJazz);
            this.gpbEstilosMusicales.Controls.Add(this.cboReggae);
            this.gpbEstilosMusicales.Controls.Add(this.cboMetal);
            this.gpbEstilosMusicales.Controls.Add(this.cboClasica);
            this.gpbEstilosMusicales.Controls.Add(this.cboRock);
            this.gpbEstilosMusicales.Controls.Add(this.cboPop);
            this.gpbEstilosMusicales.Controls.Add(this.chbElectronica);
            this.gpbEstilosMusicales.Location = new System.Drawing.Point(504, 74);
            this.gpbEstilosMusicales.Name = "gpbEstilosMusicales";
            this.gpbEstilosMusicales.Size = new System.Drawing.Size(284, 124);
            this.gpbEstilosMusicales.TabIndex = 16;
            this.gpbEstilosMusicales.TabStop = false;
            this.gpbEstilosMusicales.Text = "Estilos Musicales";
            // 
            // cboTrap
            // 
            this.cboTrap.AutoSize = true;
            this.cboTrap.Location = new System.Drawing.Point(209, 96);
            this.cboTrap.Name = "cboTrap";
            this.cboTrap.Size = new System.Drawing.Size(48, 17);
            this.cboTrap.TabIndex = 23;
            this.cboTrap.Text = "Trap";
            this.cboTrap.UseVisualStyleBackColor = true;
            // 
            // cboReggaeton
            // 
            this.cboReggaeton.AutoSize = true;
            this.cboReggaeton.Location = new System.Drawing.Point(14, 96);
            this.cboReggaeton.Name = "cboReggaeton";
            this.cboReggaeton.Size = new System.Drawing.Size(79, 17);
            this.cboReggaeton.TabIndex = 22;
            this.cboReggaeton.Text = "Reggaeton";
            this.cboReggaeton.UseVisualStyleBackColor = true;
            // 
            // cboJazz
            // 
            this.cboJazz.AutoSize = true;
            this.cboJazz.Location = new System.Drawing.Point(124, 96);
            this.cboJazz.Name = "cboJazz";
            this.cboJazz.Size = new System.Drawing.Size(47, 17);
            this.cboJazz.TabIndex = 21;
            this.cboJazz.Text = "Jazz";
            this.cboJazz.UseVisualStyleBackColor = true;
            // 
            // cboReggae
            // 
            this.cboReggae.AutoSize = true;
            this.cboReggae.Location = new System.Drawing.Point(209, 63);
            this.cboReggae.Name = "cboReggae";
            this.cboReggae.Size = new System.Drawing.Size(64, 17);
            this.cboReggae.TabIndex = 20;
            this.cboReggae.Text = "Reggae";
            this.cboReggae.UseVisualStyleBackColor = true;
            // 
            // cboMetal
            // 
            this.cboMetal.AutoSize = true;
            this.cboMetal.Location = new System.Drawing.Point(124, 63);
            this.cboMetal.Name = "cboMetal";
            this.cboMetal.Size = new System.Drawing.Size(52, 17);
            this.cboMetal.TabIndex = 19;
            this.cboMetal.Text = "Metal";
            this.cboMetal.UseVisualStyleBackColor = true;
            // 
            // cboClasica
            // 
            this.cboClasica.AutoSize = true;
            this.cboClasica.Location = new System.Drawing.Point(14, 63);
            this.cboClasica.Name = "cboClasica";
            this.cboClasica.Size = new System.Drawing.Size(60, 17);
            this.cboClasica.TabIndex = 18;
            this.cboClasica.Text = "Clásica";
            this.cboClasica.UseVisualStyleBackColor = true;
            // 
            // cboRock
            // 
            this.cboRock.AutoSize = true;
            this.cboRock.Location = new System.Drawing.Point(209, 26);
            this.cboRock.Name = "cboRock";
            this.cboRock.Size = new System.Drawing.Size(52, 17);
            this.cboRock.TabIndex = 17;
            this.cboRock.Text = "Rock";
            this.cboRock.UseVisualStyleBackColor = true;
            // 
            // cboPop
            // 
            this.cboPop.AutoSize = true;
            this.cboPop.Location = new System.Drawing.Point(124, 28);
            this.cboPop.Name = "cboPop";
            this.cboPop.Size = new System.Drawing.Size(45, 17);
            this.cboPop.TabIndex = 16;
            this.cboPop.Text = "Pop";
            this.cboPop.UseVisualStyleBackColor = true;
            // 
            // lblEdadCalculada
            // 
            this.lblEdadCalculada.AutoSize = true;
            this.lblEdadCalculada.Location = new System.Drawing.Point(448, 201);
            this.lblEdadCalculada.Name = "lblEdadCalculada";
            this.lblEdadCalculada.Size = new System.Drawing.Size(0, 13);
            this.lblEdadCalculada.TabIndex = 17;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(15, 217);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(773, 221);
            this.dgvPersonas.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(104, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.lblEdadCalculada);
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
        private System.Windows.Forms.CheckBox cboReggae;
        private System.Windows.Forms.CheckBox cboMetal;
        private System.Windows.Forms.CheckBox cboClasica;
        private System.Windows.Forms.CheckBox cboRock;
        private System.Windows.Forms.CheckBox cboPop;
        private System.Windows.Forms.Label lblEdadCalculada;
        private System.Windows.Forms.CheckBox cboTrap;
        private System.Windows.Forms.CheckBox cboReggaeton;
        private System.Windows.Forms.CheckBox cboJazz;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}