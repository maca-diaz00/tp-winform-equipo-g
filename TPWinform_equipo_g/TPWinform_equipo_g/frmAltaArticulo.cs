using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinform_equipo_g
{
    public partial class frmAltaArticulo : Form
    {

        private CategoriaNegocio categoriaNegocio;
        private MarcaNegocio marcaNegocio;
        private Articulo nuevoArticulo;
        private ArticuloNegocio articuloNegocio;
        private ImagenNegocio imagenNegocio;
        private Imagen aux;
        private int indiceImagen;

        

        public frmAltaArticulo()
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            articuloNegocio = new ArticuloNegocio();
            nuevoArticulo = new Articulo();
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
                cbxMarca.DataSource = marcaNegocio.listar();
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

                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.Marca = (Marca)cbxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                nuevoArticulo.Precio =decimal.Parse(txtPrecio.Text);

                articuloNegocio.nuevoArticulo(nuevoArticulo);


                /*int nuevasImagenes = nuevoArticulo.cantidadImagenes();
                for(int i = 0; i < nuevasImagenes; i++)
                {
                    aux = new Imagen();
                    aux.IdArticulo = nuevoArticulo.Id;
                    aux.UrlImagen = nuevoArticulo.Imagenes[i].UrlImagen;

                    imagenNegocio.nuevaImagen(aux);
                }
                */
                /*no se como encarar esta parte porque no se como recuperar el ID que va a generar
                la bbdd*/


                MessageBox.Show("Articulo creado exitosamente!");
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
            nuevoArticulo.agregarImagen(txtImagen.Text);
            txtImagen.Text = "";
            indiceImagen = nuevoArticulo.cantidadImagenes() - 1;
            mostrarImagen(nuevoArticulo, indiceImagen);
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
            nuevoArticulo.Imagenes.RemoveAt(indiceImagen);
            
            if (indiceImagen == nuevoArticulo.cantidadImagenes())
            {
                indiceImagen--;
            }

            if (nuevoArticulo.cantidadImagenes() != 0)
            {
                mostrarImagen(nuevoArticulo, indiceImagen);
            }

            actualizarBotonesImagenes();
        }

        private void btnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (indiceImagen > 0)
            {
                indiceImagen--;
                actualizarBotonesImagenes();
                mostrarImagen(nuevoArticulo, indiceImagen);
            }

        }

        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (indiceImagen < nuevoArticulo.cantidadImagenes() - 1)
            {
                indiceImagen++;
                actualizarBotonesImagenes();
                mostrarImagen(nuevoArticulo, indiceImagen);
            }

        }

        private void actualizarBotonesImagenes()
        {
            if (nuevoArticulo.cantidadImagenes() ==0)
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


                if (indiceImagen == nuevoArticulo.cantidadImagenes() - 1)
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
