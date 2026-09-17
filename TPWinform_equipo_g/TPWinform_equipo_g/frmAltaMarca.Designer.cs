namespace TPWinform_equipo_g
{
    partial class frmAltaMarca
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarcasExistentes = new System.Windows.Forms.Label();
            this.lblOcultarMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(105, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(47, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(111, 236);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMarcas.Location = new System.Drawing.Point(379, 59);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(144, 227);
            this.dgvMarcas.TabIndex = 4;
            // 
            // lblMarcasExistentes
            // 
            this.lblMarcasExistentes.AutoSize = true;
            this.lblMarcasExistentes.Location = new System.Drawing.Point(376, 43);
            this.lblMarcasExistentes.Name = "lblMarcasExistentes";
            this.lblMarcasExistentes.Size = new System.Drawing.Size(110, 13);
            this.lblMarcasExistentes.TabIndex = 5;
            this.lblMarcasExistentes.Text = "Ver marcas existentes";
            this.lblMarcasExistentes.Click += new System.EventHandler(this.lblMarcasExistentes_Click);
            // 
            // lblOcultarMarcas
            // 
            this.lblOcultarMarcas.AutoSize = true;
            this.lblOcultarMarcas.Location = new System.Drawing.Point(376, 43);
            this.lblOcultarMarcas.Name = "lblOcultarMarcas";
            this.lblOcultarMarcas.Size = new System.Drawing.Size(128, 13);
            this.lblOcultarMarcas.TabIndex = 6;
            this.lblOcultarMarcas.Text = "Ocultar marcas existentes";
            this.lblOcultarMarcas.Click += new System.EventHandler(this.lblOcultarMarcas_Click);
            // 
            // frmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 329);
            this.Controls.Add(this.lblOcultarMarcas);
            this.Controls.Add(this.lblMarcasExistentes);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Marca";
            this.Load += new System.EventHandler(this.frmAltaMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarcasExistentes;
        private System.Windows.Forms.Label lblOcultarMarcas;
    }
}