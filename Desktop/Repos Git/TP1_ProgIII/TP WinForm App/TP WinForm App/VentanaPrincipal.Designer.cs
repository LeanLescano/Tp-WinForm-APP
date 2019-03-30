namespace TP_WinForm_App
{
    partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.msListados = new System.Windows.Forms.MenuStrip();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssInfo.SuspendLayout();
            this.msListados.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.ssInfo.Location = new System.Drawing.Point(0, 428);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(800, 22);
            this.ssInfo.TabIndex = 0;
            this.ssInfo.Text = "Bienvenido!";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(69, 17);
            this.tssStatus.Text = "Bienvenido!";
            // 
            // msListados
            // 
            this.msListados.BackColor = System.Drawing.SystemColors.ControlLight;
            this.msListados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadosToolStripMenuItem});
            this.msListados.Location = new System.Drawing.Point(0, 0);
            this.msListados.Name = "msListados";
            this.msListados.Size = new System.Drawing.Size(800, 24);
            this.msListados.TabIndex = 1;
            this.msListados.Text = "menuStrip1";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.objetosToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personasToolStripMenuItem.Image")));
            this.personasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // objetosToolStripMenuItem
            // 
            this.objetosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("objetosToolStripMenuItem.Image")));
            this.objetosToolStripMenuItem.Name = "objetosToolStripMenuItem";
            this.objetosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objetosToolStripMenuItem.Text = "Objetos";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.msListados);
            this.MainMenuStrip = this.msListados;
            this.Name = "VentanaPrincipal";
            this.Text = "Formulario de Listados";
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.msListados.ResumeLayout(false);
            this.msListados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.MenuStrip msListados;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetosToolStripMenuItem;
    }
}

