namespace TPWinform_equipo_g
{
    partial class frmAltaCategoria
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
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoriaNueva = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoriaNueva = new System.Windows.Forms.Button();
            this.btnCancelarCategoriaNueva = new System.Windows.Forms.Button();
            this.lblCategoriasExistentes = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(39, 196);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(110, 13);
            this.lblNombreCategoria.TabIndex = 0;
            this.lblNombreCategoria.Text = "Nombre de Categoria:";
            // 
            // txtNombreCategoriaNueva
            // 
            this.txtNombreCategoriaNueva.Location = new System.Drawing.Point(155, 193);
            this.txtNombreCategoriaNueva.Name = "txtNombreCategoriaNueva";
            this.txtNombreCategoriaNueva.Size = new System.Drawing.Size(140, 20);
            this.txtNombreCategoriaNueva.TabIndex = 1;
            // 
            // btnAgregarCategoriaNueva
            // 
            this.btnAgregarCategoriaNueva.Location = new System.Drawing.Point(74, 238);
            this.btnAgregarCategoriaNueva.Name = "btnAgregarCategoriaNueva";
            this.btnAgregarCategoriaNueva.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoriaNueva.TabIndex = 2;
            this.btnAgregarCategoriaNueva.Text = "Agregar";
            this.btnAgregarCategoriaNueva.UseVisualStyleBackColor = true;
            this.btnAgregarCategoriaNueva.Click += new System.EventHandler(this.btnAgregarCategoriaNueva_Click);
            // 
            // btnCancelarCategoriaNueva
            // 
            this.btnCancelarCategoriaNueva.Location = new System.Drawing.Point(193, 238);
            this.btnCancelarCategoriaNueva.Name = "btnCancelarCategoriaNueva";
            this.btnCancelarCategoriaNueva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCategoriaNueva.TabIndex = 3;
            this.btnCancelarCategoriaNueva.Text = "Cancelar";
            this.btnCancelarCategoriaNueva.UseVisualStyleBackColor = true;
            this.btnCancelarCategoriaNueva.Click += new System.EventHandler(this.btnCancelarCategoriaNueva_Click);
            // 
            // lblCategoriasExistentes
            // 
            this.lblCategoriasExistentes.AutoSize = true;
            this.lblCategoriasExistentes.Location = new System.Drawing.Point(320, 71);
            this.lblCategoriasExistentes.Name = "lblCategoriasExistentes";
            this.lblCategoriasExistentes.Size = new System.Drawing.Size(146, 13);
            this.lblCategoriasExistentes.TabIndex = 4;
            this.lblCategoriasExistentes.Text = "Mostrar Categorias Existentes";
            this.lblCategoriasExistentes.Click += new System.EventHandler(this.lblCategoriasExistentes_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(323, 98);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(179, 163);
            this.dgvCategorias.TabIndex = 5;
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 337);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblCategoriasExistentes);
            this.Controls.Add(this.btnCancelarCategoriaNueva);
            this.Controls.Add(this.btnAgregarCategoriaNueva);
            this.Controls.Add(this.txtNombreCategoriaNueva);
            this.Controls.Add(this.lblNombreCategoria);
            this.Name = "frmAltaCategoria";
            this.Text = "Alta de Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoriaNueva;
        private System.Windows.Forms.Button btnAgregarCategoriaNueva;
        private System.Windows.Forms.Button btnCancelarCategoriaNueva;
        private System.Windows.Forms.Label lblCategoriasExistentes;
        private System.Windows.Forms.DataGridView dgvCategorias;
    }
}