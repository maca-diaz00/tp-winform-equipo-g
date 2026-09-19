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
    public partial class frmAltaCategoria : Form
    {
        private CategoriaNegocio categoriaNegocio;
        private Categoria categoria = null;
        private List<Categoria> lista;


        //Constructor para agregar nueva categoria
        public frmAltaCategoria()

        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            categoria = new Categoria();
            lista = new List<Categoria>();
            lista = categoriaNegocio.listar();
        }

        //Constructor para modificar categoria
        public frmAltaCategoria(Categoria modificar)
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            categoria = modificar;
            lista = new List<Categoria>();
            lista = categoriaNegocio.listar();
            Text = "Modificar categoria";
        }

        //Carga del formulario
        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtNombreCategoriaNueva.Text = categoria.Descripcion;
            }
        }

        //Boton agregar nueva categoria
        private void btnAgregarCategoriaNueva_Click(object sender, EventArgs e)

        {
            bool bExiste = false;

            foreach (Categoria item in lista)
            {
                if (item.Descripcion.ToUpper() == txtNombreCategoriaNueva.Text.ToUpper())
                {
                    MessageBox.Show("Ya existe una categoría con ese nombre, intente nuevamente");
                    txtNombreCategoriaNueva.Text = "";
                    bExiste = true;
                }
            }


            if (!bExiste)
            {
                if (txtNombreCategoriaNueva.Text == "")
                {
                    MessageBox.Show("Tiene que ingresar un nombre para agregarlo, intente nuevamente");
                }
                else
                {

                    try
                    {

                        categoria.Descripcion = txtNombreCategoriaNueva.Text;
                        if (categoria.Id != 0)
                        {
                            categoriaNegocio.modificarCategoria(categoria);
                            MessageBox.Show("¡Categoría modificada exitosamente!");
                            Close();

                        }
                        else
                        {

                            categoriaNegocio.nuevaCategoria(categoria);
                            MessageBox.Show("¡Categoría agregada exitosamente!");
                            Close();
                        }

                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }

        }

        // Boton cancelar
        private void btnCancelarCategoriaNueva_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}