using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace TPWinform_equipo_g
{
    public partial class frmAltaArticulo : Form
    {

        private CategoriaNegocio categoriaNegocio;
        private MarcaNegocio marcaNegocio;
        private Articulo articulo;
        private ArticuloNegocio articuloNegocio;
        private ImagenNegocio imagenNegocio;
        private Imagen imagenAux;
        private int indiceImagen;
        bool modificacion;




        public frmAltaArticulo()
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            articuloNegocio = new ArticuloNegocio();
            imagenNegocio = new ImagenNegocio();
            articulo = new Articulo();
            botonesEditar(false);
            txtHabilitados(true);
            modificacion = false;

        }


        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            Text = "Editar articulo";
            this.articulo = articulo;
            botonesEditar(true);
            txtHabilitados(false);
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            articuloNegocio = new ArticuloNegocio();
            imagenNegocio = new ImagenNegocio();
            modificacion = true;



        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            
            
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.SelectedIndex = -1;

                actualizarBotonesImagenes();

                if (modificacion)
                {
                    mostrarImagen(articulo,0);
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!modificacion)
                {
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    if (articulo.cantidadImagenes() == 0)
                    {
                        articulo.agregarImagen("");
                    }
                }

                
                if (modificacion)
                {
                    articuloNegocio.modificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado exitosamente!");
                }
                else
                {
                    int nuevasImagenes = articulo.cantidadImagenes();
                    articuloNegocio.nuevoArticulo(articulo);
                    for(int i = 0; i < nuevasImagenes; i++)
                    {
                        imagenAux = new Imagen();
                        imagenAux.IdArticulo = articulo.Id;
                        imagenAux.UrlImagen = articulo.Imagenes[i].UrlImagen;

                        imagenNegocio.nuevaImagen(imagenAux);
                    }
                    MessageBox.Show("Articulo creado exitosamente!");

                }

                Close();

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
                pbxImagen.Visible = true;
            try
            {
                pbxImagen.Load(txtImagen.Text);
            }
            catch (Exception)
            {

                pbxImagen.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            articulo.agregarImagen(txtImagen.Text);
            txtImagen.Text = "";
            indiceImagen = articulo.cantidadImagenes() - 1;
            mostrarImagen(articulo, indiceImagen);
            btnEliminarImagen.Visible = true;
            actualizarBotonesImagenes();

        }

            private void mostrarImagen(Articulo articulo, int indice)
        {
            try
            {
                pbxImagen.Load(articulo.Imagenes[indice].UrlImagen);
            }
            catch (Exception)
            {

                pbxImagen.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }
        

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            articulo.Imagenes.RemoveAt(indiceImagen);
            
            if (indiceImagen == articulo.cantidadImagenes())
            {
                indiceImagen--;
            }

            if (articulo.cantidadImagenes() != 0)
            {
                mostrarImagen(articulo, indiceImagen);
            }

            actualizarBotonesImagenes();
        }

        private void btnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (indiceImagen > 0)
            {
                indiceImagen--;
                actualizarBotonesImagenes();
                mostrarImagen(articulo, indiceImagen);
            }

        }

        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (indiceImagen < articulo.cantidadImagenes() - 1)
            {
                indiceImagen++;
                actualizarBotonesImagenes();
                mostrarImagen(articulo, indiceImagen);
            }

        }

        private void actualizarBotonesImagenes()
        {
            if (articulo.cantidadImagenes() ==0)
            {
                btnAnteriorImagen.Visible = false;
                btnSiguienteImagen.Visible = false;
                btnEliminarImagen.Visible = false;
                pbxImagen.Visible = false;
            }
            else
            {
                btnSiguienteImagen.Visible = true;
                btnAnteriorImagen.Visible = true;
                //pbxImagen.Visible = true;

                if (indiceImagen == 0)
                {
                    btnAnteriorImagen.Enabled = false;
                }
                else
                {
                    btnAnteriorImagen.Enabled = true;
                }


                if (indiceImagen == articulo.cantidadImagenes() - 1)
                {
                    btnSiguienteImagen.Enabled = false;
                }
                else
                {
                    btnSiguienteImagen.Enabled = true;
                }
                
            }
        }

        private void btnModificarTodos_Click(object sender, EventArgs e)
        {
            
            txtHabilitados(true);
            botonesEditar(false);
        }

        private void txtHabilitados(bool habilitar)
        {
            txtCodigo.Enabled = habilitar;
            txtNombre.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            cbxMarca.Enabled = habilitar;
            cbxCategoria.Enabled = habilitar;
            txtPrecio.Enabled = habilitar;
            txtImagen.Enabled = habilitar;
            

        }
        private void botonesEditar(bool mostrar)
        {
            btnModificarTodos.Visible = mostrar;
            btnEditarCodigo.Visible = mostrar;
            btnEditarNombre.Visible = mostrar;
            btnEditarDesc.Visible = mostrar;
            btnEditarMarca.Visible = mostrar;
            btnEditarCat.Visible = mostrar;
            btnEditarPrecio.Visible = mostrar;
            btnEditarImagenes.Visible = mostrar;
            btnAgregarImagen.Visible = mostrar;
            btnLimpiarTxtImagen.Visible = mostrar;
            btnEliminarImagen.Visible = mostrar;
            btnAgregarImagen.Visible = !mostrar;
            btnEliminarImagen.Visible = !mostrar;
            btnLimpiarTxtImagen.Visible = !mostrar;
        }

        private void btnEditarCodigo_Click(object sender, EventArgs e)
        {
            btnEditarCodigo.Visible = false;
            
            txtCodigo.Enabled = true;
            
        }

        private void btnEditarNombre_Click(object sender, EventArgs e)
        {
            btnEditarNombre.Visible = false;
            
            txtNombre.Enabled = true;
        }

        private void btnEditarDesc_Click(object sender, EventArgs e)
        {
            btnEditarDesc.Visible = false;
            
            txtDescripcion.Enabled = true;
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            btnEditarMarca.Visible = false;
            
            cbxMarca.Enabled = true;
        }

        private void btnEditarCat_Click(object sender, EventArgs e)
        {
            btnEditarCat.Visible = false;
            
            cbxCategoria.Enabled = true;
        }

        private void btnEditarPrecio_Click(object sender, EventArgs e)
        {
            btnEditarPrecio.Visible = false;
            txtPrecio.Enabled = true;
        }

        private void btnEditarImagenes_Click(object sender, EventArgs e)
        {
            btnEditarImagenes.Visible = false;
            txtImagen.Enabled = true;
            btnAgregarImagen.Visible = true;
            btnLimpiarTxtImagen.Visible = true;
            btnEliminarImagen.Visible = true;
        }
        private void btnLimpiarTxtImagen_Click(object sender, EventArgs e)
        {
            txtImagen.Text = "";
        }


    }
}
