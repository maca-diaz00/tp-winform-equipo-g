using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TPWinform_equipo_g
{
    internal class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<Imagen> Imagenes { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }


        public Articulo()
        {
            Imagenes = new List<Imagen>();
            Marca = new Marca();
            Categoria = new Categoria();
        }


        public void agregarImagen(string nuevaImagen)
        {
            Imagen aux = new Imagen();
            aux.UrlImagen = nuevaImagen;
            Imagenes.Add(aux);
        }

        public void eliminarImagen(string imagen)
        {
            Imagen aux = new Imagen();
            aux.UrlImagen = imagen;
            Imagenes.Remove(aux);
        }

        public int cantidadImagenes()
        {
            return Imagenes.Count;
        }
    }
}
