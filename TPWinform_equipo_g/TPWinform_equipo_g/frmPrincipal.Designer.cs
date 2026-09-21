namespace TPWinform_equipo_g
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
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.bt_Categoria = new System.Windows.Forms.Button();
            this.bt_Marca = new System.Windows.Forms.Button();
            this.bt_Articulo = new System.Windows.Forms.Button();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.dgv_BaseDatos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.btnAnteriorImagen = new System.Windows.Forms.Button();
            this.btnSiguienteImagen = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblDetalleArticulo = new System.Windows.Forms.Label();
            this.lblCodigoD = new System.Windows.Forms.Label();
            this.lblNombreD = new System.Windows.Forms.Label();
            this.lblDescripcionD = new System.Windows.Forms.Label();
            this.lblMarcaD = new System.Windows.Forms.Label();
            this.lblPrecioD = new System.Windows.Forms.Label();
            this.lblCategoriaD = new System.Windows.Forms.Label();
            this.lblCodigoDetalle = new System.Windows.Forms.Label();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.lblMarcaDetalle = new System.Windows.Forms.Label();
            this.lblCategoriaDetalle = new System.Windows.Forms.Label();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.lblBorrarBusqueda = new System.Windows.Forms.Label();
            this.lblColumna = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbColumna = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroBaseDatos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaseDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(19, 27);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(129, 75);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Buscar.BackColor = System.Drawing.Color.LightGray;
            this.bt_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Buscar.Location = new System.Drawing.Point(80, 294);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(86, 20);
            this.bt_Buscar.TabIndex = 2;
            this.bt_Buscar.Text = "Buscar";
            this.bt_Buscar.UseVisualStyleBackColor = false;
            this.bt_Buscar.Visible = false;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click_1);
            // 
            // bt_Categoria
            // 
            this.bt_Categoria.BackColor = System.Drawing.Color.Azure;
            this.bt_Categoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Categoria.Location = new System.Drawing.Point(362, 33);
            this.bt_Categoria.Name = "bt_Categoria";
            this.bt_Categoria.Size = new System.Drawing.Size(146, 30);
            this.bt_Categoria.TabIndex = 3;
            this.bt_Categoria.Text = "Categorias";
            this.bt_Categoria.UseVisualStyleBackColor = false;
            this.bt_Categoria.Click += new System.EventHandler(this.bt_Categoria_Click);
            // 
            // bt_Marca
            // 
            this.bt_Marca.BackColor = System.Drawing.Color.Azure;
            this.bt_Marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Marca.Location = new System.Drawing.Point(524, 33);
            this.bt_Marca.Name = "bt_Marca";
            this.bt_Marca.Size = new System.Drawing.Size(146, 30);
            this.bt_Marca.TabIndex = 4;
            this.bt_Marca.Text = "Marcas";
            this.bt_Marca.UseVisualStyleBackColor = false;
            this.bt_Marca.Click += new System.EventHandler(this.bt_Marca_Click);
            // 
            // bt_Articulo
            // 
            this.bt_Articulo.BackColor = System.Drawing.Color.Azure;
            this.bt_Articulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Articulo.Location = new System.Drawing.Point(201, 33);
            this.bt_Articulo.Name = "bt_Articulo";
            this.bt_Articulo.Size = new System.Drawing.Size(146, 30);
            this.bt_Articulo.TabIndex = 5;
            this.bt_Articulo.Text = "Articulos";
            this.bt_Articulo.UseVisualStyleBackColor = false;
            this.bt_Articulo.Click += new System.EventHandler(this.bt_Articulo_Click);
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Buscador.Location = new System.Drawing.Point(721, 43);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(291, 20);
            this.txt_Buscador.TabIndex = 6;
            this.txt_Buscador.Text = "Buscar...";
            this.txt_Buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Buscador.TextChanged += new System.EventHandler(this.txt_Buscador_TextChanged);
            this.txt_Buscador.Enter += new System.EventHandler(this.txt_Buscador_Enter);
            this.txt_Buscador.Leave += new System.EventHandler(this.txt_Buscador_Leave);
            // 
            // dgv_BaseDatos
            // 
            this.dgv_BaseDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BaseDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BaseDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_BaseDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BaseDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_BaseDatos.Location = new System.Drawing.Point(226, 138);
            this.dgv_BaseDatos.MaximumSize = new System.Drawing.Size(652, 196);
            this.dgv_BaseDatos.MinimumSize = new System.Drawing.Size(652, 407);
            this.dgv_BaseDatos.MultiSelect = false;
            this.dgv_BaseDatos.Name = "dgv_BaseDatos";
            this.dgv_BaseDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BaseDatos.Size = new System.Drawing.Size(652, 407);
            this.dgv_BaseDatos.TabIndex = 7;
            this.dgv_BaseDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BaseDatos_CellClick);
            this.dgv_BaseDatos.SelectionChanged += new System.EventHandler(this.dgv_BaseDatos_SelectionChanged);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulos.Location = new System.Drawing.Point(953, 89);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(216, 187);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 8;
            this.pbxArticulos.TabStop = false;
            // 
            // btnAnteriorImagen
            // 
            this.btnAnteriorImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnteriorImagen.Location = new System.Drawing.Point(928, 167);
            this.btnAnteriorImagen.Name = "btnAnteriorImagen";
            this.btnAnteriorImagen.Size = new System.Drawing.Size(19, 23);
            this.btnAnteriorImagen.TabIndex = 9;
            this.btnAnteriorImagen.Text = "<";
            this.btnAnteriorImagen.UseVisualStyleBackColor = true;
            this.btnAnteriorImagen.Click += new System.EventHandler(this.btnAnteriorImagen_Click);
            // 
            // btnSiguienteImagen
            // 
            this.btnSiguienteImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguienteImagen.Location = new System.Drawing.Point(1175, 167);
            this.btnSiguienteImagen.Name = "btnSiguienteImagen";
            this.btnSiguienteImagen.Size = new System.Drawing.Size(19, 23);
            this.btnSiguienteImagen.TabIndex = 10;
            this.btnSiguienteImagen.Text = ">";
            this.btnSiguienteImagen.UseVisualStyleBackColor = true;
            this.btnSiguienteImagen.Click += new System.EventHandler(this.btnSiguienteImagen_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(641, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 21);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(801, 111);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 21);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(721, 111);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 21);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblDetalleArticulo
            // 
            this.lblDetalleArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetalleArticulo.AutoSize = true;
            this.lblDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDetalleArticulo.Location = new System.Drawing.Point(1033, 294);
            this.lblDetalleArticulo.Name = "lblDetalleArticulo";
            this.lblDetalleArticulo.Size = new System.Drawing.Size(68, 13);
            this.lblDetalleArticulo.TabIndex = 14;
            this.lblDetalleArticulo.Text = "Ver detalle";
            this.lblDetalleArticulo.Click += new System.EventHandler(this.lblDetalleArticulo_Click);
            // 
            // lblCodigoD
            // 
            this.lblCodigoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCodigoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoD.Location = new System.Drawing.Point(909, 312);
            this.lblCodigoD.Name = "lblCodigoD";
            this.lblCodigoD.Size = new System.Drawing.Size(109, 22);
            this.lblCodigoD.TabIndex = 16;
            this.lblCodigoD.Text = "Código:";
            // 
            // lblNombreD
            // 
            this.lblNombreD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblNombreD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreD.Location = new System.Drawing.Point(909, 347);
            this.lblNombreD.Name = "lblNombreD";
            this.lblNombreD.Size = new System.Drawing.Size(109, 22);
            this.lblNombreD.TabIndex = 17;
            this.lblNombreD.Text = "Nombre:";
            // 
            // lblDescripcionD
            // 
            this.lblDescripcionD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDescripcionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionD.Location = new System.Drawing.Point(909, 388);
            this.lblDescripcionD.Name = "lblDescripcionD";
            this.lblDescripcionD.Size = new System.Drawing.Size(109, 47);
            this.lblDescripcionD.TabIndex = 18;
            this.lblDescripcionD.Text = "Descripción:";
            // 
            // lblMarcaD
            // 
            this.lblMarcaD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarcaD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblMarcaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaD.Location = new System.Drawing.Point(909, 451);
            this.lblMarcaD.Name = "lblMarcaD";
            this.lblMarcaD.Size = new System.Drawing.Size(109, 22);
            this.lblMarcaD.TabIndex = 19;
            this.lblMarcaD.Text = "Marca:";
            // 
            // lblPrecioD
            // 
            this.lblPrecioD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPrecioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioD.Location = new System.Drawing.Point(909, 526);
            this.lblPrecioD.Name = "lblPrecioD";
            this.lblPrecioD.Size = new System.Drawing.Size(109, 22);
            this.lblPrecioD.TabIndex = 20;
            this.lblPrecioD.Text = "Precio:";
            // 
            // lblCategoriaD
            // 
            this.lblCategoriaD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriaD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCategoriaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaD.Location = new System.Drawing.Point(909, 488);
            this.lblCategoriaD.Name = "lblCategoriaD";
            this.lblCategoriaD.Size = new System.Drawing.Size(109, 22);
            this.lblCategoriaD.TabIndex = 21;
            this.lblCategoriaD.Text = "Categoria:";
            // 
            // lblCodigoDetalle
            // 
            this.lblCodigoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblCodigoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDetalle.Location = new System.Drawing.Point(1033, 315);
            this.lblCodigoDetalle.Name = "lblCodigoDetalle";
            this.lblCodigoDetalle.Size = new System.Drawing.Size(192, 19);
            this.lblCodigoDetalle.TabIndex = 22;
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombreDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDetalle.Location = new System.Drawing.Point(1033, 350);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(192, 19);
            this.lblNombreDetalle.TabIndex = 23;
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(1033, 388);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(192, 47);
            this.lblDescripcionDetalle.TabIndex = 24;
            // 
            // lblMarcaDetalle
            // 
            this.lblMarcaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarcaDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblMarcaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaDetalle.Location = new System.Drawing.Point(1033, 454);
            this.lblMarcaDetalle.Name = "lblMarcaDetalle";
            this.lblMarcaDetalle.Size = new System.Drawing.Size(192, 19);
            this.lblMarcaDetalle.TabIndex = 25;
            // 
            // lblCategoriaDetalle
            // 
            this.lblCategoriaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoriaDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblCategoriaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDetalle.Location = new System.Drawing.Point(1033, 491);
            this.lblCategoriaDetalle.Name = "lblCategoriaDetalle";
            this.lblCategoriaDetalle.Size = new System.Drawing.Size(192, 19);
            this.lblCategoriaDetalle.TabIndex = 26;
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioDetalle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDetalle.Location = new System.Drawing.Point(1033, 526);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(192, 19);
            this.lblPrecioDetalle.TabIndex = 27;
            // 
            // lblBorrarBusqueda
            // 
            this.lblBorrarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrarBusqueda.AutoSize = true;
            this.lblBorrarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrarBusqueda.Location = new System.Drawing.Point(150, 272);
            this.lblBorrarBusqueda.Name = "lblBorrarBusqueda";
            this.lblBorrarBusqueda.Size = new System.Drawing.Size(16, 15);
            this.lblBorrarBusqueda.TabIndex = 29;
            this.lblBorrarBusqueda.Text = "X";
            this.lblBorrarBusqueda.Visible = false;
            this.lblBorrarBusqueda.Click += new System.EventHandler(this.lblBorrarBusqueda_Click);
            // 
            // lblColumna
            // 
            this.lblColumna.AutoSize = true;
            this.lblColumna.Location = new System.Drawing.Point(44, 155);
            this.lblColumna.Name = "lblColumna";
            this.lblColumna.Size = new System.Drawing.Size(48, 13);
            this.lblColumna.TabIndex = 30;
            this.lblColumna.Text = "Columna";
            this.lblColumna.Visible = false;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(44, 211);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 31;
            this.lblCriterio.Text = "Criterio";
            this.lblCriterio.Visible = false;
            // 
            // cbColumna
            // 
            this.cbColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumna.FormattingEnabled = true;
            this.cbColumna.Location = new System.Drawing.Point(44, 171);
            this.cbColumna.Name = "cbColumna";
            this.cbColumna.Size = new System.Drawing.Size(121, 21);
            this.cbColumna.TabIndex = 32;
            this.cbColumna.Visible = false;
            this.cbColumna.SelectedIndexChanged += new System.EventHandler(this.cbColumna_SelectedIndexChanged_1);
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(44, 227);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbCriterio.TabIndex = 33;
            this.cbCriterio.Visible = false;
            // 
            // txtFiltroBaseDatos
            // 
            this.txtFiltroBaseDatos.Enabled = false;
            this.txtFiltroBaseDatos.Location = new System.Drawing.Point(44, 267);
            this.txtFiltroBaseDatos.Name = "txtFiltroBaseDatos";
            this.txtFiltroBaseDatos.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroBaseDatos.TabIndex = 34;
            this.txtFiltroBaseDatos.Visible = false;
            this.txtFiltroBaseDatos.TextChanged += new System.EventHandler(this.txtFiltroBaseDatos_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 582);
            this.Controls.Add(this.txtFiltroBaseDatos);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.cbColumna);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblColumna);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblCategoriaDetalle);
            this.Controls.Add(this.lblMarcaDetalle);
            this.Controls.Add(this.lblDescripcionDetalle);
            this.Controls.Add(this.lblNombreDetalle);
            this.Controls.Add(this.lblCodigoDetalle);
            this.Controls.Add(this.lblCategoriaD);
            this.Controls.Add(this.lblPrecioD);
            this.Controls.Add(this.lblMarcaD);
            this.Controls.Add(this.lblDescripcionD);
            this.Controls.Add(this.lblNombreD);
            this.Controls.Add(this.lblCodigoD);
            this.Controls.Add(this.lblDetalleArticulo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSiguienteImagen);
            this.Controls.Add(this.btnAnteriorImagen);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgv_BaseDatos);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.bt_Articulo);
            this.Controls.Add(this.bt_Marca);
            this.Controls.Add(this.bt_Categoria);
            this.Controls.Add(this.bt_Buscar);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.lblBorrarBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1448, 700);
            this.MinimumSize = new System.Drawing.Size(1250, 621);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaseDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button bt_Buscar;
        private System.Windows.Forms.Button bt_Categoria;
        private System.Windows.Forms.Button bt_Marca;
        private System.Windows.Forms.Button bt_Articulo;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.DataGridView dgv_BaseDatos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Button btnAnteriorImagen;
        private System.Windows.Forms.Button btnSiguienteImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblDetalleArticulo;
        private System.Windows.Forms.Label lblCodigoD;
        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.Label lblDescripcionD;
        private System.Windows.Forms.Label lblMarcaD;
        private System.Windows.Forms.Label lblPrecioD;
        private System.Windows.Forms.Label lblCategoriaD;
        private System.Windows.Forms.Label lblCodigoDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.Label lblMarcaDetalle;
        private System.Windows.Forms.Label lblCategoriaDetalle;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.Label lblBorrarBusqueda;
        private System.Windows.Forms.Label lblColumna;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbColumna;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.TextBox txtFiltroBaseDatos;
    }
}

