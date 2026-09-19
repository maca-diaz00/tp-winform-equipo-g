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
            this.SuspendLayout();
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(62, 173);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(183, 13);
            this.lblNombreCategoria.TabIndex = 0;
            this.lblNombreCategoria.Text = "Agregue nombre de nueva categoria:";
            // 
            // txtNombreCategoriaNueva
            // 
            this.txtNombreCategoriaNueva.Location = new System.Drawing.Point(251, 170);
            this.txtNombreCategoriaNueva.Name = "txtNombreCategoriaNueva";
            this.txtNombreCategoriaNueva.Size = new System.Drawing.Size(216, 20);
            this.txtNombreCategoriaNueva.TabIndex = 1;
            // 
            // btnAgregarCategoriaNueva
            // 
            this.btnAgregarCategoriaNueva.Location = new System.Drawing.Point(127, 238);
            this.btnAgregarCategoriaNueva.Name = "btnAgregarCategoriaNueva";
            this.btnAgregarCategoriaNueva.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoriaNueva.TabIndex = 2;
            this.btnAgregarCategoriaNueva.Text = "Agregar";
            this.btnAgregarCategoriaNueva.UseVisualStyleBackColor = true;
            this.btnAgregarCategoriaNueva.Click += new System.EventHandler(this.btnAgregarCategoriaNueva_Click);
            // 
            // btnCancelarCategoriaNueva
            // 
            this.btnCancelarCategoriaNueva.Location = new System.Drawing.Point(320, 238);
            this.btnCancelarCategoriaNueva.Name = "btnCancelarCategoriaNueva";
            this.btnCancelarCategoriaNueva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCategoriaNueva.TabIndex = 3;
            this.btnCancelarCategoriaNueva.Text = "Cancelar";
            this.btnCancelarCategoriaNueva.UseVisualStyleBackColor = true;
            this.btnCancelarCategoriaNueva.Click += new System.EventHandler(this.btnCancelarCategoriaNueva_Click);
            // 
            // frmAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 337);
            this.Controls.Add(this.btnCancelarCategoriaNueva);
            this.Controls.Add(this.btnAgregarCategoriaNueva);
            this.Controls.Add(this.txtNombreCategoriaNueva);
            this.Controls.Add(this.lblNombreCategoria);
            this.Name = "frmAltaCategoria";
            this.Text = "Alta de Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoriaNueva;
        private System.Windows.Forms.Button btnAgregarCategoriaNueva;
        private System.Windows.Forms.Button btnCancelarCategoriaNueva;
    }
}