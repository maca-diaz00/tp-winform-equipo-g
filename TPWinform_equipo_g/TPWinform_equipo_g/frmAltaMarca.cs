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
    public partial class frmAltaMarca : Form
    {
        private MarcaNegocio marcaNegocio;
        private Marca marca = null;
        private List<Marca> lista;
        bool bModificar = false;
        RecursoSonoro reproductor;
        public frmAltaMarca()
        {
            InitializeComponent();
            marcaNegocio = new MarcaNegocio();
            marca = new Marca();
            lista = new List<Marca>();
            lista = marcaNegocio.listar();
            reproductor = new RecursoSonoro();

        }

        public frmAltaMarca(Marca modificar)
        {
            InitializeComponent();
            marcaNegocio = new MarcaNegocio();
            marca = modificar;
            lista = new List<Marca>();
            lista = marcaNegocio.listar();
            Text = "Modificar marca";
            bModificar = true;
            reproductor = new RecursoSonoro();
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtNombre.Text = marca.Descripcion;
            }
            dgvMarcas.DataSource = lista;
            dgvMarcas.Columns["Id"].Visible = false;
            dgvMarcas.Visible = false;
            lblOcultarMarcas.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool bExiste = false;
            reproductor.ClickSonido();

            foreach (Marca item in lista)
            {
                if (item.Descripcion.ToUpper() == txtNombre.Text.ToUpper())
                {
                    MessageBox.Show("Ya existe una marca con ese nombre, intente nuevamente");
                    txtNombre.Text = "";
                    bExiste = true;
                }
            }


            if (!bExiste)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Tiene que ingresar un nombre para agregarlo, intente nuevamente");
                }
                else
                {

                    try
                    {
                            marca.Descripcion = txtNombre.Text;
                        if (!bModificar)
                        {
                            marcaNegocio.nuevaMarca(marca);
                            MessageBox.Show("Marca agregada exitosamente!");
                            Close();
                        } else
                        {
                            marcaNegocio.modificarMarca(marca);
                            MessageBox.Show("Marca modificada exitosamente!");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reproductor.ClickSonido();
            Close();
        }

        private void mostrarMarcas(bool mostrar)
        {
            dgvMarcas.Visible = mostrar;
            if (mostrar)
            {
                lblMarcasExistentes.Visible = false;
                lblOcultarMarcas.Visible = true;
            }
            else
            {
                lblOcultarMarcas.Visible = false;
                lblMarcasExistentes.Visible = true;
            }
        }

        private void lblMarcasExistentes_Click(object sender, EventArgs e)
        {
            mostrarMarcas(true);
        }

        private void lblOcultarMarcas_Click(object sender, EventArgs e)
        {
            mostrarMarcas(false);
        }


    }
}