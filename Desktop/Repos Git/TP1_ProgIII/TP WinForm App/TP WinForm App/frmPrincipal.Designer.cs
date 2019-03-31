namespace TP_WinForm_App
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslListados = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnObjetos = new System.Windows.Forms.ToolStripButton();
            this.btnPersonas = new System.Windows.Forms.ToolStripButton();
            this.ssInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssInfo.Location = new System.Drawing.Point(0, 486);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(906, 22);
            this.ssInfo.TabIndex = 0;
            this.ssInfo.Text = "Bienvenido!";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(378, 17);
            this.tssStatus.Text = "Desde esta ventana podrás acceder a los listados de personas y objetos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslListados,
            this.toolStripSeparator1,
            this.btnPersonas,
            this.btnObjetos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(906, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolSdasdasdastrip1";
            // 
            // tslListados
            // 
            this.tslListados.Name = "tslListados";
            this.tslListados.Size = new System.Drawing.Size(50, 22);
            this.tslListados.Text = "Listados";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.MergeIndex = -5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnObjetos
            // 
            this.btnObjetos.Image = ((System.Drawing.Image)(resources.GetObject("btnObjetos.Image")));
            this.btnObjetos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnObjetos.Name = "btnObjetos";
            this.btnObjetos.Size = new System.Drawing.Size(68, 22);
            this.btnObjetos.Text = "Objetos";
            this.btnObjetos.Click += new System.EventHandler(this.btnObjetos_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonas.Image")));
            this.btnPersonas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(74, 22);
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 508);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ssInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Listados";
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslListados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnObjetos;
        private System.Windows.Forms.ToolStripButton btnPersonas;
    }
}

