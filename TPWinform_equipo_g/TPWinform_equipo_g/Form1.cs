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
    public partial class Form1 : Form
    {

        private ArticuloNegocio articuloNegocio;
        private Articulo articuloActual;
        private string tipoListado;
        private int indiceImagen;
        public Form1()
        {
            InitializeComponent();
            articuloNegocio = new ArticuloNegocio();
            articuloActual = new Articulo();
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
            if (dgv_BaseDatos.Visible == false)
            {
                dgv_BaseDatos.Visible = true;
            }
            //else
            //{
                //dgv_BaseDatos.Visible = false;
            //}
            tipoListado = "Categoria";
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgv_BaseDatos.DataSource = categoriaNegocio.listar();
        }

        private void bt_Marca_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false)
            {
                dgv_BaseDatos.Visible = true;
            }
            //else
            //{
                //dgv_BaseDatos.Visible = false;
            //}
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            tipoListado = "Marca";
            dgv_BaseDatos.DataSource = marcaNegocio.listar();

        }

        private void bt_Articulo_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false)
            {
                dgv_BaseDatos.Visible = true;
            }
            //else
            //{
                //dgv_BaseDatos.Visible = false;
            //}
            tipoListado = "Articulo";
            dgv_BaseDatos.DataSource = articuloNegocio.listarArticulos();
            
            


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

            }

            
        }

        private void dgv_BaseDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tipoListado == "Articulo")
            {
                articuloActual = (Articulo)dgv_BaseDatos.CurrentRow.DataBoundItem;
                btnAnteriorImagen.Visible = true;
                btnSiguienteImagen.Visible = true;
                pbxArticulos.Visible = true;
                indiceImagen = 0;
                actualizarBotonesImagenes();
                mostrarImagen(articuloActual, indiceImagen);
            }
        }
        private int cantidadImagenes()
        {
            return articuloActual.Imagenes.Count;
        }

        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
          

            if (indiceImagen < cantidadImagenes()-1)
            {
                indiceImagen++;
                actualizarBotonesImagenes();
                mostrarImagen(articuloActual, indiceImagen);
            }
            
        }

        private void btnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (indiceImagen >0)
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


            if (indiceImagen == cantidadImagenes() - 1)
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
