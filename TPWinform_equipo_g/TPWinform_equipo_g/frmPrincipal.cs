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
    public partial class frmPrincipal : Form
    {

        private ArticuloNegocio articuloNegocio;
        private Articulo articuloActual;
        private string tipoListado;
        private int indiceImagen;
        private frmAltaArticulo frmAltaArticulo;
        CategoriaNegocio categoriaNegocio;
        MarcaNegocio marcaNegocio;
        frmAltaMarca frmAltaMarca;

        public frmPrincipal()
        {
            InitializeComponent();
            articuloNegocio = new ArticuloNegocio();
            articuloActual = new Articulo();
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();

        }



        private void txt_Buscador_Enter(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == "Buscar...")
            {
                txt_Buscador.Text = "";
                txt_Buscador.ForeColor = Color.Black;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == "")
            {
                txt_Buscador.Text = "Buscar...";
                txt_Buscador.ForeColor = Color.Gray;
            }

            dgv_BaseDatos.Visible = false;
            btnAnteriorImagen.Visible = false;
            btnSiguienteImagen.Visible = false;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = false;
            lblDetalleArticulo.Visible = false;
            lblOcultarDetalle.Visible = false;
            mostrarDetalleArticulo(false);
        }

        private void txt_Buscador_Leave(object sender, EventArgs e)
        {
            if (txt_Buscador.Text == "")
            {
                txt_Buscador.Text = "Buscar...";
                txt_Buscador.ForeColor = Color.Gray;
            }
        }

        private void bt_Categoria_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false || tipoListado != "Categoria")
            {
                tipoListado = "Categoria";
                cargarDgv();
                dgv_BaseDatos.Visible = true;
                btnAgregar.Visible = true;
                btnEliminar.Visible = true;
                btnEditar.Visible = true;
                mostrarDetalleArticulo(false);
                if (dgv_BaseDatos.Columns.Contains("Id"))
                    dgv_BaseDatos.Columns["Id"].Visible = false;
            }
            else if (dgv_BaseDatos.Visible == true && tipoListado == "Categoria")
            {
                dgv_BaseDatos.Visible = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;

            }

        }

        private void bt_Marca_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false || tipoListado != "Marca")
            {
                tipoListado = "Marca";
                cargarDgv();
                dgv_BaseDatos.Visible = true;
                btnAgregar.Visible = true;
                btnEliminar.Visible = true;
                btnEditar.Visible = true;
                mostrarDetalleArticulo(false);
                dgv_BaseDatos.Columns["Id"].Visible = false;
            }
            else if (dgv_BaseDatos.Visible == true && tipoListado == "Marca")
            {
                dgv_BaseDatos.Visible = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
                dgv_BaseDatos.Columns["Id"].Visible = false;

            }

        }

        private void bt_Articulo_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false || tipoListado != "Articulo")
            {
                tipoListado = "Articulo";
                cargarDgv();
                dgv_BaseDatos.Columns["Id"].Visible = false;
                dgv_BaseDatos.Columns["Codigo"].Visible = false;
                dgv_BaseDatos.Columns["Categoria"].Visible = false;
                dgv_BaseDatos.Visible = true;
                btnAgregar.Visible = true;
                btnEliminar.Visible = true;
                btnEditar.Visible = true;
            } else if (dgv_BaseDatos.Visible == true && tipoListado == "Articulo")
            {
                dgv_BaseDatos.Columns["Id"].Visible = false;
                dgv_BaseDatos.Columns["Codigo"].Visible = false;
                dgv_BaseDatos.Columns["Categoria"].Visible = false;
                dgv_BaseDatos.Visible = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;

            }





        }



        private void mostrarImagen(Articulo articulo, int indice)
        {
            try
            {
                pbxArticulos.Load(articulo.Imagenes[indice].UrlImagen);
            }
            catch (Exception)
            {

                pbxArticulos.Load("https://media.istockphoto.com/id/1980276924/es/vector/sin-elemento-gr%C3%A1fico-en-miniatura-de-la-foto-no-se-ha-encontrado-ninguna-imagen-o-est%C3%A1.jpg?s=612x612&w=0&k=20&c=artWlQoi5R1edWQBv9LfzeLXupOcH_alZnMgvXdYkF4=");
            }
        }

        private void dgv_BaseDatos_SelectionChanged(object sender, EventArgs e)
        {

            if (tipoListado != "Articulo")
            {

                btnAnteriorImagen.Visible = false;
                btnSiguienteImagen.Visible = false;
                pbxArticulos.Visible = false;
                lblDetalleArticulo.Visible = false;


            }
            mostrarDetalleArticulo(false);


        }

        private void dgv_BaseDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoListado == "Articulo")
            {
                articuloActual = (Articulo)dgv_BaseDatos.CurrentRow.DataBoundItem;
                btnAnteriorImagen.Visible = true;
                btnSiguienteImagen.Visible = true;
                pbxArticulos.Visible = true;
                lblDetalleArticulo.Visible = true;
                lblOcultarDetalle.Visible = false;
                indiceImagen = 0;
                actualizarBotonesImagenes();
                mostrarImagen(articuloActual, indiceImagen);
            }
        }


        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {


            if (indiceImagen < articuloActual.cantidadImagenes() - 1)
            {
                indiceImagen++;
                actualizarBotonesImagenes();
                mostrarImagen(articuloActual, indiceImagen);
            }

        }

        private void btnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (indiceImagen > 0)
            {
                indiceImagen--;
                actualizarBotonesImagenes();
                mostrarImagen(articuloActual, indiceImagen);
            }
        }

        private void actualizarBotonesImagenes()
        {
            if (indiceImagen == 0)
            {
                btnAnteriorImagen.Enabled = false;
            }
            else
            {
                btnAnteriorImagen.Enabled = true;
            }


            if (indiceImagen == articuloActual.cantidadImagenes() - 1)
            {
                btnSiguienteImagen.Enabled = false;
            }
            else
            {
                btnSiguienteImagen.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tipoListado == "Articulo")
            {
                frmAltaArticulo = new frmAltaArticulo();
                frmAltaArticulo.Text = "Nuevo Articulo";
                frmAltaArticulo.ShowDialog();
            }
            else if (tipoListado == "Marca")
            {
                frmAltaMarca = new frmAltaMarca();
                frmAltaMarca.ShowDialog();
                cargarDgv();
            }
            else if (tipoListado == "Categoria")
            {
                frmAltaCategoria frmAltaCategoria = new frmAltaCategoria();
                frmAltaCategoria.ShowDialog();
                cargarDgv();
            }
        }
       



        private void mostrarDetalleArticulo(bool mostrar)
        {

            lblCodigoD.Visible = mostrar;
            lblNombreD.Visible = mostrar;
            lblDescripcionD.Visible = mostrar;
            lblMarcaD.Visible = mostrar;
            lblCategoriaD.Visible = mostrar;
            lblPrecioD.Visible = mostrar;
            lblCodigoDetalle.Visible = mostrar;
            lblNombreDetalle.Visible = mostrar;
            lblDescripcionDetalle.Visible = mostrar;
            lblMarcaDetalle.Visible = mostrar;
            lblCategoriaDetalle.Visible = mostrar;
            lblPrecioDetalle.Visible = mostrar;

            lblCodigoDetalle.Text = articuloActual.Codigo;
            lblNombreDetalle.Text = articuloActual.Nombre;
            lblDescripcionDetalle.Text = articuloActual.Descripcion;
            lblMarcaDetalle.Text = articuloActual.Marca.Descripcion;
            lblCategoriaDetalle.Text = articuloActual.Categoria.Descripcion;
            lblPrecioDetalle.Text = articuloActual.Precio.ToString();




        }

        private void lblDetalleArticulo_Click(object sender, EventArgs e)
        {
            mostrarDetalleArticulo(true);
            lblDetalleArticulo.Visible = false;
            lblOcultarDetalle.Visible = true;
        }

        private void lblOcultarDetalle_Click(object sender, EventArgs e)
        {
            mostrarDetalleArticulo(false);
            lblOcultarDetalle.Visible = false;
            lblDetalleArticulo.Visible = true;
        }

        private void lblBorrarBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tipoListado == "Articulo")
            {
                frmAltaArticulo = new frmAltaArticulo(articuloActual);
                frmAltaArticulo.ShowDialog();

            }
            else if (tipoListado == "Marca")
            {
                Marca marcaSeleccionada;
                marcaSeleccionada = (Marca)dgv_BaseDatos.CurrentRow.DataBoundItem;//se rompe aca
                frmAltaMarca = new frmAltaMarca(marcaSeleccionada);
                frmAltaMarca.ShowDialog();
            }
            else if (tipoListado == "Categoria")
            {
                Categoria categoriaSeleccionada;
                categoriaSeleccionada = (Categoria)dgv_BaseDatos.CurrentRow.DataBoundItem;//se rompe aca
                frmAltaCategoria frmAltaCategoria = new frmAltaCategoria(categoriaSeleccionada);
                frmAltaCategoria.ShowDialog();
            }
            cargarDgv();
        }

        private void cargarDgv()
        {
            if (tipoListado == "Articulo")
            {
                dgv_BaseDatos.DataSource = null;
                dgv_BaseDatos.DataSource = articuloNegocio.listarArticulos();
            }
            else if (tipoListado == "Categoria")
            {
                dgv_BaseDatos.DataSource = null;
                dgv_BaseDatos.DataSource = categoriaNegocio.listar();
            }
            else if (tipoListado == "Marca")
            {
                dgv_BaseDatos.DataSource = null;
                dgv_BaseDatos.DataSource = marcaNegocio.listar();
            }
        }

        private void txt_Buscador_TextChanged(object sender, EventArgs e)
        {

            if (tipoListado == "Articulo")
            {
                if (txt_Buscador.Text == "" || txt_Buscador.Text == "Buscar...")
                {
                    dgv_BaseDatos.DataSource = articuloNegocio.listarArticulos();
                }
                else
                {
                    List<Articulo> listaFiltrada;
                    listaFiltrada = articuloNegocio.listarArticulos().FindAll(x => x.Nombre.ToUpper().Contains(txt_Buscador.Text.ToUpper()));
                    dgv_BaseDatos.DataSource = listaFiltrada;
                }
            }
            else if (tipoListado == "Marca")
            {
                if (txt_Buscador.Text == "" || txt_Buscador.Text == "Buscar...")
                {
                    dgv_BaseDatos.DataSource = marcaNegocio.listar();
                }
                else
                {
                    List<Marca> listaFiltrada;
                    listaFiltrada = marcaNegocio.listar().FindAll(x => x.Descripcion.ToUpper().Contains(txt_Buscador.Text.ToUpper()));
                    dgv_BaseDatos.DataSource = listaFiltrada;
                }
            }
            else if (tipoListado == "Categoria")
            {
                if (txt_Buscador.Text == "" || txt_Buscador.Text == "Buscar...")
                {
                    dgv_BaseDatos.DataSource = categoriaNegocio.listar();
                }
                else
                {
                    List<Categoria> listaFiltrada;
                    listaFiltrada = categoriaNegocio.listar().FindAll(x => x.Descripcion.ToUpper().Contains(txt_Buscador.Text.ToUpper()));
                    dgv_BaseDatos.DataSource = listaFiltrada;
                }
            }
        }

        
  
    }

}
