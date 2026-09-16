using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinform_equipo_g
{
    internal class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            


            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion,M.Descripcion as Marca,C.Descripcion as Categoria, Precio, ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I Where A.IdMarca=M.Id And A.IdCategoria=C.Id And A.Id=I.IdArticulo ");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {

                    bool bArticulo = false;

                    foreach (Articulo item in lista)
                    {
                        if (item.Id == (int)datos.Lector["Id"])
                        {
                            bArticulo = true;
                            item.agregarImagen((string)datos.Lector["ImagenUrl"]);
                        }
                    }

                    if (!bArticulo)
                    {

                        Articulo aux = new Articulo();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Codigo = (string)datos.Lector["Codigo"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                        aux.Precio = (decimal)datos.Lector["Precio"];
                        aux.agregarImagen((string)datos.Lector["ImagenUrl"]);
                        lista.Add(aux);
                    }

                }

                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void nuevoArticulo(Articulo nuevo)
        {
            

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@codigo,@nombre, @descripcion, @marca, @categoria, @precio)");
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@marca", nuevo.Marca.Id);
                datos.setearParametro("@categoria", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);
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
