using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
