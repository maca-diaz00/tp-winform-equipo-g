using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinform_equipo_g
{

        internal class CategoriaNegocio
        {
            public List<Categoria> listar()
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("Select Id, Descripcion from CATEGORIAS");
                    datos.ejecutarConsulta();

                    while (datos.Lector.Read())
                    {
                        Categoria aux = new Categoria();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                        listaCategorias.Add(aux);
                    }

                    return listaCategorias;
                }
                catch (Exception ex)
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

