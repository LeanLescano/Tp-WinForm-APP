namespace TP_WinForm_App
{
    partial class frmObjetos
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
            this.ltbUno = new System.Windows.Forms.ListBox();
            this.ltbDos = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnOneRight = new System.Windows.Forms.Button();
            this.btnOneLeft = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCantidadUno = new System.Windows.Forms.Label();
            this.lblCantidadDos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbUno
            // 
            this.ltbUno.FormattingEnabled = true;
            this.ltbUno.Location = new System.Drawing.Point(17, 72);
            this.ltbUno.Name = "ltbUno";
            this.ltbUno.Size = new System.Drawing.Size(263, 368);
            this.ltbUno.TabIndex = 0;
            // 
            // ltbDos
            // 
            this.ltbDos.FormattingEnabled = true;
            this.ltbDos.Location = new System.Drawing.Point(389, 72);
            this.ltbDos.Name = "ltbDos";
            this.ltbDos.Size = new System.Drawing.Size(263, 368);
            this.ltbDos.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(231, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllRight.Location = new System.Drawing.Point(297, 143);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllRight.TabIndex = 5;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnOneRight
            // 
            this.btnOneRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneRight.Location = new System.Drawing.Point(297, 186);
            this.btnOneRight.Name = "btnOneRight";
            this.btnOneRight.Size = new System.Drawing.Size(75, 23);
            this.btnOneRight.TabIndex = 6;
            this.btnOneRight.Text = ">";
            this.btnOneRight.UseVisualStyleBackColor = true;
            this.btnOneRight.Click += new System.EventHandler(this.btnOneRight_Click);
            // 
            // btnOneLeft
            // 
            this.btnOneLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOneLeft.Location = new System.Drawing.Point(297, 231);
            this.btnOneLeft.Name = "btnOneLeft";
            this.btnOneLeft.Size = new System.Drawing.Size(75, 23);
            this.btnOneLeft.TabIndex = 7;
            this.btnOneLeft.Text = "<";
            this.btnOneLeft.UseVisualStyleBackColor = true;
            this.btnOneLeft.Click += new System.EventHandler(this.btnOneLeft_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Location = new System.Drawing.Point(297, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "...";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCantidadUno
            // 
            this.lblCantidadUno.AutoSize = true;
            this.lblCantidadUno.Location = new System.Drawing.Point(17, 447);
            this.lblCantidadUno.Name = "lblCantidadUno";
            this.lblCantidadUno.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadUno.TabIndex = 9;
            this.lblCantidadUno.Text = "Cantidad de registros: 0";
            // 
            // lblCantidadDos
            // 
            this.lblCantidadDos.AutoSize = true;
            this.lblCantidadDos.Location = new System.Drawing.Point(389, 447);
            this.lblCantidadDos.Name = "lblCantidadDos";
            this.lblCantidadDos.Size = new System.Drawing.Size(118, 13);
            this.lblCantidadDos.TabIndex = 10;
            this.lblCantidadDos.Text = "Cantidad de registros: 0";
            // 
            // frmObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 471);
            this.Controls.Add(this.lblCantidadDos);
            this.Controls.Add(this.lblCantidadUno);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnOneLeft);
            this.Controls.Add(this.btnOneRight);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.ltbDos);
            this.Controls.Add(this.ltbUno);
            this.Name = "frmObjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de objetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbUno;
        private System.Windows.Forms.ListBox ltbDos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnOneRight;
        private System.Windows.Forms.Button btnOneLeft;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCantidadUno;
        private System.Windows.Forms.Label lblCantidadDos;
    }
}