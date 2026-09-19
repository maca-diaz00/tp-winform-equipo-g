namespace TPWinform_equipo_g
{
    partial class frmAltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
            this.lblAltaCodigo = new System.Windows.Forms.Label();
            this.lblAltaNombre = new System.Windows.Forms.Label();
            this.lblAltaDescripcion = new System.Windows.Forms.Label();
            this.lblAltaMarca = new System.Windows.Forms.Label();
            this.lblAltaCategoria = new System.Windows.Forms.Label();
            this.lblAltaPrecio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.btnAnteriorImagen = new System.Windows.Forms.Button();
            this.btnSiguienteImagen = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEditarCodigo = new System.Windows.Forms.Button();
            this.btnEditarNombre = new System.Windows.Forms.Button();
            this.btnEditarDesc = new System.Windows.Forms.Button();
            this.btnEditarCat = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnEditarPrecio = new System.Windows.Forms.Button();
            this.btnModificarTodos = new System.Windows.Forms.Button();
            this.btnLimpiarTxtImagen = new System.Windows.Forms.Button();
            this.btnEditarImagenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAltaCodigo
            // 
            this.lblAltaCodigo.AutoSize = true;
            this.lblAltaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCodigo.Location = new System.Drawing.Point(67, 67);
            this.lblAltaCodigo.Name = "lblAltaCodigo";
            this.lblAltaCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblAltaCodigo.TabIndex = 0;
            this.lblAltaCodigo.Text = "Código:";
            // 
            // lblAltaNombre
            // 
            this.lblAltaNombre.AutoSize = true;
            this.lblAltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaNombre.Location = new System.Drawing.Point(61, 107);
            this.lblAltaNombre.Name = "lblAltaNombre";
            this.lblAltaNombre.Size = new System.Drawing.Size(62, 17);
            this.lblAltaNombre.TabIndex = 1;
            this.lblAltaNombre.Text = "Nombre:";
            // 
            // lblAltaDescripcion
            // 
            this.lblAltaDescripcion.AutoSize = true;
            this.lblAltaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDescripcion.Location = new System.Drawing.Point(37, 145);
            this.lblAltaDescripcion.Name = "lblAltaDescripcion";
            this.lblAltaDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblAltaDescripcion.TabIndex = 2;
            this.lblAltaDescripcion.Text = "Descripción:";
            // 
            // lblAltaMarca
            // 
            this.lblAltaMarca.AutoSize = true;
            this.lblAltaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaMarca.Location = new System.Drawing.Point(67, 235);
            this.lblAltaMarca.Name = "lblAltaMarca";
            this.lblAltaMarca.Size = new System.Drawing.Size(51, 17);
            this.lblAltaMarca.TabIndex = 3;
            this.lblAltaMarca.Text = "Marca:";
            // 
            // lblAltaCategoria
            // 
            this.lblAltaCategoria.AutoSize = true;
            this.lblAltaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaCategoria.Location = new System.Drawing.Point(45, 282);
            this.lblAltaCategoria.Name = "lblAltaCategoria";
            this.lblAltaCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblAltaCategoria.TabIndex = 4;
            this.lblAltaCategoria.Text = "Categoria:";
            // 
            // lblAltaPrecio
            // 
            this.lblAltaPrecio.AutoSize = true;
            this.lblAltaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaPrecio.Location = new System.Drawing.Point(66, 319);
            this.lblAltaPrecio.Name = "lblAltaPrecio";
            this.lblAltaPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblAltaPrecio.TabIndex = 5;
            this.lblAltaPrecio.Text = "Precio:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(147, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(201, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(147, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(147, 144);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 69);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(147, 319);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(201, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(147, 235);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(201, 21);
            this.cbxMarca.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(147, 278);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(201, 21);
            this.cbxCategoria.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(221, 451);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 41);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(369, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(66, 360);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(58, 17);
            this.lblImagen.TabIndex = 14;
            this.lblImagen.Text = "Imagen:";
            // 
            // txtImagen
            // 
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(147, 360);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(201, 20);
            this.txtImagen.TabIndex = 6;
            this.txtImagen.TextChanged += new System.EventHandler(this.txtImagen_TextChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(428, 141);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(194, 182);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 16;
            this.pbxImagen.TabStop = false;
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.AutoSize = true;
            this.btnEliminarImagen.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarImagen.Image")));
            this.btnEliminarImagen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarImagen.Location = new System.Drawing.Point(500, 332);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(42, 35);
            this.btnEliminarImagen.TabIndex = 9;
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // btnAnteriorImagen
            // 
            this.btnAnteriorImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnteriorImagen.Location = new System.Drawing.Point(403, 213);
            this.btnAnteriorImagen.Name = "btnAnteriorImagen";
            this.btnAnteriorImagen.Size = new System.Drawing.Size(19, 23);
            this.btnAnteriorImagen.TabIndex = 7;
            this.btnAnteriorImagen.TabStop = false;
            this.btnAnteriorImagen.Text = "<";
            this.btnAnteriorImagen.UseVisualStyleBackColor = true;
            this.btnAnteriorImagen.Click += new System.EventHandler(this.btnAnteriorImagen_Click);
            // 
            // btnSiguienteImagen
            // 
            this.btnSiguienteImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguienteImagen.Location = new System.Drawing.Point(628, 213);
            this.btnSiguienteImagen.Name = "btnSiguienteImagen";
            this.btnSiguienteImagen.Size = new System.Drawing.Size(19, 23);
            this.btnSiguienteImagen.TabIndex = 8;
            this.btnSiguienteImagen.TabStop = false;
            this.btnSiguienteImagen.Text = ">";
            this.btnSiguienteImagen.UseVisualStyleBackColor = true;
            this.btnSiguienteImagen.Click += new System.EventHandler(this.btnSiguienteImagen_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregarImagen.Location = new System.Drawing.Point(354, 360);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(21, 23);
            this.btnAgregarImagen.TabIndex = 7;
            this.btnAgregarImagen.Text = "✓";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEditarCodigo
            // 
            this.btnEditarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCodigo.Image")));
            this.btnEditarCodigo.Location = new System.Drawing.Point(354, 59);
            this.btnEditarCodigo.Name = "btnEditarCodigo";
            this.btnEditarCodigo.Size = new System.Drawing.Size(31, 34);
            this.btnEditarCodigo.TabIndex = 21;
            this.btnEditarCodigo.UseVisualStyleBackColor = true;
            this.btnEditarCodigo.Click += new System.EventHandler(this.btnEditarCodigo_Click);
            // 
            // btnEditarNombre
            // 
            this.btnEditarNombre.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarNombre.Image")));
            this.btnEditarNombre.Location = new System.Drawing.Point(354, 99);
            this.btnEditarNombre.Name = "btnEditarNombre";
            this.btnEditarNombre.Size = new System.Drawing.Size(31, 34);
            this.btnEditarNombre.TabIndex = 22;
            this.btnEditarNombre.UseVisualStyleBackColor = true;
            this.btnEditarNombre.Click += new System.EventHandler(this.btnEditarNombre_Click);
            // 
            // btnEditarDesc
            // 
            this.btnEditarDesc.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDesc.Image")));
            this.btnEditarDesc.Location = new System.Drawing.Point(354, 144);
            this.btnEditarDesc.Name = "btnEditarDesc";
            this.btnEditarDesc.Size = new System.Drawing.Size(31, 34);
            this.btnEditarDesc.TabIndex = 23;
            this.btnEditarDesc.UseVisualStyleBackColor = true;
            this.btnEditarDesc.Click += new System.EventHandler(this.btnEditarDesc_Click);
            // 
            // btnEditarCat
            // 
            this.btnEditarCat.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCat.Image")));
            this.btnEditarCat.Location = new System.Drawing.Point(354, 270);
            this.btnEditarCat.Name = "btnEditarCat";
            this.btnEditarCat.Size = new System.Drawing.Size(31, 34);
            this.btnEditarCat.TabIndex = 24;
            this.btnEditarCat.UseVisualStyleBackColor = true;
            this.btnEditarCat.Click += new System.EventHandler(this.btnEditarCat_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMarca.Image")));
            this.btnEditarMarca.Location = new System.Drawing.Point(354, 227);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(31, 34);
            this.btnEditarMarca.TabIndex = 25;
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEditarPrecio
            // 
            this.btnEditarPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPrecio.Image")));
            this.btnEditarPrecio.Location = new System.Drawing.Point(354, 311);
            this.btnEditarPrecio.Name = "btnEditarPrecio";
            this.btnEditarPrecio.Size = new System.Drawing.Size(31, 34);
            this.btnEditarPrecio.TabIndex = 26;
            this.btnEditarPrecio.UseVisualStyleBackColor = true;
            this.btnEditarPrecio.Click += new System.EventHandler(this.btnEditarPrecio_Click);
            // 
            // btnModificarTodos
            // 
            this.btnModificarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTodos.Location = new System.Drawing.Point(354, 27);
            this.btnModificarTodos.Name = "btnModificarTodos";
            this.btnModificarTodos.Size = new System.Drawing.Size(112, 26);
            this.btnModificarTodos.TabIndex = 27;
            this.btnModificarTodos.Text = "Modificar todos";
            this.btnModificarTodos.UseVisualStyleBackColor = true;
            this.btnModificarTodos.Click += new System.EventHandler(this.btnModificarTodos_Click);
            // 
            // btnLimpiarTxtImagen
            // 
            this.btnLimpiarTxtImagen.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLimpiarTxtImagen.Location = new System.Drawing.Point(381, 360);
            this.btnLimpiarTxtImagen.Name = "btnLimpiarTxtImagen";
            this.btnLimpiarTxtImagen.Size = new System.Drawing.Size(21, 23);
            this.btnLimpiarTxtImagen.TabIndex = 8;
            this.btnLimpiarTxtImagen.Text = "✕";
            this.btnLimpiarTxtImagen.UseVisualStyleBackColor = false;
            this.btnLimpiarTxtImagen.Click += new System.EventHandler(this.btnLimpiarTxtImagen_Click);
            // 
            // btnEditarImagenes
            // 
            this.btnEditarImagenes.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarImagenes.Image")));
            this.btnEditarImagenes.Location = new System.Drawing.Point(354, 352);
            this.btnEditarImagenes.Name = "btnEditarImagenes";
            this.btnEditarImagenes.Size = new System.Drawing.Size(31, 34);
            this.btnEditarImagenes.TabIndex = 29;
            this.btnEditarImagenes.UseVisualStyleBackColor = true;
            this.btnEditarImagenes.Click += new System.EventHandler(this.btnEditarImagenes_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 526);
            this.Controls.Add(this.btnEditarImagenes);
            this.Controls.Add(this.btnLimpiarTxtImagen);
            this.Controls.Add(this.btnModificarTodos);
            this.Controls.Add(this.btnEditarPrecio);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnEditarCat);
            this.Controls.Add(this.btnEditarDesc);
            this.Controls.Add(this.btnEditarNombre);
            this.Controls.Add(this.btnEditarCodigo);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.btnSiguienteImagen);
            this.Controls.Add(this.btnAnteriorImagen);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblAltaPrecio);
            this.Controls.Add(this.lblAltaCategoria);
            this.Controls.Add(this.lblAltaMarca);
            this.Controls.Add(this.lblAltaDescripcion);
            this.Controls.Add(this.lblAltaNombre);
            this.Controls.Add(this.lblAltaCodigo);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltaCodigo;
        private System.Windows.Forms.Label lblAltaNombre;
        private System.Windows.Forms.Label lblAltaDescripcion;
        private System.Windows.Forms.Label lblAltaMarca;
        private System.Windows.Forms.Label lblAltaCategoria;
        private System.Windows.Forms.Label lblAltaPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.Button btnAnteriorImagen;
        private System.Windows.Forms.Button btnSiguienteImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEditarCodigo;
        private System.Windows.Forms.Button btnEditarNombre;
        private System.Windows.Forms.Button btnEditarDesc;
        private System.Windows.Forms.Button btnEditarCat;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnEditarPrecio;
        private System.Windows.Forms.Button btnModificarTodos;
        private System.Windows.Forms.Button btnLimpiarTxtImagen;
        private System.Windows.Forms.Button btnEditarImagenes;
    }
}