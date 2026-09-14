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
        public Form1()
        {
            InitializeComponent();
            articuloNegocio = new ArticuloNegocio();
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
            else
            {
                dgv_BaseDatos.Visible = false;
            }
        }

        private void bt_Marca_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false)
            {
                dgv_BaseDatos.Visible = true;
            }
            else
            {
                dgv_BaseDatos.Visible = false;
            }
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            dgv_BaseDatos.DataSource = marcaNegocio.listar();

        }

        private void bt_Articulo_Click(object sender, EventArgs e)
        {
            if (dgv_BaseDatos.Visible == false)
            {
                dgv_BaseDatos.Visible = true;
            }
            else
            {
                dgv_BaseDatos.Visible = false;
            }
            dgv_BaseDatos.DataSource = articuloNegocio.listarArticulos();


        }
    }
}
