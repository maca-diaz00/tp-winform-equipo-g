using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinform_equipo_g
{
    internal class Validaciones
    {
        public bool soloNumeros(string texto)
        {
            foreach (char item in texto)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }

            }
            return true;
        }

        public bool soloLetras(string texto)
        {
            foreach (char item in texto)
            {
                if (!(char.IsLetter(item)))
                {
                    return false;
                }
            }
            return true;
        }

        public bool longTexto( string texto, int limite)
        {
            if (texto.Count() <= limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool cbxVacio(ComboBox cbx)
        {
            if (cbx.SelectedIndex < 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool existeMarca(int idMarca, List<Marca> lista)
        {
            foreach (Marca item in lista)
            {
                if (item.Id == idMarca)
                {
                    return true;
                }
            }
            return false;
        }

        public bool vacio(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return true;
            }
            else
                return false;
        }
    }
}
