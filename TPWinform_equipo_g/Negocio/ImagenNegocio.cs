using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{

    public class ImagenNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        public void nuevaImagen(Imagen nuevaImagen)
        {


            try
            {
                datos.setearConsulta("Insert to IMAGENES (IdArticulo,ImagenUrl) values (@idArticulo, @url");
                datos.setearParametro("@idArticulo", nuevaImagen.IdArticulo);
                datos.setearParametro("@url", nuevaImagen.UrlImagen);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }



        }
    }
}
