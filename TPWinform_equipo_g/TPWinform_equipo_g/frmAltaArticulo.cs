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
        private Articulo articulo=null;
        private ArticuloNegocio articuloNegocio;
        private ImagenNegocio imagenNegocio;
        private Imagen imagenAux;
        private int indiceImagen;

        

        public frmAltaArticulo()
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            articuloNegocio = new ArticuloNegocio();
            imagenNegocio = new ImagenNegocio();
            

        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            Text = "Modificar articulo";
            this.articulo = articulo;
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            articuloNegocio = new ArticuloNegocio();
            imagenNegocio = new ImagenNegocio();


        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            btnSiguienteImagen.Visible = false;
            btnAnteriorImagen.Visible = false;
            btnEliminarImagen.Visible = false;
            
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtNombre.Text = articulo.Nombre;
                    //ver como encarar las imagenes
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
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio =decimal.Parse(txtPrecio.Text);
                if (articulo.cantidadImagenes() == 0)
                {
                    articulo.agregarImagen("");
                }


                /*int nuevasImagenes = nuevoArticulo.cantidadImagenes();
                for(int i = 0; i < nuevasImagenes; i++)
                {
                    imagenAux = new Imagen();
                    imagenAux.IdArticulo = nuevoArticulo.Id;
                    imagenAux.UrlImagen = nuevoArticulo.Imagenes[i].UrlImagen;

                    imagenNegocio.nuevaImagen(imagenAux);
                }
                */
                /*no se como encarar esta parte porque no se como recuperar el ID que va a generar
                la bbdd*/
                if (articulo.Id != 0)
                {
                    articuloNegocio.modificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado exitosamente!");
                }
                else
                {
                    articuloNegocio.nuevoArticulo(articulo);
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
    }
}
