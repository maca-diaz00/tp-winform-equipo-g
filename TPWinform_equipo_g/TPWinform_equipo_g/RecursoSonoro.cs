using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinform_equipo_g
{
    internal class RecursoSonoro
    {
        public void ClickSonido()
        {
            System.Media.SoundPlayer reproductor = new System.Media.SoundPlayer(TPWinform_equipo_g.Properties.Resources.click);
            reproductor.Play();
        }
        public void ErrorSonido()
        {
            System.Media.SoundPlayer reproductor = new System.Media.SoundPlayer(TPWinform_equipo_g.Properties.Resources.errorEmergente);
            reproductor.Play();
        }
    }
}
